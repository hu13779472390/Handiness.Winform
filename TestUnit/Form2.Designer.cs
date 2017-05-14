namespace TestUnit
{
    partial class Form2
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
            this.windowsButton1 = new Handiness.Winform.Control.WindowsButton();
            this.windowsButton2 = new Handiness.Winform.Control.WindowsButton();
            this.symbol1 = new Handiness.Winform.Control.Symbol();
            this.SuspendLayout();
            // 
            // windowsButton1
            // 
            this.windowsButton1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.windowsButton1.EnabledAdsorb = true;
            this.windowsButton1.EnabledMousePierce = false;
            this.windowsButton1.Font = new System.Drawing.Font("FontAwesome", 10F);
            this.windowsButton1.ForeColor = System.Drawing.Color.White;
            this.windowsButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.windowsButton1.IconSize = 10F;
            this.windowsButton1.Location = new System.Drawing.Point(587, 32);
            this.windowsButton1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsButton1.Name = "windowsButton1";
            this.windowsButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.windowsButton1.Size = new System.Drawing.Size(40, 35);
            this.windowsButton1.TabIndex = 0;
            this.windowsButton1.Text = "";
            this.windowsButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.windowsButton1.WindowsButtonType = Handiness.Winform.Control.WindowsButtonType.Maximize;
            // 
            // windowsButton2
            // 
            this.windowsButton2.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.windowsButton2.EnabledAdsorb = true;
            this.windowsButton2.EnabledMousePierce = false;
            this.windowsButton2.Font = new System.Drawing.Font("FontAwesome", 10F);
            this.windowsButton2.ForeColor = System.Drawing.Color.White;
            this.windowsButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.windowsButton2.IconSize = 10F;
            this.windowsButton2.Location = new System.Drawing.Point(640, 32);
            this.windowsButton2.Margin = new System.Windows.Forms.Padding(0);
            this.windowsButton2.Name = "windowsButton2";
            this.windowsButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.windowsButton2.Size = new System.Drawing.Size(40, 35);
            this.windowsButton2.TabIndex = 1;
            this.windowsButton2.Text = "";
            this.windowsButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.windowsButton2.WindowsButtonType = Handiness.Winform.Control.WindowsButtonType.Close;
            // 
            // symbol1
            // 
            this.symbol1.EnabledMousePierce = false;
            this.symbol1.Font = new System.Drawing.Font("FontAwesome", 15F);
            this.symbol1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.symbol1.Location = new System.Drawing.Point(328, 214);
            this.symbol1.Margin = new System.Windows.Forms.Padding(0);
            this.symbol1.Name = "symbol1";
            this.symbol1.Size = new System.Drawing.Size(75, 38);
            this.symbol1.SymbolColor = System.Drawing.SystemColors.ControlText;
            this.symbol1.SymbolPattern = "";
            this.symbol1.SymbolSize = 15F;
            this.symbol1.TabIndex = 2;
            this.symbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.Animation.AnimationTime = 200;
            this.Animation.Enabled = true;
            this.Animation.HideEffect = Handiness.Winform.WindowAnimationStyle.Fade;
            this.Animation.ShowEffect = Handiness.Winform.WindowAnimationStyle.Center;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(699, 459);
            this.Controls.Add(this.symbol1);
            this.Controls.Add(this.windowsButton2);
            this.Controls.Add(this.windowsButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Handiness.Winform.Control.WindowsButton windowsButton1;
        private Handiness.Winform.Control.WindowsButton windowsButton2;
        private Handiness.Winform.Control.Symbol symbol1;
    }
}