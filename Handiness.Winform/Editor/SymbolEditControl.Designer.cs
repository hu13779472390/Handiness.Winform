﻿namespace Handiness.Winform.Editor
{
    partial class SymbolEditControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this._flpPatternContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlowPan_PatternContainer
            // 
            this._flpPatternContainer.AutoScroll = true;
            this._flpPatternContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpPatternContainer.Location = new System.Drawing.Point(0, 0);
            this._flpPatternContainer.Name = "FlowPan_PatternContainer";
            this._flpPatternContainer.Size = new System.Drawing.Size(423, 194);
            this._flpPatternContainer.TabIndex = 0;
            // 
            // SymbolEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._flpPatternContainer);
            this.Name = "SymbolEditControl";
            this.Size = new System.Drawing.Size(423, 194);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpPatternContainer;
    }
}
