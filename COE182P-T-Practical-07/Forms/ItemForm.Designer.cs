namespace COE182P_T_Practical_07
{
    partial class ItemForm
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
            this.labelFoodID = new System.Windows.Forms.Label();
            this.comboBoxFoodID = new System.Windows.Forms.ComboBox();
            this.comboBoxStallName = new System.Windows.Forms.ComboBox();
            this.labelStallName = new System.Windows.Forms.Label();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelFoodType = new System.Windows.Forms.Label();
            this.labelFoodDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.labelStallID = new System.Windows.Forms.Label();
            this.comboBoxFoodType = new System.Windows.Forms.ComboBox();
            this.labelFoodTypeID = new System.Windows.Forms.Label();
            this.textBoxFoodDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonItem = new System.Windows.Forms.Button();
            this.textBoxFoodTypeID = new System.Windows.Forms.TextBox();
            this.textBoxStallID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFoodID
            // 
            this.labelFoodID.AutoSize = true;
            this.labelFoodID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFoodID.Location = new System.Drawing.Point(86, 20);
            this.labelFoodID.Name = "labelFoodID";
            this.labelFoodID.Size = new System.Drawing.Size(78, 23);
            this.labelFoodID.TabIndex = 0;
            this.labelFoodID.Text = "Food ID:";
            // 
            // comboBoxFoodID
            // 
            this.comboBoxFoodID.Enabled = false;
            this.comboBoxFoodID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFoodID.FormattingEnabled = true;
            this.comboBoxFoodID.Location = new System.Drawing.Point(170, 12);
            this.comboBoxFoodID.Name = "comboBoxFoodID";
            this.comboBoxFoodID.Size = new System.Drawing.Size(300, 31);
            this.comboBoxFoodID.TabIndex = 1;
            this.comboBoxFoodID.SelectedIndexChanged += new System.EventHandler(this.comboBoxFoodID_SelectedIndexChanged);
            // 
            // comboBoxStallName
            // 
            this.comboBoxStallName.Enabled = false;
            this.comboBoxStallName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStallName.FormattingEnabled = true;
            this.comboBoxStallName.Location = new System.Drawing.Point(170, 64);
            this.comboBoxStallName.Name = "comboBoxStallName";
            this.comboBoxStallName.Size = new System.Drawing.Size(300, 31);
            this.comboBoxStallName.TabIndex = 1;
            this.comboBoxStallName.SelectedIndexChanged += new System.EventHandler(this.comboBoxStallName_SelectedIndexChanged);
            // 
            // labelStallName
            // 
            this.labelStallName.AutoSize = true;
            this.labelStallName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStallName.Location = new System.Drawing.Point(61, 72);
            this.labelStallName.Name = "labelStallName";
            this.labelStallName.Size = new System.Drawing.Size(103, 23);
            this.labelStallName.TabIndex = 0;
            this.labelStallName.Text = "Stall Name:";
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFoodName.Location = new System.Drawing.Point(57, 123);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(107, 23);
            this.labelFoodName.TabIndex = 0;
            this.labelFoodName.Text = "Food Name:";
            // 
            // labelFoodType
            // 
            this.labelFoodType.AutoSize = true;
            this.labelFoodType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFoodType.Location = new System.Drawing.Point(66, 175);
            this.labelFoodType.Name = "labelFoodType";
            this.labelFoodType.Size = new System.Drawing.Size(98, 23);
            this.labelFoodType.TabIndex = 0;
            this.labelFoodType.Text = "Food Type:";
            // 
            // labelFoodDescription
            // 
            this.labelFoodDescription.AutoSize = true;
            this.labelFoodDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFoodDescription.Location = new System.Drawing.Point(12, 271);
            this.labelFoodDescription.Name = "labelFoodDescription";
            this.labelFoodDescription.Size = new System.Drawing.Size(152, 23);
            this.labelFoodDescription.TabIndex = 0;
            this.labelFoodDescription.Text = "Food Description:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(110, 322);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 23);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Enabled = false;
            this.textBoxFoodName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFoodName.Location = new System.Drawing.Point(170, 116);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(300, 30);
            this.textBoxFoodName.TabIndex = 2;
            // 
            // labelStallID
            // 
            this.labelStallID.AutoSize = true;
            this.labelStallID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStallID.Location = new System.Drawing.Point(476, 72);
            this.labelStallID.Name = "labelStallID";
            this.labelStallID.Size = new System.Drawing.Size(62, 23);
            this.labelStallID.TabIndex = 0;
            this.labelStallID.Text = "StallID:";
            // 
            // comboBoxFoodType
            // 
            this.comboBoxFoodType.Enabled = false;
            this.comboBoxFoodType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFoodType.FormattingEnabled = true;
            this.comboBoxFoodType.Location = new System.Drawing.Point(170, 167);
            this.comboBoxFoodType.Name = "comboBoxFoodType";
            this.comboBoxFoodType.Size = new System.Drawing.Size(300, 31);
            this.comboBoxFoodType.TabIndex = 1;
            this.comboBoxFoodType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFoodType_SelectedIndexChanged);
            // 
            // labelFoodTypeID
            // 
            this.labelFoodTypeID.AutoSize = true;
            this.labelFoodTypeID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFoodTypeID.Location = new System.Drawing.Point(476, 175);
            this.labelFoodTypeID.Name = "labelFoodTypeID";
            this.labelFoodTypeID.Size = new System.Drawing.Size(104, 23);
            this.labelFoodTypeID.TabIndex = 0;
            this.labelFoodTypeID.Text = "FoodTypeID:";
            // 
            // textBoxFoodDescription
            // 
            this.textBoxFoodDescription.Enabled = false;
            this.textBoxFoodDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFoodDescription.Location = new System.Drawing.Point(170, 219);
            this.textBoxFoodDescription.Multiline = true;
            this.textBoxFoodDescription.Name = "textBoxFoodDescription";
            this.textBoxFoodDescription.Size = new System.Drawing.Size(300, 75);
            this.textBoxFoodDescription.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(170, 315);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(300, 30);
            this.textBoxPrice.TabIndex = 2;
            // 
            // buttonItem
            // 
            this.buttonItem.BackColor = System.Drawing.Color.Lime;
            this.buttonItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonItem.Location = new System.Drawing.Point(214, 363);
            this.buttonItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Size = new System.Drawing.Size(200, 70);
            this.buttonItem.TabIndex = 0;
            this.buttonItem.Text = "ITEM";
            this.buttonItem.UseVisualStyleBackColor = false;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // textBoxFoodTypeID
            // 
            this.textBoxFoodTypeID.Enabled = false;
            this.textBoxFoodTypeID.Location = new System.Drawing.Point(586, 171);
            this.textBoxFoodTypeID.Name = "textBoxFoodTypeID";
            this.textBoxFoodTypeID.Size = new System.Drawing.Size(40, 27);
            this.textBoxFoodTypeID.TabIndex = 3;
            // 
            // textBoxStallID
            // 
            this.textBoxStallID.Enabled = false;
            this.textBoxStallID.Location = new System.Drawing.Point(540, 68);
            this.textBoxStallID.Name = "textBoxStallID";
            this.textBoxStallID.Size = new System.Drawing.Size(40, 27);
            this.textBoxStallID.TabIndex = 3;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.textBoxStallID);
            this.Controls.Add(this.textBoxFoodTypeID);
            this.Controls.Add(this.buttonItem);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFoodDescription);
            this.Controls.Add(this.labelFoodTypeID);
            this.Controls.Add(this.comboBoxFoodType);
            this.Controls.Add(this.labelStallID);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFoodDescription);
            this.Controls.Add(this.labelFoodType);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.labelStallName);
            this.Controls.Add(this.comboBoxStallName);
            this.Controls.Add(this.comboBoxFoodID);
            this.Controls.Add(this.labelFoodID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemForm_FormClosed);
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoodID;
        private System.Windows.Forms.ComboBox comboBoxFoodID;
        private System.Windows.Forms.ComboBox comboBoxStallName;
        private System.Windows.Forms.Label labelStallName;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelFoodType;
        private System.Windows.Forms.Label labelFoodDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label labelStallID;
        private System.Windows.Forms.ComboBox comboBoxFoodType;
        private System.Windows.Forms.Label labelFoodTypeID;
        private System.Windows.Forms.TextBox textBoxFoodDescription;
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxFoodTypeID;
        private System.Windows.Forms.TextBox textBoxStallID;
    }
}