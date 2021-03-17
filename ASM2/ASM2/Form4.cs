using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class Form4 : Form
    {
        DriveThruMachine machine = new DriveThruMachine();
        IAdaptor adaptor = new DriveThruAdaptor(KFCStore.getKFCStore());
        DataTable table = new DataTable();
        List<string> productlist = new List<string>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label_form4_TotalCost.Text = machine.totalcost.ToString()+"$";
            table.Columns.Add("Product number", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
        }

        private void addProductToGridView(List<Product> items)
        {
            table.Rows.Clear();
            foreach (Product item in items)
            {
                table.Rows.Add(item.item, item.quantity);
            }
            datagridview_DriveThru.DataSource = table;
            label_form4_TotalCost.Text = String.Format("{0:0.00}", machine.totalcost);
        }

       

        private void btn_Request_Click(object sender, EventArgs e)
        {
            adaptor.inputOrder(machine.requestOrders());
            this.Close();
        }

        private void btn_addChickenWing_Click(object sender, EventArgs e)
        {
            machine.addOrder(1);
            machine.totalcost += 1.99;
            addProductToGridView(machine.items);
        }
        private void btn_addChickenDrum_Click(object sender, EventArgs e)
        {
            machine.addOrder(2);
            machine.totalcost += 2.50;
            addProductToGridView(machine.items);
        }

        private void btn_addChickenNugget_Click(object sender, EventArgs e)
        {
            machine.addOrder(3);
            machine.totalcost += 0.50;
            addProductToGridView(machine.items);
        }

        private void btn_addSoda_Click(object sender, EventArgs e)
        {
            machine.addOrder(4);
            machine.totalcost += 0.99;
            addProductToGridView(machine.items);
        }

        private void btn_addCoke_Click(object sender, EventArgs e)
        {
            machine.addOrder(5);
            machine.totalcost += 0.99;
            addProductToGridView(machine.items);
        }

        private void btn_addPepsi_Click(object sender, EventArgs e)
        {
            machine.addOrder(6);
            machine.totalcost += 0.99;
            addProductToGridView(machine.items);
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if(machine.items.Count > 0)
            {
                int number = Convert.ToInt32(datagridview_DriveThru.SelectedRows[0].Cells[0].Value);
                machine.removeProduct(number);
                switch (number)
                {
                    case 1:
                        machine.totalcost -= 1.99;
                        break;
                    case 2:
                        machine.totalcost -= 2.50;
                        break;
                    case 3:
                        machine.totalcost -= 0.50;
                        break;
                    case 4:
                        machine.totalcost -= 0.99;
                        break;
                    case 5:
                        machine.totalcost -= 0.99;
                        break;
                    case 6:
                        machine.totalcost -= 0.99;
                        break;
                }
                Console.WriteLine(machine.totalcost);
                addProductToGridView(machine.items);
            }
        }
    }
}
