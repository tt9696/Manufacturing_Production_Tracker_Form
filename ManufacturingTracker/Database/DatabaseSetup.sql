-- ============================================
-- Manufacturing Production Tracker
-- Database Setup Script
-- ============================================
-- Create Database
CREATE DATABASE ManufacturingDB;
GO

USE ManufacturingDB;
GO
-- ============================================
-- Create Production Table
-- ============================================
CREATE TABLE Production
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Defect INT NOT NULL,
    DowntimeMinutes INT NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL
);
GO
-- ============================================
-- Insert Sample Data
-- ============================================

INSERT INTO Production
(ProductName, Quantity, Defect, DowntimeMinutes)
VALUES
('PCB-A', 1200, 12, 15),
('PCB-B', 950, 8, 10),
('PCB-C', 1500, 20, 25),
('PCB-D', 1100, 5, 8),
('PCB-E', 1350, 14, 18);

GO

-- ============================================
-- Verify Data
-- ============================================

SELECT *
FROM Production;
GO