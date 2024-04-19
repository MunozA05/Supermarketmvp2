using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            LoadAllProductList();

            this.view.Show();
        }

        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;  
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValues(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var product = new ProductModel();
            product.ProductId = Convert.ToInt32(view.ProductId);
            product.ProductName = view.ProductName;
            product.CategoryId = Convert.ToInt32(view.CategoryId);
            product.ProviderId = Convert.ToInt32(view.ProviderId);
            product.Price = Convert.ToInt32(view.Price);
            product.StockQuantity = Convert.ToInt32(view.StockQuantity);

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfully";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.CategoryId = "0";
            view.ProviderId = "0";
            view.Price = "0";
            view.StockQuantity = "0";
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.ProductId.ToString();
            view.ProductName = product.ProductName;
            view.CategoryId = product.CategoryId.ToString();
            view.ProviderId = product.ProviderId.ToString();
            view.Price = product.Price.ToString();
            view.StockQuantity = product.StockQuantity.ToString();

            view.IsEdit = false;
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.ProductId);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete product";
            }
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        
    }
}
