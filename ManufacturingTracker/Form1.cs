using OfficeOpenXml;
using System.Data;
using System.IO;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;


namespace ManufacturingTracker
{
    public partial class Form1 : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        private int selectedId = 0; //Update button

        private void LoadData()
        {
            dataGridView1.DataSource = db.GetProductionTable();

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToAddRows = false;
        }
        public Form1()
        {
            InitializeComponent();

            LoadData();
            LoadKPI();
            LoadChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string product = txtProduct.Text;

                int qty = int.Parse(txtQuantity.Text);
                int defect = int.Parse(txtDefect.Text);
                int downtime = int.Parse(txtDowntime.Text);

                db.InsertProduction(
                product,
                qty,
                defect,
                downtime);

                LoadData(); //Display database in form UI
                LoadKPI();
                LoadChart();

                //Clear textboxes after save
                txtProduct.Clear();
                txtQuantity.Clear();
                txtDefect.Clear();
                txtDowntime.Clear();

                txtProduct.Focus();

                MessageBox.Show("Record Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                txtProduct.Text =
                    row.Cells["ProductName"].Value?.ToString();

                txtQuantity.Text =
                    row.Cells["Quantity"].Value?.ToString();

                txtDefect.Text =
                    row.Cells["Defect"].Value?.ToString();

                txtDowntime.Text =
                    row.Cells["DowntimeMinutes"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record");
                return;

            }
            db.UpdateProduction(selectedId,
            txtProduct.Text,
            int.Parse(txtQuantity.Text),
            int.Parse(txtDefect.Text),
            int.Parse(txtDowntime.Text));

            LoadData();
            LoadKPI();
            LoadChart();

            MessageBox.Show("Record Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.DeleteProduction(selectedId);
                LoadData();
                LoadKPI();//load dashboard realtime
                LoadChart();
                selectedId = 0;
                MessageBox.Show("Record Deleted!");
            }
        }

        //Search function
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SearchProduction(txtSearch.Text);
        }

        //Export to Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExcelPackage.License.SetNonCommercialPersonal("YourName");

            using SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel Files|*.xlsx";

            saveFileDialog.FileName = "ProductionReport.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using ExcelPackage package = new ExcelPackage();

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Production");

                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataGridView1.Columns[col].HeaderText;
                }


                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();
                    }
                }
                File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());

                MessageBox.Show("Export Successful !");
            }
        }

        private void LoadKPI()
        {
            DataTable dt = db.GetKPI();

            if (dt.Rows.Count > 0)
            {
                int production = Convert.ToInt32(dt.Rows[0]["TotalProduction"]);

                int defects = Convert.ToInt32(dt.Rows[0]["TotalDefects"]);

                int downtime = Convert.ToInt32(dt.Rows[0]["TotalDowntime"]);

                double defectRate = production > 0 ? (double)defects / production * 100 : 0;

                lblTotalProduction.Text = production.ToString();

                lblTotalDefects.Text = defects.ToString();

                lblDefectRate.Text = defectRate.ToString("F2") + "%";

                lblTotalDowntime.Text = downtime.ToString();

            }

        }
        private void LoadChart()
        {
            DataTable dt = db.GetProductionTable();

            List<int> production = new();
            List<int> defects = new();
            List<string> products = new();

            foreach (DataRow row in dt.Rows)
            {
                products.Add(row["ProductName"].ToString()!);

                production.Add(Convert.ToInt32(row["Quantity"]));

                defects.Add(Convert.ToInt32(row["Defect"]));
            }

            sourceGenCartesianChart1.Series = new ISeries[]
            {
        new ColumnSeries<int>
        {
            Name = "Production",
            Values = production,
            Fill = new SolidColorPaint(SKColor.Parse("#28A745")),
            MaxBarWidth = 20
        },

        new ColumnSeries<int>
        {
            Name = "Defects",
            Values = defects,
            Fill = new SolidColorPaint(SKColor.Parse("#DC3545")),
            MaxBarWidth = 20
        }
            };

            sourceGenCartesianChart1.XAxes = new Axis[]
            {
        new Axis
        {
            Name = "Product",
            Labels = products
        }
            };

            sourceGenCartesianChart1.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Quantity",
            MinLimit = 0
        }
            };
        }
    }
}
//Press Ctrl + Shift + B to build