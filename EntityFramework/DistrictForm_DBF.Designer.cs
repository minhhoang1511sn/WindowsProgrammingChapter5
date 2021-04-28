
namespace EntityFramework
{
    partial class DistrictForm_DBF 
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grPanel = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.cbProv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 84);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cbProv
            // 
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(120, 22);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(219, 24);
            this.cbProv.TabIndex = 17;
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "First name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(17, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Province:";
            // 
            // dtGridView
            // 
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(23, 150);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(344, 287);
            this.dtGridView.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(395, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 163);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(249, 118);
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
            this.btReload.Location = new System.Drawing.Point(82, 118);
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
            this.btDelete.Location = new System.Drawing.Point(294, 32);
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
            this.btSave.Location = new System.Drawing.Point(162, 32);
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
            this.btAdd.Location = new System.Drawing.Point(42, 32);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grPanel
            // 
            this.grPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.grPanel.Controls.Add(this.panel3);
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.panel2);
            this.grPanel.Controls.Add(this.label10);
            this.grPanel.Controls.Add(this.txtPID);
            this.grPanel.Controls.Add(this.txtDName);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.txtDID);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(395, 59);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(384, 208);
            this.grPanel.TabIndex = 25;
            this.grPanel.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(129, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 1);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(129, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(114, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(17, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "District name:";
            // 
            // txtPID
            // 
            this.txtPID.BackColor = System.Drawing.Color.DarkGreen;
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPID.Location = new System.Drawing.Point(129, 163);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(235, 15);
            this.txtPID.TabIndex = 5;
            this.txtPID.Leave += new System.EventHandler(this.txtPID_Leave);
            // 
            // txtDName
            // 
            this.txtDName.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDName.Location = new System.Drawing.Point(132, 91);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(237, 15);
            this.txtDName.TabIndex = 3;
            this.txtDName.Leave += new System.EventHandler(this.txtDName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(17, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Province ID:";
            // 
            // txtDID
            // 
            this.txtDID.BackColor = System.Drawing.Color.DarkGreen;
            this.txtDID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDID.Location = new System.Drawing.Point(114, 22);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(247, 15);
            this.txtDID.TabIndex = 1;
            this.txtDID.Leave += new System.EventHandler(this.txtDID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "District ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(312, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 43);
            this.label1.TabIndex = 24;
            this.label1.Text = "UPDATE  DISTRICT LIST";
            // 
            // DistrictForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "DistrictForm_DBF";
            this.Text = "DistrictForm_DBF";
            this.Load += new System.EventHandler(this.DistrictForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}