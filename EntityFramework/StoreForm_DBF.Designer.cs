
namespace EntityFramework
{
    partial class StoreForm_DBF
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grPanel.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.dtGridView.Location = new System.Drawing.Point(32, 242);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 139);
            this.dtGridView.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btReload);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Location = new System.Drawing.Point(32, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 44);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.AutoSize = true;
            this.btExit.BackColor = System.Drawing.Color.Lime;
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(634, 11);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 27);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Leave += new System.EventHandler(this.btExit_Click);
            // 
            // btReload
            // 
            this.btReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReload.AutoSize = true;
            this.btReload.BackColor = System.Drawing.Color.Lime;
            this.btReload.ForeColor = System.Drawing.SystemColors.Info;
            this.btReload.Location = new System.Drawing.Point(475, 11);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 27);
            this.btReload.TabIndex = 5;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Leave += new System.EventHandler(this.btReload_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.AutoSize = true;
            this.btDelete.BackColor = System.Drawing.Color.Lime;
            this.btDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btDelete.Location = new System.Drawing.Point(317, 11);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 27);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Leave += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.AutoSize = true;
            this.btSave.BackColor = System.Drawing.Color.Lime;
            this.btSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btSave.Location = new System.Drawing.Point(142, 11);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 27);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Leave += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.AutoSize = true;
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btAdd.Location = new System.Drawing.Point(11, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 27);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Leave += new System.EventHandler(this.btAdd_Click);
            // 
            // grPanel
            // 
            this.grPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grPanel.Controls.Add(this.panel9);
            this.grPanel.Controls.Add(this.panel8);
            this.grPanel.Controls.Add(this.panel7);
            this.grPanel.Controls.Add(this.panel6);
            this.grPanel.Controls.Add(this.panel5);
            this.grPanel.Controls.Add(this.panel3);
            this.grPanel.Controls.Add(this.panel2);
            this.grPanel.Controls.Add(this.panel1);
            this.grPanel.Controls.Add(this.txtZipcode);
            this.grPanel.Controls.Add(this.label9);
            this.grPanel.Controls.Add(this.txtState);
            this.grPanel.Controls.Add(this.label8);
            this.grPanel.Controls.Add(this.txtCity);
            this.grPanel.Controls.Add(this.label7);
            this.grPanel.Controls.Add(this.txtStreet);
            this.grPanel.Controls.Add(this.label6);
            this.grPanel.Controls.Add(this.txtEmail);
            this.grPanel.Controls.Add(this.label5);
            this.grPanel.Controls.Add(this.txtPhone);
            this.grPanel.Controls.Add(this.label4);
            this.grPanel.Controls.Add(this.txtSName);
            this.grPanel.Controls.Add(this.label3);
            this.grPanel.Controls.Add(this.txtSID);
            this.grPanel.Controls.Add(this.label2);
            this.grPanel.Location = new System.Drawing.Point(32, 66);
            this.grPanel.Name = "grPanel";
            this.grPanel.Size = new System.Drawing.Size(736, 170);
            this.grPanel.TabIndex = 9;
            this.grPanel.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel9.ForeColor = System.Drawing.SystemColors.Info;
            this.panel9.Location = new System.Drawing.Point(584, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(134, 1);
            this.panel9.TabIndex = 45;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel8.ForeColor = System.Drawing.SystemColors.Info;
            this.panel8.Location = new System.Drawing.Point(335, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 1);
            this.panel8.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel7.ForeColor = System.Drawing.SystemColors.Info;
            this.panel7.Location = new System.Drawing.Point(87, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 1);
            this.panel7.TabIndex = 43;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.ForeColor = System.Drawing.SystemColors.Info;
            this.panel6.Location = new System.Drawing.Point(87, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(631, 1);
            this.panel6.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.ForeColor = System.Drawing.SystemColors.Info;
            this.panel5.Location = new System.Drawing.Point(374, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 1);
            this.panel5.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.Info;
            this.panel3.Location = new System.Drawing.Point(87, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 1);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.ForeColor = System.Drawing.SystemColors.Info;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 1);
            this.panel4.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.ForeColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(99, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 1);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(87, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 1);
            this.panel1.TabIndex = 38;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(584, 143);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(134, 15);
            this.txtZipcode.TabIndex = 15;
            this.txtZipcode.Leave += new System.EventHandler(this.txtZipcode_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(505, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Zip code:";
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(338, 142);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(164, 15);
            this.txtState.TabIndex = 13;
            this.txtState.Leave += new System.EventHandler(this.txtState_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(233, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "State/Province:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(87, 142);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(140, 15);
            this.txtCity.TabIndex = 11;
            this.txtCity.LocationChanged += new System.EventHandler(this.txtCity_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(17, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Location = new System.Drawing.Point(87, 113);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(631, 15);
            this.txtStreet.TabIndex = 9;
            this.txtStreet.Leave += new System.EventHandler(this.txtStreet_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(17, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Street:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(374, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 15);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(304, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "e-mail:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(87, 84);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 15);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone:";
            // 
            // txtSName
            // 
            this.txtSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSName.Location = new System.Drawing.Point(102, 54);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(610, 15);
            this.txtSName.TabIndex = 3;
            this.txtSName.Leave += new System.EventHandler(this.txtSName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Store name:";
            // 
            // txtSID
            // 
            this.txtSID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSID.Location = new System.Drawing.Point(90, 29);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(198, 15);
            this.txtSID.TabIndex = 1;
            this.txtSID.Leave += new System.EventHandler(this.txtSID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store ID:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(419, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "UPDATE  STORE LIST";
            // 
            // StoreForm_DBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grPanel);
            this.Controls.Add(this.label1);
            this.Name = "StoreForm_DBF";
            this.Text = "StoreForm_DBF";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grPanel.ResumeLayout(false);
            this.grPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}