namespace Laptop_Emporium
{
    partial class Transaction
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colprocessor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colprocessor,
            this.colRam});
            this.dataGridView1.Location = new System.Drawing.Point(89, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(454, 125);
            this.dataGridView1.TabIndex = 40;
            // 
            // colprocessor
            // 
            this.colprocessor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colprocessor.FillWeight = 114.4385F;
            this.colprocessor.HeaderText = "Processor";
            this.colprocessor.MinimumWidth = 6;
            this.colprocessor.Name = "colprocessor";
            this.colprocessor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colRam
            // 
            this.colRam.FillWeight = 85.5615F;
            this.colRam.HeaderText = "RAM Capacity";
            this.colRam.MinimumWidth = 6;
            this.colRam.Name = "colRam";
            this.colRam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(587, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(431, 201);
            this.dataGridView2.TabIndex = 42;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(359, 241);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(141, 41);
            this.txtBrand.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 41);
            this.txtName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Laptop Model";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.Lime;
            this.btnSaveAll.Location = new System.Drawing.Point(91, 440);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(92, 46);
            this.btnSaveAll.TabIndex = 41;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 41);
            this.label3.TabIndex = 38;
            this.label3.Text = "Besic Information";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Transaction";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn colprocessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Label label3;
    }
}