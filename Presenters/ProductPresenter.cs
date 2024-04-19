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

        private void SearchProduct(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.view.SearchValue))
            {
                productList = repository.Search(this.view.SearchValue);
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
            product.Id = view.ProductId;
            product.Name = view.ProductName;
            product.CategoryId = view.CategoryId;
            product.ProviderId = view.ProviderId;
            product.Price = view.Price;
            product.StockQuantity = view.StockQuantity;

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
            view.ProductId = 0;
            view.ProductName = "";
            view.CategoryId = 0;
            view.ProviderId = 0;
            view.Price = 0;
            view.StockQuantity = 0;
        }

        private void LoadSelectProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id;
            view.ProductName = product.Name;
            view.CategoryId = product.CategoryId;
            view.ProviderId = product.ProviderId;
            view.Price = product.Price;
            view.StockQuantity = product.StockQuantity;

            view.IsEdit = true;
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
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
