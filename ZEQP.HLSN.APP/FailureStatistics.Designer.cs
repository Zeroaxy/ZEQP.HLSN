namespace Camera.Hikvision
{
    partial class FailureStatistics
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
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);
            Hide();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailureStatistics));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGridClassic1 = new C1.Win.C1FlexGrid.Classic.C1FlexGridClassic();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridClassic1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ForeColor = System.Drawing.SystemColors.Window;
            this.c1FlexGrid1.Location = new System.Drawing.Point(295, 496);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(424, 229);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 1;
            // 
            // c1FlexGridClassic1
            // 
            this.c1FlexGridClassic1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGridClassic1.GridColorFixed = System.Drawing.SystemColors.ControlDark;
            this.c1FlexGridClassic1.Location = new System.Drawing.Point(155, 22);
            this.c1FlexGridClassic1.Name = "c1FlexGridClassic1";
            this.c1FlexGridClassic1.NodeClosedPicture = null;
            this.c1FlexGridClassic1.NodeOpenPicture = null;
            this.c1FlexGridClassic1.OutlineCol = -1;
            this.c1FlexGridClassic1.Size = new System.Drawing.Size(637, 436);
            this.c1FlexGridClassic1.TabIndex = 2;
            this.c1FlexGridClassic1.TreeColor = System.Drawing.Color.DarkGray;
            // 
            // FailureStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.c1FlexGridClassic1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "FailureStatistics";
            this.Text = "故障统计";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridClassic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.Classic.C1FlexGridClassic c1FlexGridClassic1;
    }
}