namespace WinFormUI
{
    partial class FormDB
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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupBath = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.btnRestor = new System.Windows.Forms.Button();
            this.btnRestorPath = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.btnBackupBath);
            this.grpBackup.Controls.Add(this.txtBackup);
            this.grpBackup.Controls.Add(this.label1);
            this.grpBackup.Location = new System.Drawing.Point(27, 25);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(443, 130);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "备份数据库";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(47, 88);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(356, 30);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupBath
            // 
            this.btnBackupBath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackupBath.Location = new System.Drawing.Point(371, 31);
            this.btnBackupBath.Name = "btnBackupBath";
            this.btnBackupBath.Size = new System.Drawing.Size(67, 23);
            this.btnBackupBath.TabIndex = 2;
            this.btnBackupBath.Text = "选择";
            this.btnBackupBath.UseVisualStyleBackColor = true;
            this.btnBackupBath.Click += new System.EventHandler(this.btnBackupBath_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBackup.Location = new System.Drawing.Point(82, 31);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(258, 23);
            this.txtBackup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份路径";
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestor);
            this.grpRestore.Controls.Add(this.btnRestorPath);
            this.grpRestore.Controls.Add(this.txtRestore);
            this.grpRestore.Controls.Add(this.label2);
            this.grpRestore.Location = new System.Drawing.Point(27, 169);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(443, 130);
            this.grpRestore.TabIndex = 1;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "恢复数据库";
            // 
            // btnRestor
            // 
            this.btnRestor.Location = new System.Drawing.Point(43, 79);
            this.btnRestor.Name = "btnRestor";
            this.btnRestor.Size = new System.Drawing.Size(356, 30);
            this.btnRestor.TabIndex = 7;
            this.btnRestor.Text = "恢复数据库";
            this.btnRestor.UseVisualStyleBackColor = true;
            this.btnRestor.Click += new System.EventHandler(this.btnRestor_Click);
            // 
            // btnRestorPath
            // 
            this.btnRestorPath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRestorPath.Location = new System.Drawing.Point(367, 22);
            this.btnRestorPath.Name = "btnRestorPath";
            this.btnRestorPath.Size = new System.Drawing.Size(67, 23);
            this.btnRestorPath.TabIndex = 6;
            this.btnRestorPath.Text = "选择";
            this.btnRestorPath.UseVisualStyleBackColor = true;
            this.btnRestorPath.Click += new System.EventHandler(this.btnRestorPath_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRestore.Location = new System.Drawing.Point(78, 22);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(258, 23);
            this.txtRestore.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "恢复路径";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.Name = "FormDB";
            this.Text = "FormDB";
            this.Load += new System.EventHandler(this.FormDB_Load);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBackupBath;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestor;
        private System.Windows.Forms.Button btnRestorPath;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}