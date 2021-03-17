
namespace ASM2
{
    partial class Form2
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
            this.datagridview_Product = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addChickenWing = new System.Windows.Forms.Button();
            this.btn_addChickenDrum = new System.Windows.Forms.Button();
            this.btn_ChickenNugget = new System.Windows.Forms.Button();
            this.btn_addSoda = new System.Windows.Forms.Button();
            this.btn_addCoke = new System.Windows.Forms.Button();
            this.btn_addPepsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Product)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview_Product
            // 
            this.datagridview_Product.BackgroundColor = System.Drawing.Color.Red;
            this.datagridview_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridview_Product.Location = new System.Drawing.Point(0, 0);
            this.datagridview_Product.MultiSelect = false;
            this.datagridview_Product.Name = "datagridview_Product";
            this.datagridview_Product.ReadOnly = true;
            this.datagridview_Product.RowHeadersWidth = 51;
            this.datagridview_Product.RowTemplate.Height = 24;
            this.datagridview_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_Product.Size = new System.Drawing.Size(284, 451);
            this.datagridview_Product.TabIndex = 1;
            this.datagridview_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_Product_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btn_RemoveItem);
            this.panel1.Controls.Add(this.datagridview_Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 517);
            this.panel1.TabIndex = 8;
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.BackColor = System.Drawing.Color.White;
            this.btn_RemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveItem.Location = new System.Drawing.Point(0, 457);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(284, 60);
            this.btn_RemoveItem.TabIndex = 2;
            this.btn_RemoveItem.Text = "Remove";
            this.btn_RemoveItem.UseVisualStyleBackColor = false;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_addChickenWing);
            this.flowLayoutPanel1.Controls.Add(this.btn_addChickenDrum);
            this.flowLayoutPanel1.Controls.Add(this.btn_ChickenNugget);
            this.flowLayoutPanel1.Controls.Add(this.btn_addSoda);
            this.flowLayoutPanel1.Controls.Add(this.btn_addCoke);
            this.flowLayoutPanel1.Controls.Add(this.btn_addPepsi);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 517);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btn_addChickenWing
            // 
            this.btn_addChickenWing.BackColor = System.Drawing.Color.Red;
            this.btn_addChickenWing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addChickenWing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addChickenWing.ForeColor = System.Drawing.Color.White;
            this.btn_addChickenWing.Location = new System.Drawing.Point(11, 11);
            this.btn_addChickenWing.Margin = new System.Windows.Forms.Padding(1);
            this.btn_addChickenWing.Name = "btn_addChickenWing";
            this.btn_addChickenWing.Size = new System.Drawing.Size(160, 160);
            this.btn_addChickenWing.TabIndex = 2;
            this.btn_addChickenWing.Text = "Chicken Wings";
            this.btn_addChickenWing.UseVisualStyleBackColor = false;
            this.btn_addChickenWing.Click += new System.EventHandler(this.btn_addChickenWing_Click_1);
            // 
            // btn_addChickenDrum
            // 
            this.btn_addChickenDrum.BackColor = System.Drawing.Color.Red;
            this.btn_addChickenDrum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addChickenDrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addChickenDrum.ForeColor = System.Drawing.Color.White;
            this.btn_addChickenDrum.Location = new System.Drawing.Point(173, 11);
            this.btn_addChickenDrum.Margin = new System.Windows.Forms.Padding(1);
            this.btn_addChickenDrum.Name = "btn_addChickenDrum";
            this.btn_addChickenDrum.Size = new System.Drawing.Size(160, 160);
            this.btn_addChickenDrum.TabIndex = 3;
            this.btn_addChickenDrum.Text = "Chicken Drums";
            this.btn_addChickenDrum.UseVisualStyleBackColor = false;
            this.btn_addChickenDrum.Click += new System.EventHandler(this.btn_addChickenDrum_Click);
            // 
            // btn_ChickenNugget
            // 
            this.btn_ChickenNugget.BackColor = System.Drawing.Color.Red;
            this.btn_ChickenNugget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChickenNugget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChickenNugget.ForeColor = System.Drawing.Color.White;
            this.btn_ChickenNugget.Location = new System.Drawing.Point(335, 11);
            this.btn_ChickenNugget.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ChickenNugget.Name = "btn_ChickenNugget";
            this.btn_ChickenNugget.Size = new System.Drawing.Size(160, 160);
            this.btn_ChickenNugget.TabIndex = 4;
            this.btn_ChickenNugget.Text = "Chicken Nuggets";
            this.btn_ChickenNugget.UseVisualStyleBackColor = false;
            this.btn_ChickenNugget.Click += new System.EventHandler(this.btn_ChickenNugget_Click);
            // 
            // btn_addSoda
            // 
            this.btn_addSoda.BackColor = System.Drawing.Color.Red;
            this.btn_addSoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSoda.ForeColor = System.Drawing.Color.White;
            this.btn_addSoda.Location = new System.Drawing.Point(11, 173);
            this.btn_addSoda.Margin = new System.Windows.Forms.Padding(1);
            this.btn_addSoda.Name = "btn_addSoda";
            this.btn_addSoda.Size = new System.Drawing.Size(160, 160);
            this.btn_addSoda.TabIndex = 5;
            this.btn_addSoda.Text = "Soda";
            this.btn_addSoda.UseVisualStyleBackColor = false;
            this.btn_addSoda.Click += new System.EventHandler(this.btn_addSoda_Click);
            // 
            // btn_addCoke
            // 
            this.btn_addCoke.BackColor = System.Drawing.Color.Red;
            this.btn_addCoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCoke.ForeColor = System.Drawing.Color.White;
            this.btn_addCoke.Location = new System.Drawing.Point(173, 173);
            this.btn_addCoke.Margin = new System.Windows.Forms.Padding(1);
            this.btn_addCoke.Name = "btn_addCoke";
            this.btn_addCoke.Size = new System.Drawing.Size(160, 160);
            this.btn_addCoke.TabIndex = 6;
            this.btn_addCoke.Text = "Coke";
            this.btn_addCoke.UseVisualStyleBackColor = false;
            this.btn_addCoke.Click += new System.EventHandler(this.btn_addCoke_Click);
            // 
            // btn_addPepsi
            // 
            this.btn_addPepsi.BackColor = System.Drawing.Color.Red;
            this.btn_addPepsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPepsi.ForeColor = System.Drawing.Color.White;
            this.btn_addPepsi.Location = new System.Drawing.Point(335, 173);
            this.btn_addPepsi.Margin = new System.Windows.Forms.Padding(1);
            this.btn_addPepsi.Name = "btn_addPepsi";
            this.btn_addPepsi.Size = new System.Drawing.Size(160, 160);
            this.btn_addPepsi.TabIndex = 7;
            this.btn_addPepsi.Text = "Pepsi";
            this.btn_addPepsi.UseVisualStyleBackColor = false;
            this.btn_addPepsi.Click += new System.EventHandler(this.btn_addPepsi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 517);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_addChickenWing;
        private System.Windows.Forms.Button btn_addChickenDrum;
        private System.Windows.Forms.Button btn_ChickenNugget;
        private System.Windows.Forms.Button btn_addSoda;
        private System.Windows.Forms.Button btn_addCoke;
        private System.Windows.Forms.Button btn_addPepsi;
        private System.Windows.Forms.Button btn_RemoveItem;
    }
}