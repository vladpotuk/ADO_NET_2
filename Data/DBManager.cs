using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Data
{
    public class DBManager
    {
        public string ConnectionString = "Data Source=\"10.0.0.40,1603\";Initial Catalog=warehouse;User ID=slimt;Password=1604;Encrypt=True;TrustServerCertificate=True";

        public DBManager()
        {

        }

        

        public void InsertNewProduct(string productName, int productTypeID, int supplierID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, ProductTypeID, SupplierID) VALUES (@productName, @productTypeID, @supplierID)", connection);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@productTypeID", productTypeID);
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(int productID, string newProductName, int newProductTypeID, int newSupplierID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @newProductName, ProductTypeID = @newProductTypeID, SupplierID = @newSupplierID WHERE ProductID = @productID", connection);
                    cmd.Parameters.AddWithValue("@newProductName", newProductName);
                    cmd.Parameters.AddWithValue("@newProductTypeID", newProductTypeID);
                    cmd.Parameters.AddWithValue("@newSupplierID", newSupplierID);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(int productID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @productID", connection);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public void InsertNewProductType(string typeName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ProductTypes (TypeName) VALUES (@typeName)", connection);
                    cmd.Parameters.AddWithValue("@typeName", typeName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProductType(int productTypeID, string newTypeName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ProductTypes SET TypeName = @newTypeName WHERE ProductTypeID = @productTypeID", connection);
                    cmd.Parameters.AddWithValue("@newTypeName", newTypeName);
                    cmd.Parameters.AddWithValue("@productTypeID", productTypeID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProductType(int productTypeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ProductTypes WHERE ProductTypeID = @productTypeID", connection);
                    cmd.Parameters.AddWithValue("@productTypeID", productTypeID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public void InsertNewSupplier(string supplierName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers (SupplierName) VALUES (@supplierName)", connection);
                    cmd.Parameters.AddWithValue("@supplierName", supplierName);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateSupplier(int supplierID, string newSupplierName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Suppliers SET SupplierName = @newSupplierName WHERE SupplierID = @supplierID", connection);
                    cmd.Parameters.AddWithValue("@newSupplierName", newSupplierName);
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteSupplier(int supplierID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierID = @supplierID", connection);
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

    }
}
