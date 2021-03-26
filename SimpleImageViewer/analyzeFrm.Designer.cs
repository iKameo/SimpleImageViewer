namespace SimpleImageViewer
{
    partial class analyzeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analyzeFrm));
            this.lv_Values = new System.Windows.Forms.ListView();
            this.col_Properties = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_Values
            // 
            this.lv_Values.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Values.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Properties,
            this.col_Value});
            this.lv_Values.GridLines = true;
            this.lv_Values.Location = new System.Drawing.Point(12, 12);
            this.lv_Values.Name = "lv_Values";
            this.lv_Values.Size = new System.Drawing.Size(360, 368);
            this.lv_Values.TabIndex = 3;
            this.lv_Values.UseCompatibleStateImageBehavior = false;
            this.lv_Values.View = System.Windows.Forms.View.Details;
            // 
            // col_Properties
            // 
            this.col_Properties.Text = "Properties";
            this.col_Properties.Width = 120;
            // 
            // col_Value
            // 
            this.col_Value.Text = "Value";
            this.col_Value.Width = 230;
            // 
            // analyzeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 392);
            this.Controls.Add(this.lv_Values);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "analyzeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analyze File";
            this.Load += new System.EventHandler(this.analyzeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lv_Values;
        private System.Windows.Forms.ColumnHeader col_Properties;
        private System.Windows.Forms.ColumnHeader col_Value;
    }
}