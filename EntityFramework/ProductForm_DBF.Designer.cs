
namespace EntityFramework
{
    partial class ProductForm_DBF
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
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCateID = new System.Windows.Forms.ComboBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.cbBrandID = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtlistprice = new System.Windows.Forms.TextBox();
            this.txtModelyears = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.BackgroundColor = System.Drawing.Color.Green;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(32, 201);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 188);
            this.dtGridView.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(32, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 44);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Lime;
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
            this.btReload.BackColor = System.Drawing.Color.Lime;
            this.btReload.ForeColor = System.Drawing.SystemColors.Info;
            this.btReload.Location = new System.Drawing.Point(476, 15);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 23);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Lime;
            this.btDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btDelete.Location = new System.Drawing.Point(314, 15);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lime;
            this.btSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btSave.Location = new System.Drawing.Point(156, 15);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btAdd.Location = new System.Drawing.Point(11, 15);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grPanel
            // 
            this.grPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Controls.Add(this.cbCateID);
            this.grPanel.Controls.Add(this.txtProID);
            this.grPanel.Controls.Add(this.cbBrandID);
            this.grPanel.Controls.Add(this.panel5);
            this.grPanel.Controls.Add(this.panel4);
            this.grPanel.Controls.Add(this.panel3);
            this.grPanel.Controls.Add(this.label10);
            this.grPanel.Controls.Add(this.txtlistprice);
            this.grPanel.Controls.Add(this.txtModelyears);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.txtProductname);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Location = new System.Drawing.Point(32, 62);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(736, 133);
            this.grPanel.TabIndex = 21;
            this.grPanel.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(125, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1);
            this.panel1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Products ID:";
            // 
            // cbCateID
            // 
            this.cbCateID.FormattingEnabled = true;
            this.cbCateID.Location = new System.Drawing.Point(114, 81);
            this.cbCateID.Name = "cbCateID";
            this.cbCateID.Size = new System.Drawing.Size(253, 24);
            this.cbCateID.TabIndex = 42;
            this.cbCateID.Leave += new System.EventHandler(this.cbCateID_Leave);
            // 
            // txtProID
            // 
            this.txtProID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtProID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(126, 26);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(190, 15);
            this.txtProID.TabIndex = 39;
            this.txtProID.Leave += new System.EventHandler(this.txtProID_Leave);
            // 
            // cbBrandID
            // 
            this.cbBrandID.FormattingEnabled = true;
            this.cbBrandID.Location = new System.Drawing.Point(96, 49);
            this.cbBrandID.Name = "cbBrandID";
            this.cbBrandID.Size = new System.Drawing.Size(271, 24);
            this.cbBrandID.TabIndex = 41;
            this.cbBrandID.Leave += new System.EventHandler(this.cbBrandID_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.ForeColor = System.Drawing.SystemColors.Info;
            this.panel5.Location = new System.Drawing.Point(508, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 1);
            this.panel5.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.ForeColor = System.Drawing.SystemColors.Info;
            this.panel4.Location = new System.Drawing.Point(508, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 1);
            this.panel4.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.ForeColor = System.Drawing.SystemColors.Info;
            this.panel3.Location = new System.Drawing.Point(506, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 1);
            this.panel3.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(394, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Products name:";
            // 
            // txtlistprice
            // 
            this.txtlistprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtlistprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlistprice.Location = new System.Drawing.Point(511, 98);
            this.txtlistprice.Name = "txtlistprice";
            this.txtlistprice.Size = new System.Drawing.Size(190, 15);
            this.txtlistprice.TabIndex = 4;
            this.txtlistprice.Leave += new System.EventHandler(this.txtlistpricee_Leave);
            // 
            // txtModelyears
            // 
            this.txtModelyears.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtModelyears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelyears.Location = new System.Drawing.Point(508, 65);
            this.txtModelyears.Name = "txtModelyears";
            this.txtModelyears.Size = new System.Drawing.Size(190, 15);
            this.txtModelyears.TabIndex = 3;
            this.txtModelyears.Leave += new System.EventHandler(this.txtModelyears_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(394, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "List price:";
            // 
            // txtProductname
            // 
            this.txtProductname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtProductname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductname.Location = new System.Drawing.Point(507, 33);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(190, 15);
            this.txtProductname.TabIndex = 2;
            this.txtProductname.Leave += new System.EventHandler(this.txtProductname_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(394, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Model years:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Catagories ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Brand ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(316, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "UPDATE  PRODUCTS LIST";
            // 
            // ProductForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm_DBF";
            this.Text = "ProductForm_DBF";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCateID;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.ComboBox cbBrandID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtlistprice;
        private System.Windows.Forms.TextBox txtModelyears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}