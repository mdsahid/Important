namespace EPosApp
{
    partial class ViewPage
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
            this.btnDeleteUnit = new EPosApp.ButtonX();
            this.btnBackUnitList = new EPosApp.ButtonX();
            this.btnAddUnit = new EPosApp.ButtonX();
            this.btnEditUnit = new EPosApp.ButtonX();
            this.lblUnits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btnDeleteUnit);
            this.panel1.Controls.Add(this.btnBackUnitList);
            this.panel1.Controls.Add(this.btnAddUnit);
            this.panel1.Controls.Add(this.btnEditUnit);
            this.panel1.Controls.Add(this.lblUnits);
            this.panel1.Location = new System.Drawing.Point(7, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 32);
            this.panel1.TabIndex = 22;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteUnit.BZBackColor = System.Drawing.Color.Red;
            this.btnDeleteUnit.ChangeColorMouseHC = true;
            this.btnDeleteUnit.DisplayText = "Delete Unit";
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUnit.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUnit.Location = new System.Drawing.Point(1098, 4);
            this.btnDeleteUnit.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnDeleteUnit.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(104, 24);
            this.btnDeleteUnit.TabIndex = 14;
            this.btnDeleteUnit.Text = "Delete Unit";
            this.btnDeleteUnit.TextLocation_X = 15;
            this.btnDeleteUnit.TextLocation_Y = 1;
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            // 
            // btnBackUnitList
            // 
            this.btnBackUnitList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackUnitList.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnBackUnitList.ChangeColorMouseHC = true;
            this.btnBackUnitList.DisplayText = "Back To Unit List";
            this.btnBackUnitList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUnitList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackUnitList.ForeColor = System.Drawing.Color.White;
            this.btnBackUnitList.Location = new System.Drawing.Point(757, 4);
            this.btnBackUnitList.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnBackUnitList.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnBackUnitList.Name = "btnBackUnitList";
            this.btnBackUnitList.Size = new System.Drawing.Size(146, 24);
            this.btnBackUnitList.TabIndex = 15;
            this.btnBackUnitList.Text = "Back To Unit List";
            this.btnBackUnitList.TextLocation_X = 15;
            this.btnBackUnitList.TextLocation_Y = 1;
            this.btnBackUnitList.UseVisualStyleBackColor = false;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddUnit.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnAddUnit.ChangeColorMouseHC = true;
            this.btnAddUnit.DisplayText = "Add Unit";
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUnit.ForeColor = System.Drawing.Color.White;
            this.btnAddUnit.Location = new System.Drawing.Point(908, 4);
            this.btnAddUnit.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnAddUnit.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(92, 24);
            this.btnAddUnit.TabIndex = 15;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.TextLocation_X = 15;
            this.btnAddUnit.TextLocation_Y = 1;
            this.btnAddUnit.UseVisualStyleBackColor = false;
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditUnit.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnEditUnit.ChangeColorMouseHC = true;
            this.btnEditUnit.DisplayText = "Edit Unit";
            this.btnEditUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditUnit.ForeColor = System.Drawing.Color.White;
            this.btnEditUnit.Location = new System.Drawing.Point(1006, 4);
            this.btnEditUnit.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnEditUnit.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(86, 24);
            this.btnEditUnit.TabIndex = 15;
            this.btnEditUnit.Text = "Edit Unit";
            this.btnEditUnit.TextLocation_X = 15;
            this.btnEditUnit.TextLocation_Y = 1;
            this.btnEditUnit.UseVisualStyleBackColor = false;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnits.Location = new System.Drawing.Point(15, 6);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(37, 17);
            this.lblUnits.TabIndex = 13;
            this.lblUnits.Text = "Unit";
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 488);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPage";
            this.Text = "ViewPage";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonX btnDeleteUnit;
        private ButtonX btnBackUnitList;
        private ButtonX btnAddUnit;
        private ButtonX btnEditUnit;
        private System.Windows.Forms.Label lblUnits;
    }
}