using System;
using System.Windows.Forms;

namespace Computer
{
    partial class ComputerWin
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
            this.resultText = new System.Windows.Forms.Label();
            this.ComputeResult = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.Location = new System.Drawing.Point(34, 42);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(115, 21);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "计算结果：";
           
            // 
            // ComputeResult
            // 
            this.ComputeResult.AutoSize = true;
            this.ComputeResult.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComputeResult.Location = new System.Drawing.Point(155, 42);
            this.ComputeResult.Name = "ComputeResult";
            this.ComputeResult.Size = new System.Drawing.Size(0, 21);
            this.ComputeResult.TabIndex = 1;

            // 
            // ComputerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 320);

            this.Controls.Add(this.ComputeResult);
            this.Controls.Add(this.resultText);
            this.Name = "ComputerWin";
            this.Text = "ComputerWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label ComputeResult;
        private Button[] InputNumArray;
        private Button[] OperationArray;
        private Button AddOperation;
        private Button divOperation;
        private Button MulOperation;
        private Button SubOperation;
        private Button ComputeButton;
    }
}