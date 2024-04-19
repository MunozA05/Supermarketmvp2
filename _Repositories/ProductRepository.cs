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
        public ProductRepository(string connectionString) : base(connectionString)
        {
        }


        public void Add(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Product (ProductName, CategoryId, ProviderId, Price, StockQuantity) VALUES (@name, @categoryId, @providerId, @price, @stockQuantity)";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.ProductName;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = product.CategoryId;
                    command.Parameters.Add("@providerId", SqlDbType.Int).Value = product.ProviderId;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                    command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = product.StockQuantity;
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
        }

        public void Delete(int productId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Product WHERE ProductID = @id";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
        }

        public void Edit(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Product SET ProductName = @name, CategoryId = @categoryId, ProviderId = @providerId, Price = @price, StockQuantity = @stockQuantity WHERE ProductID = @id";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.ProductName;
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = product.CategoryId;
                    command.Parameters.Add("@providerId", SqlDbType.Int).Value = product.ProviderId;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                    command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = product.StockQuantity;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = product.ProductId;
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel
                            {
                                ProductId = (int)reader["Product_Id"],
                                ProductName = reader["Product_Name"].ToString(),
                                CategoryId = (int)reader["Category_Id"],
                                ProviderId = (int)reader["Provider_Id"],
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["Stock_Quantity"]
                            };
                            productList.Add(product);
                        }
                    }
                }
                catch (SqlException ex)
                {                    
                    throw;
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
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product WHERE ProductID = @id OR ProductName LIKE @name+'%'";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel
                            {
                                ProductId = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = (int)reader["CategoryId"],
                                ProviderId = (int)reader["ProviderId"],
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["StockQuantity"]
                            };
                            productList.Add(product);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw;
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
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product WHERE CategoryId = @categoryId";
                    command.Parameters.Add("@categoryId", SqlDbType.Int).Value = categoryId;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel
                            {
                                ProductId = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = (int)reader["CategoryId"],
                                ProviderId = (int)reader["ProviderId"],
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["StockQuantity"]
                            };
                            productList.Add(product);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw;
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
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product WHERE ProviderId = @providerId";
                    command.Parameters.Add("@providerId", SqlDbType.Int).Value = providerId;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel
                            {
                                ProductId = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = (int)reader["CategoryId"],
                                ProviderId = (int)reader["ProviderId"],
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["StockQuantity"]
                            };
                            productList.Add(product);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw;
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
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Product WHERE ProductName LIKE @searchTerm OR CategoryId IN (SELECT CategoryId FROM Category WHERE CategoryName LIKE @searchTerm) OR ProviderId IN (SELECT ProviderId FROM Provider WHERE ProviderName LIKE @searchTerm)";
                    command.Parameters.Add("@searchTerm", SqlDbType.NVarChar).Value = $"%{searchTerm}%";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new ProductModel
                            {
                                ProductId = (int)reader["ProductID"],
                                ProductName = reader["ProductName"].ToString(),
                                CategoryId = (int)reader["CategoryId"],
                                ProviderId = (int)reader["ProviderId"],
                                Price = (decimal)reader["Price"],
                                StockQuantity = (int)reader["StockQuantity"]
                            };
                            productList.Add(product);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw;
                }
            }
            return productList;
        }
    }
}