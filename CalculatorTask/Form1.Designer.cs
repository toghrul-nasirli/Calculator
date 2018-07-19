namespace CalculatorTask
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.negative = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.squareroot = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // negative
            // 
            this.negative.BackColor = System.Drawing.Color.Gainsboro;
            this.negative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negative.Location = new System.Drawing.Point(10, 421);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(75, 43);
            this.negative.TabIndex = 0;
            this.negative.Text = "±";
            this.negative.UseVisualStyleBackColor = false;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.White;
            this.number0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number0.Location = new System.Drawing.Point(91, 421);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(75, 43);
            this.number0.TabIndex = 0;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.Gainsboro;
            this.comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma.Location = new System.Drawing.Point(172, 421);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(75, 43);
            this.comma.TabIndex = 0;
            this.comma.Text = ".";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Gainsboro;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals.Location = new System.Drawing.Point(253, 421);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 43);
            this.equals.TabIndex = 0;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.White;
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number1.Location = new System.Drawing.Point(10, 372);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(75, 43);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.White;
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number2.Location = new System.Drawing.Point(91, 372);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(75, 43);
            this.number2.TabIndex = 0;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.White;
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number3.Location = new System.Drawing.Point(172, 372);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(75, 43);
            this.number3.TabIndex = 0;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Gainsboro;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(253, 372);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 43);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.White;
            this.number4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number4.Location = new System.Drawing.Point(10, 323);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(75, 43);
            this.number4.TabIndex = 0;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.White;
            this.number5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number5.Location = new System.Drawing.Point(91, 323);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(75, 43);
            this.number5.TabIndex = 0;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.White;
            this.number6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number6.Location = new System.Drawing.Point(172, 323);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(75, 43);
            this.number6.TabIndex = 0;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Gainsboro;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(253, 323);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 43);
            this.minus.TabIndex = 0;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.White;
            this.number7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number7.Location = new System.Drawing.Point(10, 274);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(75, 43);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.White;
            this.number8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number8.Location = new System.Drawing.Point(91, 274);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(75, 43);
            this.number8.TabIndex = 0;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.White;
            this.number9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number9.Location = new System.Drawing.Point(172, 274);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(75, 43);
            this.number9.TabIndex = 0;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.Gainsboro;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(253, 274);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 43);
            this.multiply.TabIndex = 0;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.Location = new System.Drawing.Point(10, 225);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(75, 43);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(91, 225);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 43);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Gainsboro;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove.Location = new System.Drawing.Point(172, 225);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 43);
            this.remove.TabIndex = 0;
            this.remove.Text = "<------";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Gainsboro;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(253, 225);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 43);
            this.divide.TabIndex = 0;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.Gainsboro;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.Location = new System.Drawing.Point(10, 176);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 43);
            this.mod.TabIndex = 0;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // squareroot
            // 
            this.squareroot.BackColor = System.Drawing.Color.Gainsboro;
            this.squareroot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squareroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareroot.Location = new System.Drawing.Point(91, 176);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(75, 43);
            this.squareroot.TabIndex = 0;
            this.squareroot.Text = "√";
            this.squareroot.UseVisualStyleBackColor = false;
            this.squareroot.Click += new System.EventHandler(this.squareroot_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.Gainsboro;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Location = new System.Drawing.Point(172, 176);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 43);
            this.square.TabIndex = 0;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.BackColor = System.Drawing.Color.Gainsboro;
            this.reciprocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reciprocal.Location = new System.Drawing.Point(253, 176);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(75, 43);
            this.reciprocal.TabIndex = 0;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = false;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(10, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(119, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 471);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.square);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.squareroot);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.negative);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator                              ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button squareroot;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.TextBox textBox2;
    }
}

