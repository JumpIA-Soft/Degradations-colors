
namespace color_interpolation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tittle = new System.Windows.Forms.Label();
            this.windowsPixel = new System.Windows.Forms.PictureBox();
            this.activeInterpolation = new System.Windows.Forms.Button();
            this.tittle2 = new System.Windows.Forms.Label();
            this.tbColorR1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColorG1 = new System.Windows.Forms.TextBox();
            this.tbColorB1 = new System.Windows.Forms.TextBox();
            this.tbColorB2 = new System.Windows.Forms.TextBox();
            this.tbColorG2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbColorR2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorSelections = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowsPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tittle.Location = new System.Drawing.Point(247, 9);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(195, 21);
            this.tittle.TabIndex = 0;
            this.tittle.Text = "Interpolacion de colores";
            // 
            // windowsPixel
            // 
            this.windowsPixel.Location = new System.Drawing.Point(156, 43);
            this.windowsPixel.Name = "windowsPixel";
            this.windowsPixel.Size = new System.Drawing.Size(700, 500);
            this.windowsPixel.TabIndex = 1;
            this.windowsPixel.TabStop = false;
            // 
            // activeInterpolation
            // 
            this.activeInterpolation.Location = new System.Drawing.Point(12, 64);
            this.activeInterpolation.Name = "activeInterpolation";
            this.activeInterpolation.Size = new System.Drawing.Size(75, 23);
            this.activeInterpolation.TabIndex = 2;
            this.activeInterpolation.Text = "Interpolar";
            this.activeInterpolation.UseVisualStyleBackColor = true;
            this.activeInterpolation.Click += new System.EventHandler(this.activeInterpolation_Click);
            // 
            // tittle2
            // 
            this.tittle2.AutoSize = true;
            this.tittle2.Location = new System.Drawing.Point(12, 167);
            this.tittle2.Name = "tittle2";
            this.tittle2.Size = new System.Drawing.Size(89, 15);
            this.tittle2.TabIndex = 3;
            this.tittle2.Text = "Color 1 en RGB ";
            // 
            // tbColorR1
            // 
            this.tbColorR1.Location = new System.Drawing.Point(23, 185);
            this.tbColorR1.Name = "tbColorR1";
            this.tbColorR1.Size = new System.Drawing.Size(23, 23);
            this.tbColorR1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(52, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(97, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "B";
            // 
            // tbColorG1
            // 
            this.tbColorG1.Location = new System.Drawing.Point(64, 185);
            this.tbColorG1.Name = "tbColorG1";
            this.tbColorG1.Size = new System.Drawing.Size(23, 23);
            this.tbColorG1.TabIndex = 11;
            // 
            // tbColorB1
            // 
            this.tbColorB1.Location = new System.Drawing.Point(108, 185);
            this.tbColorB1.Name = "tbColorB1";
            this.tbColorB1.Size = new System.Drawing.Size(23, 23);
            this.tbColorB1.TabIndex = 12;
            // 
            // tbColorB2
            // 
            this.tbColorB2.Location = new System.Drawing.Point(108, 252);
            this.tbColorB2.Name = "tbColorB2";
            this.tbColorB2.Size = new System.Drawing.Size(23, 23);
            this.tbColorB2.TabIndex = 19;
            // 
            // tbColorG2
            // 
            this.tbColorG2.Location = new System.Drawing.Point(64, 252);
            this.tbColorG2.Name = "tbColorG2";
            this.tbColorG2.Size = new System.Drawing.Size(23, 23);
            this.tbColorG2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(52, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(9, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "R";
            // 
            // tbColorR2
            // 
            this.tbColorR2.Location = new System.Drawing.Point(23, 252);
            this.tbColorR2.Name = "tbColorR2";
            this.tbColorR2.Size = new System.Drawing.Size(23, 23);
            this.tbColorR2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color 2 en RGB ";
            // 
            // colorSelections
            // 
            this.colorSelections.Location = new System.Drawing.Point(12, 281);
            this.colorSelections.Name = "colorSelections";
            this.colorSelections.Size = new System.Drawing.Size(99, 23);
            this.colorSelections.TabIndex = 20;
            this.colorSelections.Text = "Marcar colores";
            this.colorSelections.UseVisualStyleBackColor = true;
            this.colorSelections.Click += new System.EventHandler(this.colorSelections_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 581);
            this.Controls.Add(this.colorSelections);
            this.Controls.Add(this.tbColorB2);
            this.Controls.Add(this.tbColorG2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbColorR2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbColorB1);
            this.Controls.Add(this.tbColorG1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbColorR1);
            this.Controls.Add(this.tittle2);
            this.Controls.Add(this.activeInterpolation);
            this.Controls.Add(this.windowsPixel);
            this.Controls.Add(this.tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.windowsPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.PictureBox windowsPixel;
        private System.Windows.Forms.Button activeInterpolation;
        private System.Windows.Forms.Label tittle2;
        private System.Windows.Forms.TextBox tbColorR1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbColorG1;
        private System.Windows.Forms.TextBox tbColorB1;
        private System.Windows.Forms.TextBox tbColorB2;
        private System.Windows.Forms.TextBox tbColorG2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbColorR2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorSelections;
    }
}

