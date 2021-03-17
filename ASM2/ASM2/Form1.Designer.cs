
namespace ASM2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DriveThru = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_childform = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_childform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_DriveThru);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_product);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 564);
            this.panel1.TabIndex = 0;
            // 
            // btn_DriveThru
            // 
            this.btn_DriveThru.BackColor = System.Drawing.Color.White;
            this.btn_DriveThru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DriveThru.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DriveThru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DriveThru.Location = new System.Drawing.Point(0, 248);
            this.btn_DriveThru.Name = "btn_DriveThru";
            this.btn_DriveThru.Size = new System.Drawing.Size(231, 50);
            this.btn_DriveThru.TabIndex = 5;
            this.btn_DriveThru.Text = "Outdoor Ordering Machine";
            this.btn_DriveThru.UseVisualStyleBackColor = false;
            this.btn_DriveThru.Click += new System.EventHandler(this.btn_DriveThru_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.White;
            this.btn_billing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_billing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Location = new System.Drawing.Point(0, 198);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(231, 50);
            this.btn_billing.TabIndex = 4;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(0, 512);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(231, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.White;
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Location = new System.Drawing.Point(0, 148);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(231, 50);
            this.btn_product.TabIndex = 1;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::ASM2.Properties.Resources.KFC_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 148);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel_childform
            // 
            this.panel_childform.Controls.Add(this.pictureBox1);
            this.panel_childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childform.Location = new System.Drawing.Point(233, 0);
            this.panel_childform.Name = "panel_childform";
            this.panel_childform.Size = new System.Drawing.Size(854, 564);
            this.panel_childform.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ASM2.Properties.Resources.kfc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(119, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 283);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 564);
            this.Controls.Add(this.panel_childform);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_childform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Panel panel_childform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_DriveThru;
    }
}

