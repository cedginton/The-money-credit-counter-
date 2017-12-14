namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Coins = new System.Windows.Forms.GroupBox();
            this.PoundTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PenceTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button2Q = new System.Windows.Forms.Button();
            this.Button1Q = new System.Windows.Forms.Button();
            this.Button50P = new System.Windows.Forms.Button();
            this.Button20P = new System.Windows.Forms.Button();
            this.Button10P = new System.Windows.Forms.Button();
            this.Button5P = new System.Windows.Forms.Button();
            this.Button2P = new System.Windows.Forms.Button();
            this.Button1P = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Coins.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coins
            // 
            this.Coins.BackColor = System.Drawing.Color.White;
            this.Coins.Controls.Add(this.PoundTotal);
            this.Coins.Controls.Add(this.label4);
            this.Coins.Controls.Add(this.label3);
            this.Coins.Controls.Add(this.label2);
            this.Coins.Controls.Add(this.PenceTotal);
            this.Coins.Controls.Add(this.label1);
            this.Coins.Controls.Add(this.Button2Q);
            this.Coins.Controls.Add(this.Button1Q);
            this.Coins.Controls.Add(this.Button50P);
            this.Coins.Controls.Add(this.Button20P);
            this.Coins.Controls.Add(this.Button10P);
            this.Coins.Controls.Add(this.Button5P);
            this.Coins.Controls.Add(this.Button2P);
            this.Coins.Controls.Add(this.Button1P);
            this.Coins.Location = new System.Drawing.Point(12, 12);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(310, 563);
            this.Coins.TabIndex = 0;
            this.Coins.TabStop = false;
            this.Coins.Text = "Coins";
            this.Coins.Enter += new System.EventHandler(this.Coins_Enter);
            // 
            // PoundTotal
            // 
            this.PoundTotal.Location = new System.Drawing.Point(162, 478);
            this.PoundTotal.Name = "PoundTotal";
            this.PoundTotal.Size = new System.Drawing.Size(57, 20);
            this.PoundTotal.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(223, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "P";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(138, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "£";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(97, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "P";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PenceTotal
            // 
            this.PenceTotal.Location = new System.Drawing.Point(47, 478);
            this.PenceTotal.Name = "PenceTotal";
            this.PenceTotal.Size = new System.Drawing.Size(53, 20);
            this.PenceTotal.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button2Q
            // 
            this.Button2Q.BackColor = System.Drawing.Color.Transparent;
            this.Button2Q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2Q.BackgroundImage")));
            this.Button2Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2Q.Location = new System.Drawing.Point(179, 378);
            this.Button2Q.Name = "Button2Q";
            this.Button2Q.Size = new System.Drawing.Size(105, 94);
            this.Button2Q.TabIndex = 7;
            this.Button2Q.UseVisualStyleBackColor = false;
            // 
            // Button1Q
            // 
            this.Button1Q.BackColor = System.Drawing.Color.Transparent;
            this.Button1Q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1Q.BackgroundImage")));
            this.Button1Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1Q.Location = new System.Drawing.Point(179, 271);
            this.Button1Q.Name = "Button1Q";
            this.Button1Q.Size = new System.Drawing.Size(105, 99);
            this.Button1Q.TabIndex = 6;
            this.Button1Q.UseVisualStyleBackColor = false;
            this.Button1Q.Click += new System.EventHandler(this.button7_Click);
            // 
            // Button50P
            // 
            this.Button50P.BackColor = System.Drawing.Color.Transparent;
            this.Button50P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button50P.BackgroundImage")));
            this.Button50P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button50P.Location = new System.Drawing.Point(179, 149);
            this.Button50P.Name = "Button50P";
            this.Button50P.Size = new System.Drawing.Size(105, 107);
            this.Button50P.TabIndex = 5;
            this.Button50P.UseVisualStyleBackColor = false;
            this.Button50P.Click += new System.EventHandler(this.Button50P_Click);
            // 
            // Button20P
            // 
            this.Button20P.BackColor = System.Drawing.Color.Transparent;
            this.Button20P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button20P.BackgroundImage")));
            this.Button20P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button20P.Location = new System.Drawing.Point(179, 19);
            this.Button20P.Name = "Button20P";
            this.Button20P.Size = new System.Drawing.Size(105, 110);
            this.Button20P.TabIndex = 4;
            this.Button20P.UseVisualStyleBackColor = false;
            // 
            // Button10P
            // 
            this.Button10P.BackColor = System.Drawing.Color.Transparent;
            this.Button10P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button10P.BackgroundImage")));
            this.Button10P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button10P.Location = new System.Drawing.Point(6, 378);
            this.Button10P.Name = "Button10P";
            this.Button10P.Size = new System.Drawing.Size(105, 94);
            this.Button10P.TabIndex = 3;
            this.Button10P.UseVisualStyleBackColor = false;
            this.Button10P.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button5P
            // 
            this.Button5P.BackColor = System.Drawing.Color.Transparent;
            this.Button5P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5P.BackgroundImage")));
            this.Button5P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button5P.Location = new System.Drawing.Point(6, 271);
            this.Button5P.Name = "Button5P";
            this.Button5P.Size = new System.Drawing.Size(105, 101);
            this.Button5P.TabIndex = 2;
            this.Button5P.UseVisualStyleBackColor = false;
            // 
            // Button2P
            // 
            this.Button2P.BackColor = System.Drawing.Color.Transparent;
            this.Button2P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2P.BackgroundImage")));
            this.Button2P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2P.Location = new System.Drawing.Point(6, 147);
            this.Button2P.Name = "Button2P";
            this.Button2P.Size = new System.Drawing.Size(105, 110);
            this.Button2P.TabIndex = 1;
            this.Button2P.UseVisualStyleBackColor = false;
            // 
            // Button1P
            // 
            this.Button1P.BackColor = System.Drawing.Color.Transparent;
            this.Button1P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1P.BackgroundImage")));
            this.Button1P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1P.Location = new System.Drawing.Point(6, 19);
            this.Button1P.Name = "Button1P";
            this.Button1P.Size = new System.Drawing.Size(108, 110);
            this.Button1P.TabIndex = 0;
            this.Button1P.UseVisualStyleBackColor = false;
            this.Button1P.Click += new System.EventHandler(this.Button1P_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(469, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 511);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coins Entered";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(679, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Coins);
            this.Name = "Form1";
            this.Text = "Money Credit Counter V1.0";
            this.Coins.ResumeLayout(false);
            this.Coins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Coins;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Button2Q;
        private System.Windows.Forms.Button Button1Q;
        private System.Windows.Forms.Button Button50P;
        private System.Windows.Forms.Button Button20P;
        private System.Windows.Forms.Button Button10P;
        private System.Windows.Forms.Button Button5P;
        private System.Windows.Forms.Button Button2P;
        private System.Windows.Forms.Button Button1P;
        private System.Windows.Forms.TextBox PoundTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PenceTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

