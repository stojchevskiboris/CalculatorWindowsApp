namespace Calculator
{
    partial class Калкулатор
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Калкулатор));
            this.pow2 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.upLabel = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pow2
            // 
            this.pow2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pow2.Location = new System.Drawing.Point(35, 110);
            this.pow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(60, 60);
            this.pow2.TabIndex = 1;
            this.pow2.Text = "x²";
            this.pow2.UseVisualStyleBackColor = false;
            this.pow2.Click += new System.EventHandler(this.pow2_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(233, 110);
            this.mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(60, 60);
            this.mult.TabIndex = 2;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(167, 110);
            this.backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(60, 60);
            this.backspace.TabIndex = 3;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(233, 176);
            this.divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 60);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(167, 176);
            this.nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 60);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.buttonClick);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(101, 176);
            this.eight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 60);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.buttonClick);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(35, 176);
            this.seven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 60);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.buttonClick);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(233, 242);
            this.minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 60);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlLight;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(167, 242);
            this.six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 60);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.buttonClick);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLight;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(101, 242);
            this.five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 60);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.buttonClick);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLight;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(35, 242);
            this.four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 60);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.buttonClick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(233, 308);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.TabIndex = 18;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLight;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(167, 308);
            this.three.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 60);
            this.three.TabIndex = 17;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.buttonClick);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLight;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(101, 308);
            this.two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 60);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.buttonClick);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLight;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(35, 308);
            this.one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 60);
            this.one.TabIndex = 15;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.buttonClick);
            // 
            // eq
            // 
            this.eq.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq.Location = new System.Drawing.Point(233, 374);
            this.eq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(60, 60);
            this.eq.TabIndex = 23;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = false;
            this.eq.Click += new System.EventHandler(this.eq_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlLight;
            this.point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(167, 374);
            this.point.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(60, 60);
            this.point.TabIndex = 22;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.buttonClick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(35, 374);
            this.zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(125, 60);
            this.zero.TabIndex = 21;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.buttonClick);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(101, 110);
            this.multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 60);
            this.multiply.TabIndex = 24;
            this.multiply.Text = "C";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(35, 60);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(257, 45);
            this.textBox_Result.TabIndex = 25;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // upLabel
            // 
            this.upLabel.AutoSize = true;
            this.upLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.upLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLabel.Location = new System.Drawing.Point(32, 26);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(0, 25);
            this.upLabel.TabIndex = 26;
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy.Location = new System.Drawing.Point(298, 60);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(28, 45);
            this.copy.TabIndex = 27;
            this.copy.Text = "⧉";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // Калкулатор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 474);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.eq);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.pow2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Калкулатор";
            this.Text = "Калкулатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pow2;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Label upLabel;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button copy;
    }
}

