namespace CalcBinario_2003_VictorFernandes
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
            this.higher = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smaller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstDec = new System.Windows.Forms.Label();
            this.firstHex = new System.Windows.Forms.Label();
            this.secondDec = new System.Windows.Forms.Label();
            this.secondHex = new System.Windows.Forms.Label();
            this.resultDec = new System.Windows.Forms.Label();
            this.resultHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // higher
            // 
            this.higher.Location = new System.Drawing.Point(171, 91);
            this.higher.Name = "higher";
            this.higher.Size = new System.Drawing.Size(100, 20);
            this.higher.TabIndex = 0;
            this.higher.TextChanged += new System.EventHandler(this.firstTb);
            this.higher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pressed);
            // 
            // operation
            // 
            this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operation.Location = new System.Drawing.Point(292, 91);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(33, 21);
            this.operation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decimal";
            // 
            // smaller
            // 
            this.smaller.Location = new System.Drawing.Point(347, 91);
            this.smaller.Name = "smaller";
            this.smaller.Size = new System.Drawing.Size(100, 20);
            this.smaller.TabIndex = 3;
            this.smaller.TextChanged += new System.EventHandler(this.secondTb);
            this.smaller.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hexadecimal";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(168, 36);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(32, 13);
            this.alert.TabIndex = 5;
            this.alert.Text = "Okay";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(488, 91);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResultClick);
            // 
            // firstDec
            // 
            this.firstDec.AutoSize = true;
            this.firstDec.Location = new System.Drawing.Point(168, 138);
            this.firstDec.Name = "firstDec";
            this.firstDec.Size = new System.Drawing.Size(19, 13);
            this.firstDec.TabIndex = 9;
            this.firstDec.Text = "00";
            // 
            // firstHex
            // 
            this.firstHex.AutoSize = true;
            this.firstHex.Location = new System.Drawing.Point(168, 179);
            this.firstHex.Name = "firstHex";
            this.firstHex.Size = new System.Drawing.Size(19, 13);
            this.firstHex.TabIndex = 10;
            this.firstHex.Text = "00";
            // 
            // secondDec
            // 
            this.secondDec.AutoSize = true;
            this.secondDec.Location = new System.Drawing.Point(344, 138);
            this.secondDec.Name = "secondDec";
            this.secondDec.Size = new System.Drawing.Size(19, 13);
            this.secondDec.TabIndex = 11;
            this.secondDec.Text = "00";
            // 
            // secondHex
            // 
            this.secondHex.AutoSize = true;
            this.secondHex.Location = new System.Drawing.Point(344, 179);
            this.secondHex.Name = "secondHex";
            this.secondHex.Size = new System.Drawing.Size(19, 13);
            this.secondHex.TabIndex = 12;
            this.secondHex.Text = "00";
            // 
            // resultDec
            // 
            this.resultDec.AutoSize = true;
            this.resultDec.Location = new System.Drawing.Point(485, 138);
            this.resultDec.Name = "resultDec";
            this.resultDec.Size = new System.Drawing.Size(19, 13);
            this.resultDec.TabIndex = 13;
            this.resultDec.Text = "00";
            // 
            // resultHex
            // 
            this.resultHex.AutoSize = true;
            this.resultHex.Location = new System.Drawing.Point(485, 179);
            this.resultHex.Name = "resultHex";
            this.resultHex.Size = new System.Drawing.Size(19, 13);
            this.resultHex.TabIndex = 14;
            this.resultHex.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 262);
            this.Controls.Add(this.resultHex);
            this.Controls.Add(this.resultDec);
            this.Controls.Add(this.secondHex);
            this.Controls.Add(this.secondDec);
            this.Controls.Add(this.firstHex);
            this.Controls.Add(this.firstDec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smaller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.higher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox higher;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smaller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstDec;
        private System.Windows.Forms.Label firstHex;
        private System.Windows.Forms.Label secondDec;
        private System.Windows.Forms.Label secondHex;
        private System.Windows.Forms.Label resultDec;
        private System.Windows.Forms.Label resultHex;
    }
}

