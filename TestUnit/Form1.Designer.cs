using Handiness.Winform;

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
            this.scutcheon2 = new Handiness.Winform.Control.Scutcheon();
            this.scutcheon3 = new Handiness.Winform.Control.Scutcheon();
            this.scutcheon4 = new Handiness.Winform.Control.Scutcheon();
            this.waitIndicator1 = new Handiness.Winform.Control.WaitIndicator();
            this.symbol1 = new Handiness.Winform.Control.Symbol();
            this.button1 = new Handiness.Winform.Control.Button();
            this.windowsButton2 = new Handiness.Winform.Control.WindowsButton();
            this.angleEditorTestControl1 = new AngleEditor.AngleEditorTestControl();
            this.windowsButton1 = new Handiness.Winform.Control.WindowsButton();
            this.SuspendLayout();
            // 
            // scutcheon2
            // 
            this.scutcheon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.scutcheon2.EnabledMousePierce = false;
            this.scutcheon2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scutcheon2.ForeColor = System.Drawing.Color.White;
            this.scutcheon2.Location = new System.Drawing.Point(22, 170);
            this.scutcheon2.Margin = new System.Windows.Forms.Padding(0);
            this.scutcheon2.Name = "scutcheon2";
            this.scutcheon2.ScutcheonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            this.scutcheon2.ScutcheonShape = Handiness.Winform.Control.ScutcheonShapeType.Square;
            this.scutcheon2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.scutcheon2.ShadowWidth = 2;
            this.scutcheon2.Size = new System.Drawing.Size(173, 48);
            this.scutcheon2.TabIndex = 4;
            this.scutcheon2.Text = "有没有赚钱啊！";
            this.scutcheon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scutcheon3
            // 
            this.scutcheon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.scutcheon3.EnabledMousePierce = false;
            this.scutcheon3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scutcheon3.ForeColor = System.Drawing.Color.White;
            this.scutcheon3.Location = new System.Drawing.Point(12, 310);
            this.scutcheon3.Margin = new System.Windows.Forms.Padding(0);
            this.scutcheon3.Name = "scutcheon3";
            this.scutcheon3.ScutcheonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            this.scutcheon3.ScutcheonShape = Handiness.Winform.Control.ScutcheonShapeType.Triangle;
            this.scutcheon3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.scutcheon3.ShadowWidth = 2;
            this.scutcheon3.Size = new System.Drawing.Size(173, 54);
            this.scutcheon3.TabIndex = 5;
            this.scutcheon3.Text = "那还握钱！~~~";
            this.scutcheon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scutcheon4
            // 
            this.scutcheon4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.scutcheon4.EnabledMousePierce = false;
            this.scutcheon4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scutcheon4.ForeColor = System.Drawing.Color.White;
            this.scutcheon4.Location = new System.Drawing.Point(190, 243);
            this.scutcheon4.Margin = new System.Windows.Forms.Padding(0);
            this.scutcheon4.Name = "scutcheon4";
            this.scutcheon4.ScutcheonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(166)))), ((int)(((byte)(228)))));
            this.scutcheon4.ScutcheonShape = Handiness.Winform.Control.ScutcheonShapeType.Circle;
            this.scutcheon4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.scutcheon4.ShadowWidth = 2;
            this.scutcheon4.Size = new System.Drawing.Size(155, 59);
            this.scutcheon4.TabIndex = 6;
            this.scutcheon4.Text = "没有...";
            this.scutcheon4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waitIndicator1
            // 
            this.waitIndicator1.CurrentAngle = 0F;
            this.waitIndicator1.EachRollingAngle = 15F;
            this.waitIndicator1.EnabledMousePierce = false;
            this.waitIndicator1.HatchBrushStyle = System.Drawing.Drawing2D.HatchStyle.DarkHorizontal;
            this.waitIndicator1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.waitIndicator1.IsFollowParentBackColor = true;
            this.waitIndicator1.Location = new System.Drawing.Point(470, 135);
            this.waitIndicator1.Margin = new System.Windows.Forms.Padding(0);
            this.waitIndicator1.Name = "waitIndicator1";
            this.waitIndicator1.RollingSpeed = 60D;
            this.waitIndicator1.RollPartBrushType = Handiness.Winform.Control.RollPartBrushType.Solid;
            this.waitIndicator1.RollPartLengthPercent = 40F;
            this.waitIndicator1.RollPartWidthPercent = 10F;
            this.waitIndicator1.Size = new System.Drawing.Size(70, 66);
            this.waitIndicator1.TabIndex = 7;
            this.waitIndicator1.Text = "waitIndicator1";
            this.waitIndicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.waitIndicator1.WaitIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            // 
            // symbol1
            // 
            this.symbol1.EnabledMousePierce = false;
            this.symbol1.Font = new System.Drawing.Font("FontAwesome", 14F);
            this.symbol1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.symbol1.Location = new System.Drawing.Point(356, 103);
            this.symbol1.Margin = new System.Windows.Forms.Padding(0);
            this.symbol1.Name = "symbol1";
            this.symbol1.Size = new System.Drawing.Size(38, 35);
            this.symbol1.SymbolColor = System.Drawing.SystemColors.ActiveCaption;
            this.symbol1.SymbolPattern = "";
            this.symbol1.SymbolSize = 14F;
            this.symbol1.TabIndex = 9;
            this.symbol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button1.EnabledMousePierce = false;
            this.button1.EnabledWaitingClick = false;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button1.IsWaiting = false;
            this.button1.Location = new System.Drawing.Point(290, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.windowsButton2.Location = new System.Drawing.Point(702, 78);
            this.windowsButton2.Margin = new System.Windows.Forms.Padding(0);
            this.windowsButton2.Name = "windowsButton2";
            this.windowsButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.windowsButton2.Size = new System.Drawing.Size(40, 35);
            this.windowsButton2.TabIndex = 12;
            this.windowsButton2.Text = "";
            this.windowsButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.windowsButton2.WindowsButtonType = Handiness.Winform.Control.WindowsButtonType.Close;
            // 
            // angleEditorTestControl1
            // 
            this.angleEditorTestControl1.Angle = 0.66234944737220758D;
            this.angleEditorTestControl1.BackColor = System.Drawing.Color.Beige;
            this.angleEditorTestControl1.Location = new System.Drawing.Point(502, 259);
            this.angleEditorTestControl1.Name = "angleEditorTestControl1";
            this.angleEditorTestControl1.Size = new System.Drawing.Size(190, 112);
            this.angleEditorTestControl1.TabIndex = 8;
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
            this.windowsButton1.Location = new System.Drawing.Point(633, 166);
            this.windowsButton1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsButton1.Name = "windowsButton1";
            this.windowsButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.windowsButton1.Size = new System.Drawing.Size(40, 35);
            this.windowsButton1.TabIndex = 13;
            this.windowsButton1.Text = "";
            this.windowsButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.windowsButton1.WindowsButtonType = Handiness.Winform.Control.WindowsButtonType.Maximize;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(762, 471);
            this.Controls.Add(this.windowsButton1);
            this.Controls.Add(this.windowsButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.symbol1);
            this.Controls.Add(this.angleEditorTestControl1);
            this.Controls.Add(this.waitIndicator1);
            this.Controls.Add(this.scutcheon4);
            this.Controls.Add(this.scutcheon3);
            this.Controls.Add(this.scutcheon2);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Handiness.Winform.Control.Scutcheon scutcheon2;
        private Handiness.Winform.Control.Scutcheon scutcheon3;
        private Handiness.Winform.Control.Scutcheon scutcheon4;
        private Handiness.Winform.Control.WaitIndicator waitIndicator1;
        private AngleEditor.AngleEditorTestControl angleEditorTestControl1;
        private Handiness.Winform.Control.Symbol symbol1;
        private Handiness.Winform.Control.Button button1;
        private Handiness.Winform.Control.WindowsButton windowsButton2;
        private Handiness.Winform.Control.WindowsButton windowsButton1;
    }
}