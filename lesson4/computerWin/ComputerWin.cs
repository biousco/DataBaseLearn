using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class ComputerWin : Form
    {
        string numA, numB, res;
        bool isNum = true;
        Operation oper;
        public ComputerWin()
        {
            InitializeComponent();
            showButton();
            showOperation();

        }

        private void showOperation()
        {
            this.AddOperation = new System.Windows.Forms.Button();
            this.divOperation = new System.Windows.Forms.Button();
            this.MulOperation = new System.Windows.Forms.Button();
            this.SubOperation = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();

            // 
            // AddOperation
            // 
            this.AddOperation.Location = new System.Drawing.Point(345, 71);
            this.AddOperation.Name = "AddOperation";
            this.AddOperation.Size = new System.Drawing.Size(38, 33);
            this.AddOperation.TabIndex = 2;
            this.AddOperation.Text = "+";
            this.AddOperation.UseVisualStyleBackColor = true;
            this.AddOperation.Click += new System.EventHandler(this.OperationClick);
            // 
            // divOperation
            // 
            this.divOperation.Location = new System.Drawing.Point(345, 110);
            this.divOperation.Name = "divOperation";
            this.divOperation.Size = new System.Drawing.Size(38, 33);
            this.divOperation.TabIndex = 3;
            this.divOperation.Text = "-";
            this.divOperation.UseVisualStyleBackColor = true;
            this.divOperation.Click += new System.EventHandler(this.OperationClick);
            // 
            // MulOperation
            // 
            this.MulOperation.Location = new System.Drawing.Point(345, 149);
            this.MulOperation.Name = "MulOperation";
            this.MulOperation.Size = new System.Drawing.Size(38, 33);
            this.MulOperation.TabIndex = 4;
            this.MulOperation.Text = "*";
            this.MulOperation.UseVisualStyleBackColor = true;
            this.MulOperation.Click += new System.EventHandler(this.OperationClick);
            // 
            // SubOperation
            // 
            this.SubOperation.Location = new System.Drawing.Point(345, 188);
            this.SubOperation.Name = "SubOperation";
            this.SubOperation.Size = new System.Drawing.Size(38, 33);
            this.SubOperation.TabIndex = 5;
            this.SubOperation.Text = "/";
            this.SubOperation.UseVisualStyleBackColor = true;
            this.SubOperation.Click += new System.EventHandler(this.OperationClick);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(279, 236);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(104, 40);
            this.ComputeButton.TabIndex = 6;
            this.ComputeButton.Text = "=";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeClick);

            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.SubOperation);
            this.Controls.Add(this.MulOperation);
            this.Controls.Add(this.divOperation);
            this.Controls.Add(this.AddOperation);
        }

        private void showButton()
        {
            this.InputNumArray = new System.Windows.Forms.Button[10];
            for (int i = 1; i < 10; i++)
            {
                this.InputNumArray[i] = new System.Windows.Forms.Button();
                this.InputNumArray[i].Location = new System.Drawing.Point(100 + 50 * ((i-1) % 3), 100 + 50 * ((i-1) / 3));
                this.InputNumArray[i].Name = "InputNum" + i;
                this.InputNumArray[i].Size = new System.Drawing.Size(50, 42);
                this.InputNumArray[i].TabIndex = 2;
                this.InputNumArray[i].Text = i.ToString();
                this.InputNumArray[i].UseVisualStyleBackColor = true;
                this.InputNumArray[i].Click += new System.EventHandler(this.Numbtns_Click);
                this.Controls.Add(this.InputNumArray[i]);
            }
        }


        private void Numbtns_Click(object sender, EventArgs e)
        {
            if(!isNum || this.ComputeResult.Text == "0")
            {
                this.ComputeResult.Text = "";
                isNum = true;
            }  
            this.ComputeResult.Text += ((Button)sender).Text;
        }


        private void OperationClick(object sender, EventArgs e)
        {
            numA = this.ComputeResult.Text;
            this.ComputeResult.Text = ((Button)sender).Text;
            oper = OperationFactory.createOperate(((Button)sender).Text);
            isNum = false;
        }

        private void ComputeClick(object sender, EventArgs e)
        {
            numB = this.ComputeResult.Text;
            oper.NumA = Convert.ToDouble(numA);
            oper.NumB = Convert.ToDouble(numB);
            res = Convert.ToString(oper.GetResult());
            this.ComputeResult.Text = res;
            numA = "0";
            numB = "0";
            res = "0";
        }
    }
}
