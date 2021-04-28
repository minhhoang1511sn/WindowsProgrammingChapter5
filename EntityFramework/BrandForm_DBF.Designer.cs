
namespace EntityFramework
{
    partial class BrandForm_DBF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBrandname = new System.Windows.Forms.TextBox();
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
            this.dtGridView.Location = new System.Drawing.Point(29, 202);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 185);
            this.dtGridView.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(35, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 44);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.grPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.panel2);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Controls.Add(this.txtID);
            this.grPanel.Controls.Add(this.label10);
            this.grPanel.Controls.Add(this.txtBrandname);
            this.grPanel.Location = new System.Drawing.Point(35, 60);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(736, 136);
            this.grPanel.TabIndex = 21;
            this.grPanel.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(103, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(103, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 1);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Brands ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(588, 15);
            this.txtID.TabIndex = 2;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(8, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Brands name:";
            // 
            // txtBrandname
            // 
            this.txtBrandname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBrandname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrandname.Location = new System.Drawing.Point(110, 63);
            this.txtBrandname.Name = "txtBrandname";
            this.txtBrandname.Size = new System.Drawing.Size(588, 15);
            this.txtBrandname.TabIndex = 1;
            this.txtBrandname.Leave += new System.EventHandler(this.txtBrandname_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(390, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 43);
            this.label1.TabIndex = 20;
            this.label1.Text = "UPDATE  BRANDS LIST";
            // 
            // BrandForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "BrandForm_DBF";
            this.Text = "BrandForm_DBF";
            this.Load += new System.EventHandler(this.BrandForm_DBF_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBrandname;
        private System.Windows.Forms.Label label1;
    }
}