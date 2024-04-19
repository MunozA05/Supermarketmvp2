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
        public ProductRepository(string connectionString) : base(connectionString) { }

        public void Add(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
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

        public void Edit(ProductModel product)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Product SET ProductName = @name, CategoryId = @categoryId, ProviderId = @providerId, Price = @price, StockQuantity = @stockQuantity WHERE ProductID = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.ProductName;
                command.Parameters.Add("@categoryId", SqlDbType.Int).Value = product.CategoryId;
                command.Parameters.Add("@providerId", SqlDbType.Int).Value = product.ProviderId;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                command.Parameters.Add("@stockQuantity", SqlDbType.Int).Value = product.StockQuantity;
                command.Parameters.Add("@id", SqlDbType.Int).Value = product.ProductID;
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
                command.CommandText = "SELECT * FROM Product";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            ProductID = (int)reader["ProductID"],
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
                command.CommandText = "SELECT * FROM Product WHERE ProductID = @id OR ProductName LIKE @name+'%'";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel
                        {
                            ProductID = (int)reader["ProductID"],
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
            return productList;
        }
    }
}