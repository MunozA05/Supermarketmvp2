using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        int CategoryId { get; set; }
        int ProviderId { get; set; }
        decimal Price { get; set; }
        int StockQuantity { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBildingSource(BindingSource productList);
        void Show();
    }
}
