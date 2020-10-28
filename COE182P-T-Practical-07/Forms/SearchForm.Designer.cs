namespace COE182P_T_Practical_07
{
    partial class SearchForm
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
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchFood = new System.Windows.Forms.Button();
            this.textBoxFoodType = new System.Windows.Forms.TextBox();
            this.buttonSearchType = new System.Windows.Forms.Button();
            this.textBoxStallName = new System.Windows.Forms.TextBox();
            this.buttonSearchStall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFoodName.Location = new System.Drawing.Point(183, 12);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(350, 34);
            this.textBoxFoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Food Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Food Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search Stall Name:";
            // 
            // buttonSearchFood
            // 
            this.buttonSearchFood.BackColor = System.Drawing.Color.Lime;
            this.buttonSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchFood.Location = new System.Drawing.Point(260, 64);
            this.buttonSearchFood.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchFood.Name = "buttonSearchFood";
            this.buttonSearchFood.Size = new System.Drawing.Size(200, 70);
            this.buttonSearchFood.TabIndex = 0;
            this.buttonSearchFood.Text = "SEARCH FOOD";
            this.buttonSearchFood.UseVisualStyleBackColor = false;
            this.buttonSearchFood.Click += new System.EventHandler(this.buttonSearchFood_Click);
            // 
            // textBoxFoodType
            // 
            this.textBoxFoodType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFoodType.Location = new System.Drawing.Point(183, 152);
            this.textBoxFoodType.Name = "textBoxFoodType";
            this.textBoxFoodType.Size = new System.Drawing.Size(350, 34);
            this.textBoxFoodType.TabIndex = 1;
            // 
            // buttonSearchType
            // 
            this.buttonSearchType.BackColor = System.Drawing.Color.Lime;
            this.buttonSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchType.Location = new System.Drawing.Point(260, 204);
            this.buttonSearchType.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchType.Name = "buttonSearchType";
            this.buttonSearchType.Size = new System.Drawing.Size(200, 70);
            this.buttonSearchType.TabIndex = 0;
            this.buttonSearchType.Text = "SEARCH TYPE";
            this.buttonSearchType.UseVisualStyleBackColor = false;
            this.buttonSearchType.Click += new System.EventHandler(this.buttonSearchType_Click);
            // 
            // textBoxStallName
            // 
            this.textBoxStallName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStallName.Location = new System.Drawing.Point(183, 292);
            this.textBoxStallName.Name = "textBoxStallName";
            this.textBoxStallName.Size = new System.Drawing.Size(350, 34);
            this.textBoxStallName.TabIndex = 1;
            // 
            // buttonSearchStall
            // 
            this.buttonSearchStall.BackColor = System.Drawing.Color.Lime;
            this.buttonSearchStall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchStall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchStall.Location = new System.Drawing.Point(260, 344);
            this.buttonSearchStall.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchStall.Name = "buttonSearchStall";
            this.buttonSearchStall.Size = new System.Drawing.Size(200, 70);
            this.buttonSearchStall.TabIndex = 0;
            this.buttonSearchStall.Text = "SEARCH STALL";
            this.buttonSearchStall.UseVisualStyleBackColor = false;
            this.buttonSearchStall.Click += new System.EventHandler(this.buttonSearchStall_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.buttonSearchStall);
            this.Controls.Add(this.textBoxStallName);
            this.Controls.Add(this.buttonSearchType);
            this.Controls.Add(this.textBoxFoodType);
            this.Controls.Add(this.buttonSearchFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFoodName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchFood;
        private System.Windows.Forms.TextBox textBoxFoodType;
        private System.Windows.Forms.Button buttonSearchType;
        private System.Windows.Forms.TextBox textBoxStallName;
        private System.Windows.Forms.Button buttonSearchStall;
    }
}