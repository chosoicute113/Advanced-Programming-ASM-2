
namespace ASM2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridview_billing = new System.Windows.Forms.DataGridView();
            this.box_datetime = new System.Windows.Forms.TextBox();
            this.label_datatime = new System.Windows.Forms.Label();
            this.radiobtn_NoDiscount = new System.Windows.Forms.RadioButton();
            this.radiobtn_MondayDiscount = new System.Windows.Forms.RadioButton();
            this.radiobtn_MondayKidDiscount = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.btn_printbill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_billing)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview_billing
            // 
            this.datagridview_billing.BackgroundColor = System.Drawing.Color.Red;
            this.datagridview_billing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_billing.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridview_billing.Location = new System.Drawing.Point(506, 0);
            this.datagridview_billing.Name = "datagridview_billing";
            this.datagridview_billing.RowHeadersWidth = 51;
            this.datagridview_billing.RowTemplate.Height = 24;
            this.datagridview_billing.Size = new System.Drawing.Size(330, 517);
            this.datagridview_billing.TabIndex = 0;
            // 
            // box_datetime
            // 
            this.box_datetime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.box_datetime.Location = new System.Drawing.Point(130, 74);
            this.box_datetime.Name = "box_datetime";
            this.box_datetime.ReadOnly = true;
            this.box_datetime.Size = new System.Drawing.Size(195, 22);
            this.box_datetime.TabIndex = 1;
            // 
            // label_datatime
            // 
            this.label_datatime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_datatime.AutoSize = true;
            this.label_datatime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datatime.Location = new System.Drawing.Point(67, 45);
            this.label_datatime.Name = "label_datatime";
            this.label_datatime.Size = new System.Drawing.Size(148, 26);
            this.label_datatime.TabIndex = 2;
            this.label_datatime.Text = "Date and time";
            // 
            // radiobtn_NoDiscount
            // 
            this.radiobtn_NoDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtn_NoDiscount.AutoSize = true;
            this.radiobtn_NoDiscount.Location = new System.Drawing.Point(130, 156);
            this.radiobtn_NoDiscount.Name = "radiobtn_NoDiscount";
            this.radiobtn_NoDiscount.Size = new System.Drawing.Size(104, 21);
            this.radiobtn_NoDiscount.TabIndex = 3;
            this.radiobtn_NoDiscount.TabStop = true;
            this.radiobtn_NoDiscount.Text = "No discount";
            this.radiobtn_NoDiscount.UseVisualStyleBackColor = true;
            this.radiobtn_NoDiscount.CheckedChanged += new System.EventHandler(this.radiobtn_NoDiscount_CheckedChanged);
            // 
            // radiobtn_MondayDiscount
            // 
            this.radiobtn_MondayDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtn_MondayDiscount.AutoSize = true;
            this.radiobtn_MondayDiscount.Location = new System.Drawing.Point(130, 183);
            this.radiobtn_MondayDiscount.Name = "radiobtn_MondayDiscount";
            this.radiobtn_MondayDiscount.Size = new System.Drawing.Size(136, 21);
            this.radiobtn_MondayDiscount.TabIndex = 4;
            this.radiobtn_MondayDiscount.TabStop = true;
            this.radiobtn_MondayDiscount.Text = "Monday discount";
            this.radiobtn_MondayDiscount.UseVisualStyleBackColor = true;
            this.radiobtn_MondayDiscount.CheckedChanged += new System.EventHandler(this.radiobtn_MondayDiscount_CheckedChanged);
            // 
            // radiobtn_MondayKidDiscount
            // 
            this.radiobtn_MondayKidDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radiobtn_MondayKidDiscount.AutoSize = true;
            this.radiobtn_MondayKidDiscount.Location = new System.Drawing.Point(130, 211);
            this.radiobtn_MondayKidDiscount.Name = "radiobtn_MondayKidDiscount";
            this.radiobtn_MondayKidDiscount.Size = new System.Drawing.Size(193, 21);
            this.radiobtn_MondayKidDiscount.TabIndex = 5;
            this.radiobtn_MondayKidDiscount.TabStop = true;
            this.radiobtn_MondayKidDiscount.Text = "Monday discount (For kid)";
            this.radiobtn_MondayKidDiscount.UseVisualStyleBackColor = true;
            this.radiobtn_MondayKidDiscount.CheckedChanged += new System.EventHandler(this.radiobtn_MondayKidDiscount_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Discount type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total cost: ";
            // 
            // label_cost
            // 
            this.label_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(177, 371);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 26);
            this.label_cost.TabIndex = 8;
            // 
            // btn_printbill
            // 
            this.btn_printbill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printbill.Location = new System.Drawing.Point(319, 450);
            this.btn_printbill.Name = "btn_printbill";
            this.btn_printbill.Size = new System.Drawing.Size(165, 57);
            this.btn_printbill.TabIndex = 9;
            this.btn_printbill.Text = "Print to bill";
            this.btn_printbill.UseVisualStyleBackColor = true;
            this.btn_printbill.Click += new System.EventHandler(this.btn_printbill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radiobtn_MondayKidDiscount);
            this.panel1.Controls.Add(this.btn_printbill);
            this.panel1.Controls.Add(this.box_datetime);
            this.panel1.Controls.Add(this.label_cost);
            this.panel1.Controls.Add(this.label_datatime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radiobtn_NoDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radiobtn_MondayDiscount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 517);
            this.panel1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridview_billing);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_billing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_billing;
        private System.Windows.Forms.TextBox box_datetime;
        private System.Windows.Forms.Label label_datatime;
        private System.Windows.Forms.RadioButton radiobtn_NoDiscount;
        private System.Windows.Forms.RadioButton radiobtn_MondayDiscount;
        private System.Windows.Forms.RadioButton radiobtn_MondayKidDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Button btn_printbill;
        private System.Windows.Forms.Panel panel1;
    }
}