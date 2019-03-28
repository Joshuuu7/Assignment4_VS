namespace FloresOlderr_Assignment4
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
            this.Playing_Field = new System.Windows.Forms.PictureBox();
            this.LineLabel = new System.Windows.Forms.Label();
            this.LineYLabel = new System.Windows.Forms.Label();
            this.LineMTextBox = new System.Windows.Forms.TextBox();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.LineBTextBox = new System.Windows.Forms.TextBox();
            this.QuadraticLabel = new System.Windows.Forms.Label();
            this.CalculateEquationsBtn = new System.Windows.Forms.Button();
            this.QuadraticATextBox = new System.Windows.Forms.TextBox();
            this.QuadraticCTextBox = new System.Windows.Forms.TextBox();
            this.QuadraticBTextBox = new System.Windows.Forms.TextBox();
            this.CubicLabel = new System.Windows.Forms.Label();
            this.CubicATextBox = new System.Windows.Forms.TextBox();
            this.CubicDTextBox = new System.Windows.Forms.TextBox();
            this.CubicCTextBox = new System.Windows.Forms.TextBox();
            this.CubicBTextBox = new System.Windows.Forms.TextBox();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.QuadraticYLabel = new System.Windows.Forms.Label();
            this.QuadraticXSquaredLabel = new System.Windows.Forms.Label();
            this.QuadraticXLabel = new System.Windows.Forms.Label();
            this.QuadraticPlayingField = new System.Windows.Forms.PictureBox();
            this.CubicPlayingField = new System.Windows.Forms.PictureBox();
            this.CirclePlayingField = new System.Windows.Forms.PictureBox();
            this.CubicX3Label = new System.Windows.Forms.Label();
            this.CubicXLabel = new System.Windows.Forms.Label();
            this.CubicX2Label = new System.Windows.Forms.Label();
            this.CubicYLabel = new System.Windows.Forms.Label();
            this.KCircleTextBox = new System.Windows.Forms.TextBox();
            this.HCircleTextBox = new System.Windows.Forms.TextBox();
            this.CircleXMinusLabel = new System.Windows.Forms.Label();
            this.CircleYMinusLabel = new System.Windows.Forms.Label();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.RCircleTextBox = new System.Windows.Forms.TextBox();
            this.CircleR2Label = new System.Windows.Forms.Label();
            this.LineContainerLabel = new System.Windows.Forms.Label();
            this.CircleContainerLabel = new System.Windows.Forms.Label();
            this.CubicContainerLabel = new System.Windows.Forms.Label();
            this.QuadraticContainerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Playing_Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuadraticPlayingField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CubicPlayingField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePlayingField)).BeginInit();
            this.SuspendLayout();
            // 
            // Playing_Field
            // 
            this.Playing_Field.BackColor = System.Drawing.Color.Black;
            this.Playing_Field.Location = new System.Drawing.Point(12, 12);
            this.Playing_Field.Name = "Playing_Field";
            this.Playing_Field.Size = new System.Drawing.Size(300, 300);
            this.Playing_Field.TabIndex = 0;
            this.Playing_Field.TabStop = false;
            this.Playing_Field.Click += new System.EventHandler(this.Playing_Field_Click);
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineLabel.Location = new System.Drawing.Point(657, 53);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(93, 13);
            this.LineLabel.TabIndex = 1;
            this.LineLabel.Text = "Line: y= mx + b";
            // 
            // LineYLabel
            // 
            this.LineYLabel.AutoSize = true;
            this.LineYLabel.Location = new System.Drawing.Point(657, 71);
            this.LineYLabel.Name = "LineYLabel";
            this.LineYLabel.Size = new System.Drawing.Size(24, 13);
            this.LineYLabel.TabIndex = 2;
            this.LineYLabel.Text = "y = ";
            // 
            // LineMTextBox
            // 
            this.LineMTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LineMTextBox.Location = new System.Drawing.Point(682, 69);
            this.LineMTextBox.Name = "LineMTextBox";
            this.LineMTextBox.Size = new System.Drawing.Size(52, 20);
            this.LineMTextBox.TabIndex = 1;
            this.LineMTextBox.Text = "1";
            this.LineMTextBox.Enter += new System.EventHandler(this.LineMTextBox_Enter);
            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Location = new System.Drawing.Point(748, 72);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(21, 13);
            this.PlusLabel.TabIndex = 4;
            this.PlusLabel.Text = "x +";
            // 
            // LineBTextBox
            // 
            this.LineBTextBox.Location = new System.Drawing.Point(775, 71);
            this.LineBTextBox.Name = "LineBTextBox";
            this.LineBTextBox.Size = new System.Drawing.Size(52, 20);
            this.LineBTextBox.TabIndex = 2;
            // 
            // QuadraticLabel
            // 
            this.QuadraticLabel.AutoSize = true;
            this.QuadraticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuadraticLabel.Location = new System.Drawing.Point(657, 110);
            this.QuadraticLabel.Name = "QuadraticLabel";
            this.QuadraticLabel.Size = new System.Drawing.Size(154, 13);
            this.QuadraticLabel.TabIndex = 6;
            this.QuadraticLabel.Text = "Quadratic: y = x2 + bx = c";
            // 
            // CalculateEquationsBtn
            // 
            this.CalculateEquationsBtn.Location = new System.Drawing.Point(881, 380);
            this.CalculateEquationsBtn.Name = "CalculateEquationsBtn";
            this.CalculateEquationsBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateEquationsBtn.TabIndex = 7;
            this.CalculateEquationsBtn.Text = "Calculate";
            this.CalculateEquationsBtn.UseVisualStyleBackColor = true;
            this.CalculateEquationsBtn.Click += new System.EventHandler(this.CalculateEquationsBtn_Click);
            // 
            // QuadraticATextBox
            // 
            this.QuadraticATextBox.Location = new System.Drawing.Point(682, 143);
            this.QuadraticATextBox.Name = "QuadraticATextBox";
            this.QuadraticATextBox.Size = new System.Drawing.Size(52, 20);
            this.QuadraticATextBox.TabIndex = 3;
            // 
            // QuadraticCTextBox
            // 
            this.QuadraticCTextBox.Location = new System.Drawing.Point(881, 143);
            this.QuadraticCTextBox.Name = "QuadraticCTextBox";
            this.QuadraticCTextBox.Size = new System.Drawing.Size(52, 20);
            this.QuadraticCTextBox.TabIndex = 5;
            // 
            // QuadraticBTextBox
            // 
            this.QuadraticBTextBox.Location = new System.Drawing.Point(775, 143);
            this.QuadraticBTextBox.Name = "QuadraticBTextBox";
            this.QuadraticBTextBox.Size = new System.Drawing.Size(52, 20);
            this.QuadraticBTextBox.TabIndex = 4;
            // 
            // CubicLabel
            // 
            this.CubicLabel.AutoSize = true;
            this.CubicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CubicLabel.Location = new System.Drawing.Point(657, 177);
            this.CubicLabel.Name = "CubicLabel";
            this.CubicLabel.Size = new System.Drawing.Size(173, 13);
            this.CubicLabel.TabIndex = 11;
            this.CubicLabel.Text = "Cubic: y = ax3 + bx2 + cx + d";
            // 
            // CubicATextBox
            // 
            this.CubicATextBox.Location = new System.Drawing.Point(682, 214);
            this.CubicATextBox.Name = "CubicATextBox";
            this.CubicATextBox.Size = new System.Drawing.Size(52, 20);
            this.CubicATextBox.TabIndex = 6;
            // 
            // CubicDTextBox
            // 
            this.CubicDTextBox.Location = new System.Drawing.Point(980, 213);
            this.CubicDTextBox.Name = "CubicDTextBox";
            this.CubicDTextBox.Size = new System.Drawing.Size(52, 20);
            this.CubicDTextBox.TabIndex = 9;
            // 
            // CubicCTextBox
            // 
            this.CubicCTextBox.Location = new System.Drawing.Point(881, 213);
            this.CubicCTextBox.Name = "CubicCTextBox";
            this.CubicCTextBox.Size = new System.Drawing.Size(52, 20);
            this.CubicCTextBox.TabIndex = 8;
            // 
            // CubicBTextBox
            // 
            this.CubicBTextBox.Location = new System.Drawing.Point(775, 214);
            this.CubicBTextBox.Name = "CubicBTextBox";
            this.CubicBTextBox.Size = new System.Drawing.Size(52, 20);
            this.CubicBTextBox.TabIndex = 7;
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleLabel.Location = new System.Drawing.Point(657, 250);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(192, 13);
            this.CircleLabel.TabIndex = 16;
            this.CircleLabel.Text = "Circle: (( x- h )2 + ( y - k )2 = r2 )";
            // 
            // QuadraticYLabel
            // 
            this.QuadraticYLabel.AutoSize = true;
            this.QuadraticYLabel.Location = new System.Drawing.Point(657, 146);
            this.QuadraticYLabel.Name = "QuadraticYLabel";
            this.QuadraticYLabel.Size = new System.Drawing.Size(24, 13);
            this.QuadraticYLabel.TabIndex = 17;
            this.QuadraticYLabel.Text = "y = ";
            // 
            // QuadraticXSquaredLabel
            // 
            this.QuadraticXSquaredLabel.AutoSize = true;
            this.QuadraticXSquaredLabel.Location = new System.Drawing.Point(742, 149);
            this.QuadraticXSquaredLabel.Name = "QuadraticXSquaredLabel";
            this.QuadraticXSquaredLabel.Size = new System.Drawing.Size(27, 13);
            this.QuadraticXSquaredLabel.TabIndex = 18;
            this.QuadraticXSquaredLabel.Text = "x2 +";
            // 
            // QuadraticXLabel
            // 
            this.QuadraticXLabel.AutoSize = true;
            this.QuadraticXLabel.Location = new System.Drawing.Point(851, 146);
            this.QuadraticXLabel.Name = "QuadraticXLabel";
            this.QuadraticXLabel.Size = new System.Drawing.Size(21, 13);
            this.QuadraticXLabel.TabIndex = 19;
            this.QuadraticXLabel.Text = "x +";
            // 
            // QuadraticPlayingField
            // 
            this.QuadraticPlayingField.BackColor = System.Drawing.Color.Black;
            this.QuadraticPlayingField.Location = new System.Drawing.Point(318, 12);
            this.QuadraticPlayingField.Name = "QuadraticPlayingField";
            this.QuadraticPlayingField.Size = new System.Drawing.Size(300, 300);
            this.QuadraticPlayingField.TabIndex = 20;
            this.QuadraticPlayingField.TabStop = false;
            this.QuadraticPlayingField.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CubicPlayingField
            // 
            this.CubicPlayingField.BackColor = System.Drawing.Color.Black;
            this.CubicPlayingField.Location = new System.Drawing.Point(12, 318);
            this.CubicPlayingField.Name = "CubicPlayingField";
            this.CubicPlayingField.Size = new System.Drawing.Size(300, 300);
            this.CubicPlayingField.TabIndex = 21;
            this.CubicPlayingField.TabStop = false;
            // 
            // CirclePlayingField
            // 
            this.CirclePlayingField.BackColor = System.Drawing.Color.Black;
            this.CirclePlayingField.Location = new System.Drawing.Point(318, 318);
            this.CirclePlayingField.Name = "CirclePlayingField";
            this.CirclePlayingField.Size = new System.Drawing.Size(300, 300);
            this.CirclePlayingField.TabIndex = 22;
            this.CirclePlayingField.TabStop = false;
            // 
            // CubicX3Label
            // 
            this.CubicX3Label.AutoSize = true;
            this.CubicX3Label.Location = new System.Drawing.Point(742, 220);
            this.CubicX3Label.Name = "CubicX3Label";
            this.CubicX3Label.Size = new System.Drawing.Size(27, 13);
            this.CubicX3Label.TabIndex = 23;
            this.CubicX3Label.Text = "x3 +";
            // 
            // CubicXLabel
            // 
            this.CubicXLabel.AutoSize = true;
            this.CubicXLabel.Location = new System.Drawing.Point(939, 217);
            this.CubicXLabel.Name = "CubicXLabel";
            this.CubicXLabel.Size = new System.Drawing.Size(21, 13);
            this.CubicXLabel.TabIndex = 24;
            this.CubicXLabel.Text = "x +";
            // 
            // CubicX2Label
            // 
            this.CubicX2Label.AutoSize = true;
            this.CubicX2Label.Location = new System.Drawing.Point(845, 220);
            this.CubicX2Label.Name = "CubicX2Label";
            this.CubicX2Label.Size = new System.Drawing.Size(27, 13);
            this.CubicX2Label.TabIndex = 25;
            this.CubicX2Label.Text = "x2 +";
            // 
            // CubicYLabel
            // 
            this.CubicYLabel.AutoSize = true;
            this.CubicYLabel.Location = new System.Drawing.Point(657, 217);
            this.CubicYLabel.Name = "CubicYLabel";
            this.CubicYLabel.Size = new System.Drawing.Size(24, 13);
            this.CubicYLabel.TabIndex = 26;
            this.CubicYLabel.Text = "y = ";
            // 
            // KCircleTextBox
            // 
            this.KCircleTextBox.Location = new System.Drawing.Point(791, 288);
            this.KCircleTextBox.Name = "KCircleTextBox";
            this.KCircleTextBox.Size = new System.Drawing.Size(52, 20);
            this.KCircleTextBox.TabIndex = 11;
            // 
            // HCircleTextBox
            // 
            this.HCircleTextBox.Location = new System.Drawing.Point(682, 288);
            this.HCircleTextBox.Name = "HCircleTextBox";
            this.HCircleTextBox.Size = new System.Drawing.Size(52, 20);
            this.HCircleTextBox.TabIndex = 10;
            this.HCircleTextBox.TextChanged += new System.EventHandler(this.HCircleTextBox_TextChanged);
            // 
            // CircleXMinusLabel
            // 
            this.CircleXMinusLabel.AutoSize = true;
            this.CircleXMinusLabel.Location = new System.Drawing.Point(648, 291);
            this.CircleXMinusLabel.Name = "CircleXMinusLabel";
            this.CircleXMinusLabel.Size = new System.Drawing.Size(33, 13);
            this.CircleXMinusLabel.TabIndex = 29;
            this.CircleXMinusLabel.Text = "( ( x - ";
            // 
            // CircleYMinusLabel
            // 
            this.CircleYMinusLabel.AutoSize = true;
            this.CircleYMinusLabel.Location = new System.Drawing.Point(740, 292);
            this.CircleYMinusLabel.Name = "CircleYMinusLabel";
            this.CircleYMinusLabel.Size = new System.Drawing.Size(45, 13);
            this.CircleYMinusLabel.TabIndex = 30;
            this.CircleYMinusLabel.Text = ")2 + ( y -";
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Location = new System.Drawing.Point(849, 292);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(28, 13);
            this.EqualsLabel.TabIndex = 31;
            this.EqualsLabel.Text = ")2 = ";
            // 
            // RCircleTextBox
            // 
            this.RCircleTextBox.Location = new System.Drawing.Point(881, 288);
            this.RCircleTextBox.Name = "RCircleTextBox";
            this.RCircleTextBox.Size = new System.Drawing.Size(52, 20);
            this.RCircleTextBox.TabIndex = 12;
            // 
            // CircleR2Label
            // 
            this.CircleR2Label.AutoSize = true;
            this.CircleR2Label.Location = new System.Drawing.Point(939, 292);
            this.CircleR2Label.Name = "CircleR2Label";
            this.CircleR2Label.Size = new System.Drawing.Size(19, 13);
            this.CircleR2Label.TabIndex = 33;
            this.CircleR2Label.Text = "2 )";
            // 
            // LineContainerLabel
            // 
            this.LineContainerLabel.AutoSize = true;
            this.LineContainerLabel.Location = new System.Drawing.Point(12, 12);
            this.LineContainerLabel.Name = "LineContainerLabel";
            this.LineContainerLabel.Size = new System.Drawing.Size(27, 13);
            this.LineContainerLabel.TabIndex = 34;
            this.LineContainerLabel.Text = "Line";
            // 
            // CircleContainerLabel
            // 
            this.CircleContainerLabel.AutoSize = true;
            this.CircleContainerLabel.Location = new System.Drawing.Point(318, 318);
            this.CircleContainerLabel.Name = "CircleContainerLabel";
            this.CircleContainerLabel.Size = new System.Drawing.Size(33, 13);
            this.CircleContainerLabel.TabIndex = 35;
            this.CircleContainerLabel.Text = "Circle";
            // 
            // CubicContainerLabel
            // 
            this.CubicContainerLabel.AutoSize = true;
            this.CubicContainerLabel.Location = new System.Drawing.Point(12, 318);
            this.CubicContainerLabel.Name = "CubicContainerLabel";
            this.CubicContainerLabel.Size = new System.Drawing.Size(34, 13);
            this.CubicContainerLabel.TabIndex = 36;
            this.CubicContainerLabel.Text = "Cubic";
            // 
            // QuadraticContainerLabel
            // 
            this.QuadraticContainerLabel.AutoSize = true;
            this.QuadraticContainerLabel.Location = new System.Drawing.Point(318, 12);
            this.QuadraticContainerLabel.Name = "QuadraticContainerLabel";
            this.QuadraticContainerLabel.Size = new System.Drawing.Size(53, 13);
            this.QuadraticContainerLabel.TabIndex = 37;
            this.QuadraticContainerLabel.Text = "Quadratic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 633);
            this.Controls.Add(this.QuadraticContainerLabel);
            this.Controls.Add(this.CubicContainerLabel);
            this.Controls.Add(this.CircleContainerLabel);
            this.Controls.Add(this.LineContainerLabel);
            this.Controls.Add(this.CircleR2Label);
            this.Controls.Add(this.RCircleTextBox);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.CircleYMinusLabel);
            this.Controls.Add(this.CircleXMinusLabel);
            this.Controls.Add(this.HCircleTextBox);
            this.Controls.Add(this.KCircleTextBox);
            this.Controls.Add(this.CubicYLabel);
            this.Controls.Add(this.CubicX2Label);
            this.Controls.Add(this.CubicXLabel);
            this.Controls.Add(this.CubicX3Label);
            this.Controls.Add(this.CirclePlayingField);
            this.Controls.Add(this.CubicPlayingField);
            this.Controls.Add(this.QuadraticPlayingField);
            this.Controls.Add(this.QuadraticXLabel);
            this.Controls.Add(this.QuadraticXSquaredLabel);
            this.Controls.Add(this.QuadraticYLabel);
            this.Controls.Add(this.CircleLabel);
            this.Controls.Add(this.CubicBTextBox);
            this.Controls.Add(this.CubicCTextBox);
            this.Controls.Add(this.CubicDTextBox);
            this.Controls.Add(this.CubicATextBox);
            this.Controls.Add(this.CubicLabel);
            this.Controls.Add(this.QuadraticBTextBox);
            this.Controls.Add(this.QuadraticCTextBox);
            this.Controls.Add(this.QuadraticATextBox);
            this.Controls.Add(this.CalculateEquationsBtn);
            this.Controls.Add(this.QuadraticLabel);
            this.Controls.Add(this.LineBTextBox);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.LineMTextBox);
            this.Controls.Add(this.LineYLabel);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.Playing_Field);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Playing_Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuadraticPlayingField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CubicPlayingField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePlayingField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Playing_Field;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.Label LineYLabel;
        private System.Windows.Forms.TextBox LineMTextBox;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.TextBox LineBTextBox;
        private System.Windows.Forms.Label QuadraticLabel;
        private System.Windows.Forms.Button CalculateEquationsBtn;
        private System.Windows.Forms.TextBox QuadraticATextBox;
        private System.Windows.Forms.TextBox QuadraticCTextBox;
        private System.Windows.Forms.TextBox QuadraticBTextBox;
        private System.Windows.Forms.Label CubicLabel;
        private System.Windows.Forms.TextBox CubicATextBox;
        private System.Windows.Forms.TextBox CubicDTextBox;
        private System.Windows.Forms.TextBox CubicCTextBox;
        private System.Windows.Forms.TextBox CubicBTextBox;
        private System.Windows.Forms.Label CircleLabel;
        private System.Windows.Forms.Label QuadraticYLabel;
        private System.Windows.Forms.Label QuadraticXSquaredLabel;
        private System.Windows.Forms.Label QuadraticXLabel;
        private System.Windows.Forms.PictureBox QuadraticPlayingField;
        private System.Windows.Forms.PictureBox CubicPlayingField;
        private System.Windows.Forms.PictureBox CirclePlayingField;
        private System.Windows.Forms.Label CubicX3Label;
        private System.Windows.Forms.Label CubicXLabel;
        private System.Windows.Forms.Label CubicX2Label;
        private System.Windows.Forms.Label CubicYLabel;
        private System.Windows.Forms.TextBox KCircleTextBox;
        private System.Windows.Forms.TextBox HCircleTextBox;
        private System.Windows.Forms.Label CircleXMinusLabel;
        private System.Windows.Forms.Label CircleYMinusLabel;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.TextBox RCircleTextBox;
        private System.Windows.Forms.Label CircleR2Label;
        private System.Windows.Forms.Label LineContainerLabel;
        private System.Windows.Forms.Label CircleContainerLabel;
        private System.Windows.Forms.Label CubicContainerLabel;
        private System.Windows.Forms.Label QuadraticContainerLabel;
    }
}

