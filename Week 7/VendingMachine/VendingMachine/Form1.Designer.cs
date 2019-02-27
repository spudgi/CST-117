namespace VendingMachine
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
            this.payDayqty = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonInv = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDisp = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snickersQty = new System.Windows.Forms.TextBox();
            this.milkyWayqty = new System.Windows.Forms.TextBox();
            this.twixQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caleb\'s Candies";
            // 
            // payDayqty
            // 
            this.payDayqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDayqty.Location = new System.Drawing.Point(134, 142);
            this.payDayqty.Name = "payDayqty";
            this.payDayqty.Size = new System.Drawing.Size(181, 66);
            this.payDayqty.TabIndex = 1;
            this.payDayqty.TextChanged += new System.EventHandler(this.payDayqty_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(344, 142);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(170, 85);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "ADD ITEM";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonInv
            // 
            this.buttonInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInv.Location = new System.Drawing.Point(344, 264);
            this.buttonInv.Name = "buttonInv";
            this.buttonInv.Size = new System.Drawing.Size(170, 85);
            this.buttonInv.TabIndex = 12;
            this.buttonInv.Text = "INVENTORY";
            this.buttonInv.UseVisualStyleBackColor = true;
            this.buttonInv.Click += new System.EventHandler(this.buttonInv_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(344, 388);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(170, 85);
            this.buttonFind.TabIndex = 13;
            this.buttonFind.Text = "FIND ITEM";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonDisp
            // 
            this.buttonDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisp.Location = new System.Drawing.Point(61, 546);
            this.buttonDisp.Name = "buttonDisp";
            this.buttonDisp.Size = new System.Drawing.Size(435, 88);
            this.buttonDisp.TabIndex = 14;
            this.buttonDisp.Text = "DISPENSE ITEM";
            this.buttonDisp.UseVisualStyleBackColor = true;
            this.buttonDisp.Click += new System.EventHandler(this.buttonDisp_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VendingMachine.Properties.Resources.twix;
            this.pictureBox4.InitialImage = global::VendingMachine.Properties.Resources.twix;
            this.pictureBox4.Location = new System.Drawing.Point(12, 442);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VendingMachine.Properties.Resources.milkyway;
            this.pictureBox3.Location = new System.Drawing.Point(12, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendingMachine.Properties.Resources.snickers;
            this.pictureBox2.Location = new System.Drawing.Point(12, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendingMachine.Properties.Resources.payday;
            this.pictureBox1.Location = new System.Drawing.Point(12, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // snickersQty
            // 
            this.snickersQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snickersQty.Location = new System.Drawing.Point(134, 238);
            this.snickersQty.Name = "snickersQty";
            this.snickersQty.Size = new System.Drawing.Size(181, 66);
            this.snickersQty.TabIndex = 15;
            // 
            // milkyWayqty
            // 
            this.milkyWayqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkyWayqty.Location = new System.Drawing.Point(134, 340);
            this.milkyWayqty.Name = "milkyWayqty";
            this.milkyWayqty.Size = new System.Drawing.Size(181, 66);
            this.milkyWayqty.TabIndex = 16;
            // 
            // twixQty
            // 
            this.twixQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twixQty.Location = new System.Drawing.Point(134, 442);
            this.twixQty.Name = "twixQty";
            this.twixQty.Size = new System.Drawing.Size(181, 66);
            this.twixQty.TabIndex = 17;
            this.twixQty.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 655);
            this.Controls.Add(this.twixQty);
            this.Controls.Add(this.milkyWayqty);
            this.Controls.Add(this.snickersQty);
            this.Controls.Add(this.buttonDisp);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonInv);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.payDayqty);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payDayqty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInv;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDisp;
        private System.Windows.Forms.TextBox snickersQty;
        private System.Windows.Forms.TextBox milkyWayqty;
        private System.Windows.Forms.TextBox twixQty;
    }
}

