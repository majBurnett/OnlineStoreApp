using StoreClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreGUIApp
{
    public partial class Form1 : Form
    {
        OnlineStore os = new OnlineStore();
        //InventoryItemSummary invenISummary = new InventoryItemSummary();

        BindingSource productInventoryBindingSource = new BindingSource();
        BindingSource productViewInventoryBindingSource = new BindingSource();
        BindingSource productSellInventoryBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateBindings()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productInventoryBindingSource.DataSource = os.productsList;
            lst_inventoryList.DataSource = productInventoryBindingSource;
        }

        private void btn_createproduct_Click(object sender, EventArgs e)
        {

            ProductsPurchaseOrder ppo = new ProductsPurchaseOrder(txt_Type.Text, txt_Model.Text,decimal.Parse(txt_Price.Text), int.Parse(txt_Amount.Text));
            //MessageBox.Show(ppo.ToString());
            os.AddProductsToInventory(ppo);
            txt_Type.Text = "";
            txt_Model.Text = "";
            txt_Price.Text = "";
            txt_Amount.Text = "";

        }
        private void btn_updatelist_Click(object sender, EventArgs e)
        {
            os.GetInventorySummary();
            productInventoryBindingSource.ResetBindings(false);
        }

        private void btn_findproduct_Click(object sender, EventArgs e)
        {
            ProductType productType = new ProductType(txt_Type.Text, txt_Model.Text);
            os.GetInventoryItemSummary(productType);

            productViewInventoryBindingSource.DataSource = os.shoppingList;
            lst_findList.DataSource = productViewInventoryBindingSource;
            productViewInventoryBindingSource.ResetBindings(false);
        }
        private void btn_sellproduct_Click(object sender, EventArgs e)
        {
            ProductsSellOrder pso = new ProductsSellOrder(txt_Type.Text, txt_Model.Text, int.Parse(txt_Amount.Text));
            os.SellProductsFromInventory(pso);

            productSellInventoryBinding.DataSource = os.soldList;
            lst_soldList.DataSource = productSellInventoryBinding.DataSource;
            productSellInventoryBinding.ResetBindings(false);
        }

        private void lst_inventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Amount.Enabled = false;
            txt_Price.Enabled = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_Type.Enabled = true;
            txt_Model.Enabled = true;
            txt_Amount.Enabled = true;
            txt_Price.Enabled = true;
        }
    }
}
