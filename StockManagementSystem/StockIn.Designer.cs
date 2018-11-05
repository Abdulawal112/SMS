namespace StockManagementSystem
{
    partial class StockIn
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reorderLabelAlert = new System.Windows.Forms.Label();
            this.StockIntextBox = new System.Windows.Forms.TextBox();
            this.StockInAvaiableQtyTextBox = new System.Windows.Forms.TextBox();
            this.StockInSaveButton = new System.Windows.Forms.Button();
            this.StockInReordertextBox = new System.Windows.Forms.TextBox();
            this.StockInItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockInCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockInCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.reorderLabelAlert);
            this.groupBox1.Controls.Add(this.StockIntextBox);
            this.groupBox1.Controls.Add(this.StockInAvaiableQtyTextBox);
            this.groupBox1.Controls.Add(this.StockInSaveButton);
            this.groupBox1.Controls.Add(this.StockInReordertextBox);
            this.groupBox1.Controls.Add(this.StockInItemComboBox);
            this.groupBox1.Controls.Add(this.StockInCategoryComboBox);
            this.groupBox1.Controls.Add(this.StockInCompanyComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock IN";
            // 
            // reorderLabelAlert
            // 
            this.reorderLabelAlert.AutoSize = true;
            this.reorderLabelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLabelAlert.ForeColor = System.Drawing.Color.Red;
            this.reorderLabelAlert.Location = new System.Drawing.Point(448, 161);
            this.reorderLabelAlert.Name = "reorderLabelAlert";
            this.reorderLabelAlert.Size = new System.Drawing.Size(0, 15);
            this.reorderLabelAlert.TabIndex = 15;
            // 
            // StockIntextBox
            // 
            this.StockIntextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockIntextBox.Location = new System.Drawing.Point(176, 237);
            this.StockIntextBox.Name = "StockIntextBox";
            this.StockIntextBox.Size = new System.Drawing.Size(251, 23);
            this.StockIntextBox.TabIndex = 14;
            // 
            // StockInAvaiableQtyTextBox
            // 
            this.StockInAvaiableQtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInAvaiableQtyTextBox.Location = new System.Drawing.Point(179, 197);
            this.StockInAvaiableQtyTextBox.Name = "StockInAvaiableQtyTextBox";
            this.StockInAvaiableQtyTextBox.Size = new System.Drawing.Size(251, 23);
            this.StockInAvaiableQtyTextBox.TabIndex = 13;
            this.StockInAvaiableQtyTextBox.Text = "0";
            // 
            // StockInSaveButton
            // 
            this.StockInSaveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInSaveButton.Location = new System.Drawing.Point(355, 290);
            this.StockInSaveButton.Name = "StockInSaveButton";
            this.StockInSaveButton.Size = new System.Drawing.Size(75, 29);
            this.StockInSaveButton.TabIndex = 12;
            this.StockInSaveButton.Text = "Save";
            this.StockInSaveButton.UseVisualStyleBackColor = true;
            this.StockInSaveButton.Click += new System.EventHandler(this.StockInSaveButton_Click);
            // 
            // StockInReordertextBox
            // 
            this.StockInReordertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInReordertextBox.Location = new System.Drawing.Point(179, 158);
            this.StockInReordertextBox.Name = "StockInReordertextBox";
            this.StockInReordertextBox.Size = new System.Drawing.Size(251, 23);
            this.StockInReordertextBox.TabIndex = 9;
            // 
            // StockInItemComboBox
            // 
            this.StockInItemComboBox.DataSource = this.itemBindingSource;
            this.StockInItemComboBox.DisplayMember = "Name";
            this.StockInItemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInItemComboBox.FormattingEnabled = true;
            this.StockInItemComboBox.Location = new System.Drawing.Point(179, 112);
            this.StockInItemComboBox.Name = "StockInItemComboBox";
            this.StockInItemComboBox.Size = new System.Drawing.Size(251, 24);
            this.StockInItemComboBox.TabIndex = 8;
            this.StockInItemComboBox.ValueMember = "Id";
            this.StockInItemComboBox.SelectedIndexChanged += new System.EventHandler(this.StockInItemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystem.Module.Item);
            // 
            // StockInCategoryComboBox
            // 
            this.StockInCategoryComboBox.DataSource = this.categoryBindingSource;
            this.StockInCategoryComboBox.DisplayMember = "Name";
            this.StockInCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInCategoryComboBox.FormattingEnabled = true;
            this.StockInCategoryComboBox.Location = new System.Drawing.Point(179, 65);
            this.StockInCategoryComboBox.Name = "StockInCategoryComboBox";
            this.StockInCategoryComboBox.Size = new System.Drawing.Size(251, 24);
            this.StockInCategoryComboBox.TabIndex = 7;
            this.StockInCategoryComboBox.ValueMember = "Id";
            this.StockInCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.StockInCategoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystem.Module.Category);
            // 
            // StockInCompanyComboBox
            // 
            this.StockInCompanyComboBox.DataSource = this.companyBindingSource;
            this.StockInCompanyComboBox.DisplayMember = "Name";
            this.StockInCompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInCompanyComboBox.FormattingEnabled = true;
            this.StockInCompanyComboBox.Location = new System.Drawing.Point(179, 28);
            this.StockInCompanyComboBox.Name = "StockInCompanyComboBox";
            this.StockInCompanyComboBox.Size = new System.Drawing.Size(251, 24);
            this.StockInCompanyComboBox.TabIndex = 6;
            this.StockInCompanyComboBox.ValueMember = "Id";
            this.StockInCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.StockInCompanyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystem.Module.Company);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock In Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Level :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company :";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockIn";
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StockIntextBox;
        private System.Windows.Forms.TextBox StockInAvaiableQtyTextBox;
        private System.Windows.Forms.Button StockInSaveButton;
        private System.Windows.Forms.TextBox StockInReordertextBox;
        private System.Windows.Forms.ComboBox StockInItemComboBox;
        private System.Windows.Forms.ComboBox StockInCategoryComboBox;
        private System.Windows.Forms.ComboBox StockInCompanyComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label reorderLabelAlert;

    }
}