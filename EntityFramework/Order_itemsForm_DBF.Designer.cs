
namespace EntityFramework
{
    partial class Order_itemsForm_DBF
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.cbOrdersID = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtitemID = new System.Windows.Forms.TextBox();
            this.textListprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(31, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 44);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Green;
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(634, 15);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.Green;
            this.btReload.ForeColor = System.Drawing.SystemColors.Info;
            this.btReload.Location = new System.Drawing.Point(464, 15);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 23);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Green;
            this.btDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btDelete.Location = new System.Drawing.Point(310, 15);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Green;
            this.btSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btSave.Location = new System.Drawing.Point(158, 15);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Green;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btAdd.Location = new System.Drawing.Point(11, 15);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.BackgroundColor = System.Drawing.Color.Green;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(34, 205);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 184);
            this.dtGridView.TabIndex = 27;
            // 
            // grPanel
            // 
            this.grPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grPanel.Controls.Add(this.cbProductID);
            this.grPanel.Controls.Add(this.cbOrdersID);
            this.grPanel.Controls.Add(this.panel6);
            this.grPanel.Controls.Add(this.panel5);
            this.grPanel.Controls.Add(this.panel4);
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.txtitemID);
            this.grPanel.Controls.Add(this.textListprice);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.txtdiscount);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.txtQuanity);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Location = new System.Drawing.Point(34, 62);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(736, 137);
            this.grPanel.TabIndex = 26;
            this.grPanel.TabStop = false;
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(109, 98);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(201, 24);
            this.cbProductID.TabIndex = 38;
            this.cbProductID.Leave += new System.EventHandler(this.cbProductID_Leave);
            // 
            // cbOrdersID
            // 
            this.cbOrdersID.FormattingEnabled = true;
            this.cbOrdersID.Location = new System.Drawing.Point(109, 66);
            this.cbOrdersID.Name = "cbOrdersID";
            this.cbOrdersID.Size = new System.Drawing.Size(201, 24);
            this.cbOrdersID.TabIndex = 37;
            this.cbOrdersID.Leave += new System.EventHandler(this.cbOrdersID_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.Location = new System.Drawing.Point(486, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 1);
            this.panel6.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(483, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 1);
            this.panel5.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(483, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 1);
            this.panel4.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(109, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1);
            this.panel1.TabIndex = 32;
            // 
            // txtitemID
            // 
            this.txtitemID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtitemID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtitemID.Location = new System.Drawing.Point(109, 35);
            this.txtitemID.Name = "txtitemID";
            this.txtitemID.Size = new System.Drawing.Size(198, 15);
            this.txtitemID.TabIndex = 0;
            this.txtitemID.Leave += new System.EventHandler(this.txtitemID_Leave);
            // 
            // textListprice
            // 
            this.textListprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textListprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textListprice.ForeColor = System.Drawing.SystemColors.Info;
            this.textListprice.Location = new System.Drawing.Point(483, 73);
            this.textListprice.Name = "textListprice";
            this.textListprice.Size = new System.Drawing.Size(198, 15);
            this.textListprice.TabIndex = 4;
            this.textListprice.Leave += new System.EventHandler(this.textListprice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(385, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "List price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Products ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Orders ID:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiscount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtdiscount.Location = new System.Drawing.Point(489, 98);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(198, 15);
            this.txtdiscount.TabIndex = 5;
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(385, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Discount:";
            // 
            // txtQuanity
            // 
            this.txtQuanity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtQuanity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuanity.ForeColor = System.Drawing.SystemColors.Info;
            this.txtQuanity.Location = new System.Drawing.Point(486, 36);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(198, 15);
            this.txtQuanity.TabIndex = 3;
            this.txtQuanity.Leave += new System.EventHandler(this.txtQuanity_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(385, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quanity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(318, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "UPDATE  ODERS_ITEM LIST";
            // 
            // Order_itemsForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "Order_itemsForm_DBF";
            this.Text = "Order_itemsForm_DBF";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.ComboBox cbOrdersID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtitemID;
        private System.Windows.Forms.TextBox textListprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}