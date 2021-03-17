using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ASM2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            foreach (IItem item in KFCStore.getKFCStore().items)
            {
                table.Rows.Add(item.name, item.getQuantity());
            }
            datagridview_Product.DataSource = table;
        }

        public int showInputBox()
        {
            string quantity = Interaction.InputBox("Enter quantity", "Input box", "0", 250, 250);
            if (Information.IsNumeric(quantity))
            {
                return Convert.ToInt32(quantity);
            }
            else
            {
                return 0;
            }
        }
        DataTable table = new DataTable();

        private void addProductToGridView(string product, int quantity)
        {
            table.Rows.Add(product, quantity);
            datagridview_Product.Refresh();
        }

        private void btn_addChickenWing_Click_1(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Chicken Wing", quantity);
                addProductToGridView("Chicken Wing", quantity);
            }
        }

        private void btn_addChickenDrum_Click(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Chicken Drum", quantity);
                addProductToGridView("Chicken Drum", quantity);
            }

        }

        private void btn_ChickenNugget_Click(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Chicken Nugget", quantity);
                addProductToGridView("Chicken Nugget", quantity);
            }

        }

        private void btn_addSoda_Click(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Soda", quantity);
                addProductToGridView("Soda", quantity);
            }

        }

        private void btn_addCoke_Click(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Coke", quantity);
                addProductToGridView("Coke", quantity);
            }

        }

        private void btn_addPepsi_Click(object sender, EventArgs e)
        {
            int quantity = showInputBox();
            if (quantity != 0)
            {
                KFCStore.getKFCStore().addItem("Pepsi", quantity);
                addProductToGridView("Pepsi", quantity);
            }

        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if (datagridview_Product.SelectedRows.Count > 0)
            {
                string choice = datagridview_Product.SelectedRows[0].Cells[0].Value.ToString();
                int quantity = Convert.ToInt32(datagridview_Product.SelectedRows[0].Cells[1].Value);
                removeItem(choice, quantity);

            }
        }

        private void removeItem(string selected_name, int selected_quantity)
        {
            datagridview_Product.Rows.Remove(datagridview_Product.SelectedRows[0]);
            KFCStore.getKFCStore().removeItem(selected_name, selected_quantity);
        }
        private void datagridview_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
