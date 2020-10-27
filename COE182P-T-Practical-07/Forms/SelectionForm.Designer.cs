namespace COE182P_T_Practical_07
{
    partial class SelectionForm
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
            this.buttonStall = new System.Windows.Forms.Button();
            this.buttonItem = new System.Windows.Forms.Button();
            this.buttonFoodType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStall
            // 
            this.buttonStall.BackColor = System.Drawing.Color.Lime;
            this.buttonStall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStall.Location = new System.Drawing.Point(16, 19);
            this.buttonStall.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStall.Name = "buttonStall";
            this.buttonStall.Size = new System.Drawing.Size(200, 70);
            this.buttonStall.TabIndex = 0;
            this.buttonStall.Text = "STALL";
            this.buttonStall.UseVisualStyleBackColor = false;
            this.buttonStall.Click += new System.EventHandler(this.buttonStall_Click);
            // 
            // buttonItem
            // 
            this.buttonItem.BackColor = System.Drawing.Color.Lime;
            this.buttonItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonItem.Location = new System.Drawing.Point(16, 189);
            this.buttonItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Size = new System.Drawing.Size(200, 70);
            this.buttonItem.TabIndex = 0;
            this.buttonItem.Text = "ITEM";
            this.buttonItem.UseVisualStyleBackColor = false;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonFoodType
            // 
            this.buttonFoodType.BackColor = System.Drawing.Color.Lime;
            this.buttonFoodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFoodType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFoodType.Location = new System.Drawing.Point(16, 104);
            this.buttonFoodType.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFoodType.Name = "buttonFoodType";
            this.buttonFoodType.Size = new System.Drawing.Size(200, 70);
            this.buttonFoodType.TabIndex = 0;
            this.buttonFoodType.Text = "FOOD TYPE";
            this.buttonFoodType.UseVisualStyleBackColor = false;
            this.buttonFoodType.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.buttonFoodType);
            this.Controls.Add(this.buttonItem);
            this.Controls.Add(this.buttonStall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStall;
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.Button buttonFoodType;
    }
}