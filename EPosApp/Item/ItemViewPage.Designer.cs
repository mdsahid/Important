namespace EPosApp.Item
{
    partial class ItemViewPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteItem = new EPosApp.ButtonX();
            this.btnBackItemList = new EPosApp.ButtonX();
            this.btnAddItem = new EPosApp.ButtonX();
            this.btnEditItem = new EPosApp.ButtonX();
            this.lblUnits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnBackItemList);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.btnEditItem);
            this.panel1.Controls.Add(this.lblUnits);
            this.panel1.Location = new System.Drawing.Point(7, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 32);
            this.panel1.TabIndex = 23;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteItem.BZBackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.ChangeColorMouseHC = true;
            this.btnDeleteItem.DisplayText = "Delete Item";
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Location = new System.Drawing.Point(1098, 4);
            this.btnDeleteItem.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnDeleteItem.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(104, 24);
            this.btnDeleteItem.TabIndex = 14;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.TextLocation_X = 15;
            this.btnDeleteItem.TextLocation_Y = 1;
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnBackItemList
            // 
            this.btnBackItemList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackItemList.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnBackItemList.ChangeColorMouseHC = true;
            this.btnBackItemList.DisplayText = "Back To Item List";
            this.btnBackItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackItemList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackItemList.ForeColor = System.Drawing.Color.White;
            this.btnBackItemList.Location = new System.Drawing.Point(757, 4);
            this.btnBackItemList.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnBackItemList.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnBackItemList.Name = "btnBackItemList";
            this.btnBackItemList.Size = new System.Drawing.Size(146, 24);
            this.btnBackItemList.TabIndex = 15;
            this.btnBackItemList.Text = "Back To Item List";
            this.btnBackItemList.TextLocation_X = 15;
            this.btnBackItemList.TextLocation_Y = 1;
            this.btnBackItemList.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddItem.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnAddItem.ChangeColorMouseHC = true;
            this.btnAddItem.DisplayText = "Add Item";
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(908, 4);
            this.btnAddItem.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnAddItem.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(92, 24);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextLocation_X = 15;
            this.btnAddItem.TextLocation_Y = 1;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditItem.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnEditItem.ChangeColorMouseHC = true;
            this.btnEditItem.DisplayText = "Edit Item";
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.Location = new System.Drawing.Point(1006, 4);
            this.btnEditItem.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnEditItem.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(86, 24);
            this.btnEditItem.TabIndex = 15;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.TextLocation_X = 15;
            this.btnEditItem.TextLocation_Y = 1;
            this.btnEditItem.UseVisualStyleBackColor = false;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnits.Location = new System.Drawing.Point(15, 6);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(38, 17);
            this.lblUnits.TabIndex = 13;
            this.lblUnits.Text = "Item";
            // 
            // ItemViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 488);
            this.Controls.Add(this.panel1);
            this.Name = "ItemViewPage";
            this.Text = "ItemViewPage";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonX btnDeleteItem;
        private ButtonX btnBackItemList;
        private ButtonX btnAddItem;
        private ButtonX btnEditItem;
        private System.Windows.Forms.Label lblUnits;
    }
}