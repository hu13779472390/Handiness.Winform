namespace TestUnit
{
    partial class Form1
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
            this.scutcheon1 = new Handiness.Winform.Control.Scutcheon();
            this.SuspendLayout();
            // 
            // scutcheon1
            // 
            this.scutcheon1.CanMousePenetrable = false;
            this.scutcheon1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scutcheon1.ForeColor = System.Drawing.Color.White;
            this.scutcheon1.Location = new System.Drawing.Point(54, 218);
            this.scutcheon1.Name = "scutcheon1";
            this.scutcheon1.ScutcheonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            this.scutcheon1.ScutcheonShape = Handiness.Winform.Control.ScutcheonShapeType.Square;
            this.scutcheon1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.scutcheon1.ShadowWidth = 2;
            this.scutcheon1.Size = new System.Drawing.Size(82, 39);
            this.scutcheon1.TabIndex = 0;
            this.scutcheon1.Text = "学生信息：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(752, 452);
            this.Controls.Add(this.scutcheon1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);

        }

        #endregion

        private Handiness.Winform.Control.Scutcheon scutcheon1;
    }
}