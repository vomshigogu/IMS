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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFetchData)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridFetchData
            // 
            this.DataGridFetchData.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridFetchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFetchData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridFetchData.Location = new System.Drawing.Point(12, 344);
            this.DataGridFetchData.Name = "DataGridFetchData";
            this.DataGridFetchData.RowHeadersWidth = 51;
            this.DataGridFetchData.RowTemplate.Height = 24;
            this.DataGridFetchData.Size = new System.Drawing.Size(1278, 448);
            this.DataGridFetchData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 804);
            this.Controls.Add(this.DataGridFetchData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFetchData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridFetchData;
    }
}

