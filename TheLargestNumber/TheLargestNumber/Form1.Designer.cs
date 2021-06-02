
namespace TheLargestNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtArrayLenght = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewArray = new System.Windows.Forms.TextBox();
            this.txtExampleArray = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalculated = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartedEndedOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizi boyutunu";
            // 
            // txtArrayLenght
            // 
            this.txtArrayLenght.Location = new System.Drawing.Point(185, 34);
            this.txtArrayLenght.Name = "txtArrayLenght";
            this.txtArrayLenght.Size = new System.Drawing.Size(100, 20);
            this.txtArrayLenght.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dizi";
            // 
            // txtNewArray
            // 
            this.txtNewArray.Location = new System.Drawing.Point(185, 63);
            this.txtNewArray.Multiline = true;
            this.txtNewArray.Name = "txtNewArray";
            this.txtNewArray.Size = new System.Drawing.Size(232, 223);
            this.txtNewArray.TabIndex = 3;
            // 
            // txtExampleArray
            // 
            this.txtExampleArray.Location = new System.Drawing.Point(556, 63);
            this.txtExampleArray.Multiline = true;
            this.txtExampleArray.Name = "txtExampleArray";
            this.txtExampleArray.Size = new System.Drawing.Size(232, 223);
            this.txtExampleArray.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Örnek Dizi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesaplanacak sayı adedi";
            // 
            // txtCalculated
            // 
            this.txtCalculated.Location = new System.Drawing.Point(185, 323);
            this.txtCalculated.Name = "txtCalculated";
            this.txtCalculated.Size = new System.Drawing.Size(100, 20);
            this.txtCalculated.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Örnek Dizi Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(185, 392);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sonuç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Başlangıç/Bitiş Sırası";
            // 
            // txtStartedEndedOrder
            // 
            this.txtStartedEndedOrder.Location = new System.Drawing.Point(185, 418);
            this.txtStartedEndedOrder.Name = "txtStartedEndedOrder";
            this.txtStartedEndedOrder.Size = new System.Drawing.Size(100, 20);
            this.txtStartedEndedOrder.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStartedEndedOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCalculated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExampleArray);
            this.Controls.Add(this.txtNewArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArrayLenght);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArrayLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewArray;
        private System.Windows.Forms.TextBox txtExampleArray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalculated;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartedEndedOrder;
    }
}

