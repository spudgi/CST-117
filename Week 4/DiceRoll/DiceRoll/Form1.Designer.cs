namespace DiceRoll
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
            this.button1 = new System.Windows.Forms.Button();
            this.roll1 = new System.Windows.Forms.Label();
            this.roll2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 256);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roll1
            // 
            this.roll1.AutoSize = true;
            this.roll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll1.Location = new System.Drawing.Point(454, 180);
            this.roll1.Name = "roll1";
            this.roll1.Size = new System.Drawing.Size(59, 64);
            this.roll1.TabIndex = 1;
            this.roll1.Text = "0";
            this.roll1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roll2
            // 
            this.roll2.AutoSize = true;
            this.roll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll2.Location = new System.Drawing.Point(655, 180);
            this.roll2.Name = "roll2";
            this.roll2.Size = new System.Drawing.Size(59, 64);
            this.roll2.TabIndex = 2;
            this.roll2.Text = "0";
            this.roll2.Click += new System.EventHandler(this.roll2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roll2);
            this.Controls.Add(this.roll1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label roll1;
        private System.Windows.Forms.Label roll2;
    }
}

