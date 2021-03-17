using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Form3_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            label_cost.Text = String.Format("{0:0.00}$",KFCStore.getKFCStore().getTotalCost());
            box_datetime.Text = DateTime.Now.ToString();
            checkRadioBtn();
        }

        private void checkRadioBtn()
        {
            if(KFCStore.getKFCStore().GetDiscount() is NoDiscount)
            {
                radiobtn_NoDiscount.Checked = true;
            }
            else if(KFCStore.getKFCStore().GetDiscount() is MondayDiscount)
            {
                radiobtn_MondayDiscount.Checked = true;
            }
            else { radiobtn_MondayKidDiscount.Checked = true; }
        }

        private void loadDataGridView()
        {
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Cost", typeof(double));
            foreach (IItem item in KFCStore.getKFCStore().items)
            {
                table.Rows.Add(item.name, item.getQuantity(), item.getCost());
            }
            datagridview_billing.DataSource = table;
        }

        private void radiobtn_NoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            KFCStore.getKFCStore().setDiscount(new NoDiscount());
            label_cost.Text = String.Format("{0:0.00}$", KFCStore.getKFCStore().getTotalCost());
        }

        private void radiobtn_MondayDiscount_CheckedChanged(object sender, EventArgs e)
        {
            KFCStore.getKFCStore().setDiscount(new MondayDiscount());
            label_cost.Text = String.Format("{0:0.00}$", KFCStore.getKFCStore().getTotalCost());
        }

        private void radiobtn_MondayKidDiscount_CheckedChanged(object sender, EventArgs e)
        {
            KFCStore.getKFCStore().setDiscount(new MondayKidDiscount());
            label_cost.Text = String.Format("{0:0.00}$", KFCStore.getKFCStore().getTotalCost());
        }

        private void btn_printbill_Click(object sender, EventArgs e)
        {
            DateTime datetime = Convert.ToDateTime(box_datetime.Text);

            StreamWriter writer = new StreamWriter("Text.txt");

            writer.WriteLine("Printed bill\n--------------------");

            writer.WriteLine("Date: " + datetime.ToString("d") + ", Time: " + datetime.ToString("T"));
            writer.WriteLine("----------------------------------");
            foreach (IItem item in KFCStore.getKFCStore().items)
            {
                writer.WriteLine("\t{0}\t|\t{1}\t|\t",item.name,item.getQuantity(), item.getCost());
                writer.WriteLine("----------------------------------");
                
            }
            writer.WriteLine("Total cost: " + label_cost.Text);
            writer.Close();

            KFCStore.getKFCStore().reset();
            this.Close();
        }
    }
}
