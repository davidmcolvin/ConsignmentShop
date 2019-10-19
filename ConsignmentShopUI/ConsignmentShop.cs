using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConsignmentShopLibrary.EnumUtility.ConsignmentShopLibraryEnums;

namespace ConsignmentShopUI
{
  public partial class ConsignmentShop : Form
  {
    private Store store = new Store();
    private List<Item> shoppingCartData = new List<Item>();
    BindingSource itemsBinding = new BindingSource();
    BindingSource cartBinding = new BindingSource();
    BindingSource vendorsBinding = new BindingSource();
    private decimal storeProfit = 0;

    public ConsignmentShop()
    {
      InitializeComponent();
      SetupData();

      itemsBinding.DataSource = store.Items.Where( x => x.Status == ItemStatus.Available).ToList();
      itemsListbox.DataSource = itemsBinding;

      itemsListbox.DisplayMember = "Display";
      itemsListbox.ValueMember = "Display";

      cartBinding.DataSource = shoppingCartData;
      shoppingCartListbox.DataSource = cartBinding;

      shoppingCartListbox.DisplayMember = "Display";
      shoppingCartListbox.ValueMember = "Display";

      vendorsBinding.DataSource = store.Vendors;
      vendorListbox.DataSource = vendorsBinding;

      vendorListbox.DisplayMember = "Display";
      vendorListbox.ValueMember = "Display";
    }

    private void SetupData()
    {
      store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
      store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

      store.Items.Add(new Item()
      {
        Title = "Moby Dick",
        Description = "A book about a whale",
        Price = 4.50M,
        Owner = store.Vendors[0]
      });

      store.Items.Add(new Item()
      {
        Title = "A Tale of Two Cities",
        Description = "A book about a revolution",
        Price = 3.80M,
        Owner = store.Vendors[1]
      });

      store.Items.Add(new Item()
      {
        Title = "Harry Potter Book 1",
        Description = "A book about a boy",
        Price = 5.20M,
        Owner = store.Vendors[1]
      });

      store.Items.Add(new Item()
      {
        Title = "Jane Eyre",
        Description = "A book about a girl",
        Price = 1.50M,
        Owner = store.Vendors[0]
      });

      store.Name = "Seconds are Better";

    }

    private void addToCart_Click(object sender, EventArgs e)
    {
      // Figure out what is selected from the items list
      // Copy that item to the shopping cart
      if (itemsListbox.Items.Count > 0)
      {
        Item selectedItem = (Item)itemsListbox.SelectedItem;
        selectedItem.Status = ItemStatus.Pending;

        shoppingCartData.Add(selectedItem);

        itemsBinding.DataSource = store.Items.Where(x => x.Status == ItemStatus.Available).ToList();
        itemsBinding.ResetBindings(false);

        cartBinding.ResetBindings(false);
      }
    }

    private void makePurchase_Click(object sender, EventArgs e)
    {
      // Mark each item in the cart as sold
      // Clear the cart

      foreach ( Item item in shoppingCartData )
      {
        item.Status = ItemStatus.Sold;
        item.Owner.PaymentDue += Math.Round( (decimal)item.Owner.Commission * item.Price, 2);
        storeProfit += Math.Round((decimal)(1 - item.Owner.Commission) * item.Price, 2);
      }

      shoppingCartData.Clear();

      itemsBinding.DataSource = store.Items.Where(x => x.Status == ItemStatus.Available).ToList();

      cartBinding.ResetBindings(false);
      itemsBinding.ResetBindings(false);
      vendorsBinding.ResetBindings(false);
      storeProfitValue.Text = string.Format("${0}", storeProfit);
    }
  }
}
