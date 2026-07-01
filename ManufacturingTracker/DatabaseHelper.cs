using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ManufacturingTracker
{
    public class DatabaseHelper
    {
        // private string connectionString = "Server=localhost\\SQLEXPRESS;Database=ManufacturingDB;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ManufacturingDB"].ConnectionString;

        //Add record
        public void InsertProduction(string product, int qty, int defect, int downtime)
        {
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = @"
        INSERT INTO Production
        (
            ProductName,
            Quantity,
            Defect,
            DowntimeMinutes
        )
        VALUES
        (
            @product,
            @qty,
            @defect,
            @downtime
        );";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@defect", defect);
            cmd.Parameters.AddWithValue("@downtime", downtime);

            cmd.ExecuteNonQuery();
        }
        public DataTable GetProductionTable()
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string query = "SELECT * FROM Production";

            using SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);

            return dt;
        }

        //UPDATE RECORD
        public void UpdateProduction(
            int id,
            string product, 
            int qty,
            int defect,
            int downtime) 
{
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = @"
            UPDATE Production
            SET
                ProductName = @product,
                Quantity = @qty,
                Defect = @defect,
                DowntimeMinutes = @downtime,
                UpdatedAt = GETDATE()
            WHERE Id = @id";

        SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@defect", defect);
            cmd.Parameters.AddWithValue("@downtime", downtime);

cmd.ExecuteNonQuery();
        }
//Delete 
        public void DeleteProduction(int id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Production WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }
        //Search
        public DataTable SearchProduction(string keyword) {

            DataTable dt = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = @"SELECT * FROM PRODUCTION
            WHERE ProductName LIKE @keyword";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");//% wildcard LIKE '%PCB%'

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            return dt;

        }

        //dashboard
        public DataTable GetKPI() {

            DataTable dt = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string query = @"SELECT ISNULL(SUM(Quantity), 0) AS TotalProduction,
                            ISNULL (SUM(Defect), 0) AS TotalDefects,
                            ISNULL (SUM(DowntimeMinutes), 0) AS TotalDowntime
                            FROM Production";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            adapter.Fill(dt);

            return dt;
        }
    }
}
    
