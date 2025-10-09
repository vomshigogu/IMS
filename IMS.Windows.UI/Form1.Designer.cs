namespace IMS.Windows.UI
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
            this.DataGridFetchData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddCode = new System.Windows.Forms.TextBox();
            this.txtAddCreatedBy = new System.Windows.Forms.TextBox();
            this.txtAddCreatedOn = new System.Windows.Forms.TextBox();
            this.txtAddModifiedBy = new System.Windows.Forms.TextBox();
            this.txtAddModifieddOn = new System.Windows.Forms.TextBox();
            this.txtAddIsActive = new System.Windows.Forms.TextBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.txtIsActive = new System.Windows.Forms.TextBox();
            this.txtUpdateModifiedOn = new System.Windows.Forms.TextBox();
            this.txtUpdateModifedBy = new System.Windows.Forms.TextBox();
            this.txtUpdateCreatedOn = new System.Windows.Forms.TextBox();
            this.txtUpdateCreatedBy = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDeleteRoleById = new System.Windows.Forms.TextBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFetchData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridFetchData
            // 
            this.DataGridFetchData.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridFetchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFetchData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridFetchData.Location = new System.Drawing.Point(12, 385);
            this.DataGridFetchData.Name = "DataGridFetchData";
            this.DataGridFetchData.RowHeadersWidth = 51;
            this.DataGridFetchData.RowTemplate.Height = 24;
            this.DataGridFetchData.Size = new System.Drawing.Size(1478, 407);
            this.DataGridFetchData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnAddRole);
            this.panel1.Controls.Add(this.txtAddIsActive);
            this.panel1.Controls.Add(this.txtAddModifieddOn);
            this.panel1.Controls.Add(this.txtAddModifiedBy);
            this.panel1.Controls.Add(this.txtAddCreatedOn);
            this.panel1.Controls.Add(this.txtAddCreatedBy);
            this.panel1.Controls.Add(this.txtAddCode);
            this.panel1.Controls.Add(this.txtAddName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 375);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "CreatedBy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ModifiedBy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "CreatedOn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "ModifiedOn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "IsActive";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(209, 77);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(228, 22);
            this.txtAddName.TabIndex = 9;
            // 
            // txtAddCode
            // 
            this.txtAddCode.Location = new System.Drawing.Point(209, 114);
            this.txtAddCode.Name = "txtAddCode";
            this.txtAddCode.Size = new System.Drawing.Size(228, 22);
            this.txtAddCode.TabIndex = 10;
            // 
            // txtAddCreatedBy
            // 
            this.txtAddCreatedBy.Location = new System.Drawing.Point(209, 156);
            this.txtAddCreatedBy.Name = "txtAddCreatedBy";
            this.txtAddCreatedBy.Size = new System.Drawing.Size(228, 22);
            this.txtAddCreatedBy.TabIndex = 11;
            // 
            // txtAddCreatedOn
            // 
            this.txtAddCreatedOn.Location = new System.Drawing.Point(209, 205);
            this.txtAddCreatedOn.Name = "txtAddCreatedOn";
            this.txtAddCreatedOn.Size = new System.Drawing.Size(228, 22);
            this.txtAddCreatedOn.TabIndex = 12;
            // 
            // txtAddModifiedBy
            // 
            this.txtAddModifiedBy.Location = new System.Drawing.Point(209, 247);
            this.txtAddModifiedBy.Name = "txtAddModifiedBy";
            this.txtAddModifiedBy.Size = new System.Drawing.Size(228, 22);
            this.txtAddModifiedBy.TabIndex = 13;
            // 
            // txtAddModifieddOn
            // 
            this.txtAddModifieddOn.Location = new System.Drawing.Point(209, 289);
            this.txtAddModifieddOn.Name = "txtAddModifieddOn";
            this.txtAddModifieddOn.Size = new System.Drawing.Size(228, 22);
            this.txtAddModifieddOn.TabIndex = 14;
            // 
            // txtAddIsActive
            // 
            this.txtAddIsActive.Location = new System.Drawing.Point(209, 329);
            this.txtAddIsActive.Name = "txtAddIsActive";
            this.txtAddIsActive.Size = new System.Drawing.Size(228, 22);
            this.txtAddIsActive.TabIndex = 15;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddRole.Location = new System.Drawing.Point(175, 8);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(105, 34);
            this.btnAddRole.TabIndex = 16;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.btnUpdateRole);
            this.panel2.Controls.Add(this.txtIsActive);
            this.panel2.Controls.Add(this.txtUpdateModifiedOn);
            this.panel2.Controls.Add(this.txtUpdateModifedBy);
            this.panel2.Controls.Add(this.txtUpdateCreatedOn);
            this.panel2.Controls.Add(this.txtUpdateCreatedBy);
            this.panel2.Controls.Add(this.txtUpdateName);
            this.panel2.Controls.Add(this.txtUpdateId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(520, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 375);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateRole.Location = new System.Drawing.Point(175, 8);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(105, 34);
            this.btnUpdateRole.TabIndex = 16;
            this.btnUpdateRole.Text = "Update Role";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIsActive
            // 
            this.txtIsActive.Location = new System.Drawing.Point(209, 329);
            this.txtIsActive.Name = "txtIsActive";
            this.txtIsActive.Size = new System.Drawing.Size(228, 22);
            this.txtIsActive.TabIndex = 15;
            // 
            // txtUpdateModifiedOn
            // 
            this.txtUpdateModifiedOn.Location = new System.Drawing.Point(209, 289);
            this.txtUpdateModifiedOn.Name = "txtUpdateModifiedOn";
            this.txtUpdateModifiedOn.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateModifiedOn.TabIndex = 14;
            // 
            // txtUpdateModifedBy
            // 
            this.txtUpdateModifedBy.Location = new System.Drawing.Point(209, 247);
            this.txtUpdateModifedBy.Name = "txtUpdateModifedBy";
            this.txtUpdateModifedBy.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateModifedBy.TabIndex = 13;
            // 
            // txtUpdateCreatedOn
            // 
            this.txtUpdateCreatedOn.Location = new System.Drawing.Point(209, 205);
            this.txtUpdateCreatedOn.Name = "txtUpdateCreatedOn";
            this.txtUpdateCreatedOn.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateCreatedOn.TabIndex = 12;
            // 
            // txtUpdateCreatedBy
            // 
            this.txtUpdateCreatedBy.Location = new System.Drawing.Point(209, 156);
            this.txtUpdateCreatedBy.Name = "txtUpdateCreatedBy";
            this.txtUpdateCreatedBy.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateCreatedBy.TabIndex = 11;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(209, 114);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateName.TabIndex = 10;
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(209, 77);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(228, 22);
            this.txtUpdateId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ModifiedBy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "CreatedOn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "ModifiedOn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "IsActive";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(23, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "CreatedBy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(23, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Id";
            // 
            // txtDeleteRoleById
            // 
            this.txtDeleteRoleById.Location = new System.Drawing.Point(209, 77);
            this.txtDeleteRoleById.Name = "txtDeleteRoleById";
            this.txtDeleteRoleById.Size = new System.Drawing.Size(228, 22);
            this.txtDeleteRoleById.TabIndex = 9;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteRole.Location = new System.Drawing.Point(175, 8);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(105, 34);
            this.btnDeleteRole.TabIndex = 16;
            this.btnDeleteRole.Text = "Delete Role";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btnDeleteRole);
            this.panel3.Controls.Add(this.txtDeleteRoleById);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(1015, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 185);
            this.panel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 804);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridFetchData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFetchData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridFetchData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TextBox txtAddIsActive;
        private System.Windows.Forms.TextBox txtAddModifieddOn;
        private System.Windows.Forms.TextBox txtAddModifiedBy;
        private System.Windows.Forms.TextBox txtAddCreatedOn;
        private System.Windows.Forms.TextBox txtAddCreatedBy;
        private System.Windows.Forms.TextBox txtAddCode;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.TextBox txtIsActive;
        private System.Windows.Forms.TextBox txtUpdateModifiedOn;
        private System.Windows.Forms.TextBox txtUpdateModifedBy;
        private System.Windows.Forms.TextBox txtUpdateCreatedOn;
        private System.Windows.Forms.TextBox txtUpdateCreatedBy;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDeleteRoleById;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Panel panel3;
    }
}

