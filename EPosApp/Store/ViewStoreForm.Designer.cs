namespace EPosApp.Store
{
    partial class ViewStoreForm
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
            this.btnDeleteStore = new EPosApp.ButtonX();
            this.btnBackStoreList = new EPosApp.ButtonX();
            this.btnAddStore = new EPosApp.ButtonX();
            this.btnEditStore = new EPosApp.ButtonX();
            this.lblUnits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnDeleteStore);
            this.panel1.Controls.Add(this.btnBackStoreList);
            this.panel1.Controls.Add(this.btnAddStore);
            this.panel1.Controls.Add(this.btnEditStore);
            this.panel1.Controls.Add(this.lblUnits);
            this.panel1.Location = new System.Drawing.Point(7, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 32);
            this.panel1.TabIndex = 23;
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteStore.BZBackColor = System.Drawing.Color.Red;
            this.btnDeleteStore.ChangeColorMouseHC = true;
            this.btnDeleteStore.DisplayText = "Delete Store";
            this.btnDeleteStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStore.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStore.Location = new System.Drawing.Point(1098, 4);
            this.btnDeleteStore.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnDeleteStore.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(104, 24);
            this.btnDeleteStore.TabIndex = 14;
            this.btnDeleteStore.Text = "Delete Store";
            this.btnDeleteStore.TextLocation_X = 15;
            this.btnDeleteStore.TextLocation_Y = 1;
            this.btnDeleteStore.UseVisualStyleBackColor = false;
            // 
            // btnBackStoreList
            // 
            this.btnBackStoreList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackStoreList.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnBackStoreList.ChangeColorMouseHC = true;
            this.btnBackStoreList.DisplayText = "Back To Store List";
            this.btnBackStoreList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackStoreList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackStoreList.ForeColor = System.Drawing.Color.White;
            this.btnBackStoreList.Location = new System.Drawing.Point(757, 4);
            this.btnBackStoreList.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnBackStoreList.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnBackStoreList.Name = "btnBackStoreList";
            this.btnBackStoreList.Size = new System.Drawing.Size(146, 24);
            this.btnBackStoreList.TabIndex = 15;
            this.btnBackStoreList.Text = "Back To Store List";
            this.btnBackStoreList.TextLocation_X = 15;
            this.btnBackStoreList.TextLocation_Y = 1;
            this.btnBackStoreList.UseVisualStyleBackColor = false;
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddStore.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnAddStore.ChangeColorMouseHC = true;
            this.btnAddStore.DisplayText = "Add Store";
            this.btnAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStore.ForeColor = System.Drawing.Color.White;
            this.btnAddStore.Location = new System.Drawing.Point(908, 4);
            this.btnAddStore.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnAddStore.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(92, 24);
            this.btnAddStore.TabIndex = 15;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.TextLocation_X = 15;
            this.btnAddStore.TextLocation_Y = 1;
            this.btnAddStore.UseVisualStyleBackColor = false;
            // 
            // btnEditStore
            // 
            this.btnEditStore.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditStore.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnEditStore.ChangeColorMouseHC = true;
            this.btnEditStore.DisplayText = "Edit Store";
            this.btnEditStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditStore.ForeColor = System.Drawing.Color.White;
            this.btnEditStore.Location = new System.Drawing.Point(1006, 4);
            this.btnEditStore.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnEditStore.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnEditStore.Name = "btnEditStore";
            this.btnEditStore.Size = new System.Drawing.Size(86, 24);
            this.btnEditStore.TabIndex = 15;
            this.btnEditStore.Text = "Edit Store";
            this.btnEditStore.TextLocation_X = 15;
            this.btnEditStore.TextLocation_Y = 1;
            this.btnEditStore.UseVisualStyleBackColor = false;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnits.Location = new System.Drawing.Point(15, 6);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(47, 17);
            this.lblUnits.TabIndex = 13;
            this.lblUnits.Text = "Store";
            // 
            // ViewStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 488);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStoreForm";
            this.Text = "ViewStoreForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonX btnDeleteStore;
        private ButtonX btnBackStoreList;
        private ButtonX btnAddStore;
        private ButtonX btnEditStore;
        private System.Windows.Forms.Label lblUnits;
    }
}