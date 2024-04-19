using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Supermarket_mvp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {                
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Product VALUES (@product_name, @category_Id, @provider_Id, @price, @stock_Quantity)";
                    command.Parameters.Add("@product_name", SqlDbType.NVarChar).Value = productModel.ProductName;
                    command.Parameters.Add("@category_Id", SqlDbType.Int).Value = productModel.CategoryId;
                    command.Parameters.Add("@provider_Id", SqlDbType.Int).Value = productModel.ProviderId;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                    command.Parameters.Add("@stock_Quantity", SqlDbType.Int).Value = productModel.StockQuantity;
                    command.ExecuteNonQuery();                
            }
        }

        public void Delete(int productId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Product WHERE ProductID = @id";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.ExecuteNonQuery();                
            }
        }

        public void Edit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {               
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Product
                                            SET Product_Name = @name, 
                                            Category_Id = @categoryId,
                                            Provider_Id = @providerId,
                                            Price = @price,
                                            Stock_Quantity = @stockQuantity 
                                            WHERE Product_Id = @id";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.ProductName;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                    command.Parameters.Add("@providerId", SqlDbType.Int).Value = productModel.ProviderId;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = productModel.Price;
                    command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = productModel.StockQuantity;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.ProductId;
                    command.ExecuteNonQuery();                
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {                
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             var productModel = new ProductModel();
                        productModel.ProductId = (int)reader["Product_Id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productModel.ProviderId = (int)reader["Provider_Id"];
                        productModel.Price = (decimal)reader["Price"];
                        productModel.StockQuantity = (int)reader["Stock_Quantity"];
                        productList.Add(productModel);
                        }
                    }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValues(string values)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(values, out _) ? Convert.ToInt32(values) : 0;
            string productName = values;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Product
                                          WHERE Product_Id = @id OR Product_Name LIKE @name+ '%'
                                          ORDER By Product_Id DESC";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader["Product_Id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productModel.ProviderId = (int)reader["Provider_Id"];
                        productModel.Price = (decimal)reader["Price"];
                        productModel.StockQuantity = (int)reader["Stock_Quantity"];                            
                        productList.Add(productModel);
                        }
                    }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByCategory(int categoryId)
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                WHERE CategoryId = @categoryId
                                ORDER BY Product_Id DESC";
                command.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader["Product_Id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productModel.ProviderId = (int)reader["Provider_Id"];
                        productModel.Price = (decimal)reader["Price"];
                        productModel.StockQuantity = (int)reader["Stock_Quantity"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByProvider(int providerId)
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                WHERE ProviderId = @providerId
                                ORDER BY Product_Id DESC";
                command.Parameters.Add("@providerId", SqlDbType.Int).Value = providerId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader["Product_Id"];
                        productModel.ProductName = reader["Product_Name"].ToString();
                        productModel.CategoryId = (int)reader["Category_Id"];
                        productModel.ProviderId = (int)reader["Provider_Id"];
                        productModel.Price = (decimal)reader["Price"];
                        productModel.StockQuantity = (int)reader["Stock_Quantity"];
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> Search(string searchTerm)
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Product
                                    WHERE ProductName LIKE @searchTerm 
                                    OR CategoryId IN (SELECT CategoryId FROM Category WHERE CategoryName LIKE @searchTerm) 
                                    OR ProviderId IN (SELECT ProviderId FROM Provider WHERE ProviderName LIKE @searchTerm)
                                    ORDER BY Product_Id DESC";
                    command.Parameters.Add("@searchTerm", SqlDbType.NVarChar).Value = $"%{searchTerm}%";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        var productModel = new ProductModel();
                        productModel.ProductId = (int)reader["ProductID"];
                        productModel.ProductName = reader["ProductName"].ToString();
                        productModel.CategoryId = (int)reader["CategoryId"];
                        productModel.ProviderId = (int)reader["ProviderId"];
                        productModel.Price = (decimal)reader["Price"];
                        productModel.StockQuantity = (int)reader["StockQuantity"];
                        productList.Add(productModel);
                        }
                    }       
            }
            return productList;
        }
    }
}