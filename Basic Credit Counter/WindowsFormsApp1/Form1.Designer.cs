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
            this.Psign2 = new System.Windows.Forms.Label();
            this.poundsign = new System.Windows.Forms.Label();
            this.Psign = new System.Windows.Forms.Label();
            this.PenceTotal = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.Button2Q = new System.Windows.Forms.Button();
            this.Button1Q = new System.Windows.Forms.Button();
            this.Button50P = new System.Windows.Forms.Button();
            this.Button20P = new System.Windows.Forms.Button();
            this.Button10P = new System.Windows.Forms.Button();
            this.Button5P = new System.Windows.Forms.Button();
            this.Button2P = new System.Windows.Forms.Button();
            this.Button1P = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.coinsEbox = new System.Windows.Forms.GroupBox();
            this.q2X = new System.Windows.Forms.Label();
            this.p1X = new System.Windows.Forms.Label();
            this.p2X = new System.Windows.Forms.Label();
            this.p5X = new System.Windows.Forms.Label();
            this.p10X = new System.Windows.Forms.Label();
            this.p20X = new System.Windows.Forms.Label();
            this.p50X = new System.Windows.Forms.Label();
            this.q1X = new System.Windows.Forms.Label();
            this.p5_count = new System.Windows.Forms.Label();
            this.p10_count = new System.Windows.Forms.Label();
            this.p20_count = new System.Windows.Forms.Label();
            this.p50_count = new System.Windows.Forms.Label();
            this.q1_count = new System.Windows.Forms.Label();
            this.q2_count = new System.Windows.Forms.Label();
            this.p2_count = new System.Windows.Forms.Label();
            this.p1_count = new System.Windows.Forms.Label();
            this.q2image = new System.Windows.Forms.PictureBox();
            this.q1image = new System.Windows.Forms.PictureBox();
            this.p50image = new System.Windows.Forms.PictureBox();
            this.p20image = new System.Windows.Forms.PictureBox();
            this.p10image = new System.Windows.Forms.PictureBox();
            this.p5image = new System.Windows.Forms.PictureBox();
            this.p2image = new System.Windows.Forms.PictureBox();
            this.p1image = new System.Windows.Forms.PictureBox();
            this.creditsBox = new System.Windows.Forms.GroupBox();
            this.NOCtotal = new System.Windows.Forms.TextBox();
            this.NumberOfCredit = new System.Windows.Forms.Label();
            this.CostPerCredit = new System.Windows.Forms.Label();
            this.CPCtotal = new System.Windows.Forms.TextBox();
            this.Psign3 = new System.Windows.Forms.Label();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Coins.SuspendLayout();
            this.coinsEbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q2image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p50image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p20image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1image)).BeginInit();
            this.creditsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coins
            // 
            this.Coins.BackColor = System.Drawing.Color.White;
            this.Coins.Controls.Add(this.label1);
            this.Coins.Controls.Add(this.PoundTotal);
            this.Coins.Controls.Add(this.Psign2);
            this.Coins.Controls.Add(this.poundsign);
            this.Coins.Controls.Add(this.Psign);
            this.Coins.Controls.Add(this.PenceTotal);
            this.Coins.Controls.Add(this.Total);
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
            this.Coins.Size = new System.Drawing.Size(310, 513);
            this.Coins.TabIndex = 0;
            this.Coins.TabStop = false;
            this.Coins.Text = "Coins";
            this.Coins.Enter += new System.EventHandler(this.Coins_Enter);
            // 
            // PoundTotal
            // 
            this.PoundTotal.Location = new System.Drawing.Point(185, 484);
            this.PoundTotal.Name = "PoundTotal";
            this.PoundTotal.Size = new System.Drawing.Size(57, 20);
            this.PoundTotal.TabIndex = 12;
            // 
            // Psign2
            // 
            this.Psign2.Location = new System.Drawing.Point(243, 490);
            this.Psign2.Name = "Psign2";
            this.Psign2.Size = new System.Drawing.Size(35, 13);
            this.Psign2.TabIndex = 0;
            this.Psign2.Text = "P";
            // 
            // poundsign
            // 
            this.poundsign.Location = new System.Drawing.Point(169, 490);
            this.poundsign.Name = "poundsign";
            this.poundsign.Size = new System.Drawing.Size(22, 13);
            this.poundsign.TabIndex = 0;
            this.poundsign.Text = "£";
            // 
            // Psign
            // 
            this.Psign.Location = new System.Drawing.Point(100, 490);
            this.Psign.Name = "Psign";
            this.Psign.Size = new System.Drawing.Size(35, 13);
            this.Psign.TabIndex = 0;
            this.Psign.Text = "P";
            // 
            // PenceTotal
            // 
            this.PenceTotal.Location = new System.Drawing.Point(47, 484);
            this.PenceTotal.Name = "PenceTotal";
            this.PenceTotal.Size = new System.Drawing.Size(53, 20);
            this.PenceTotal.TabIndex = 9;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(6, 487);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(35, 13);
            this.Total.TabIndex = 0;
            this.Total.Text = "Total Value";
            // 
            // Button2Q
            // 
            this.Button2Q.BackColor = System.Drawing.Color.Transparent;
            this.Button2Q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2Q.BackgroundImage")));
            this.Button2Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2Q.Location = new System.Drawing.Point(182, 380);
            this.Button2Q.Name = "Button2Q";
            this.Button2Q.Size = new System.Drawing.Size(91, 94);
            this.Button2Q.TabIndex = 7;
            this.Button2Q.UseVisualStyleBackColor = false;
            this.Button2Q.Click += new System.EventHandler(this.Button2Q_Click);
            // 
            // Button1Q
            // 
            this.Button1Q.BackColor = System.Drawing.Color.Transparent;
            this.Button1Q.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1Q.BackgroundImage")));
            this.Button1Q.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1Q.Location = new System.Drawing.Point(182, 275);
            this.Button1Q.Name = "Button1Q";
            this.Button1Q.Size = new System.Drawing.Size(91, 92);
            this.Button1Q.TabIndex = 6;
            this.Button1Q.UseVisualStyleBackColor = false;
            this.Button1Q.Click += new System.EventHandler(this.Button1Q_Click);
            // 
            // Button50P
            // 
            this.Button50P.BackColor = System.Drawing.Color.Transparent;
            this.Button50P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button50P.BackgroundImage")));
            this.Button50P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button50P.Location = new System.Drawing.Point(185, 169);
            this.Button50P.Name = "Button50P";
            this.Button50P.Size = new System.Drawing.Size(88, 93);
            this.Button50P.TabIndex = 5;
            this.Button50P.UseVisualStyleBackColor = false;
            this.Button50P.Click += new System.EventHandler(this.Button50P_Click);
            // 
            // Button20P
            // 
            this.Button20P.BackColor = System.Drawing.Color.Transparent;
            this.Button20P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button20P.BackgroundImage")));
            this.Button20P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button20P.Location = new System.Drawing.Point(182, 55);
            this.Button20P.Name = "Button20P";
            this.Button20P.Size = new System.Drawing.Size(90, 93);
            this.Button20P.TabIndex = 4;
            this.Button20P.UseVisualStyleBackColor = false;
            this.Button20P.Click += new System.EventHandler(this.Button20P_Click);
            // 
            // Button10P
            // 
            this.Button10P.BackColor = System.Drawing.Color.Transparent;
            this.Button10P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button10P.BackgroundImage")));
            this.Button10P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button10P.Location = new System.Drawing.Point(17, 380);
            this.Button10P.Name = "Button10P";
            this.Button10P.Size = new System.Drawing.Size(91, 94);
            this.Button10P.TabIndex = 3;
            this.Button10P.UseVisualStyleBackColor = false;
            this.Button10P.Click += new System.EventHandler(this.Button10P_Click);
            // 
            // Button5P
            // 
            this.Button5P.BackColor = System.Drawing.Color.Transparent;
            this.Button5P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5P.BackgroundImage")));
            this.Button5P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button5P.Location = new System.Drawing.Point(17, 275);
            this.Button5P.Name = "Button5P";
            this.Button5P.Size = new System.Drawing.Size(91, 92);
            this.Button5P.TabIndex = 2;
            this.Button5P.UseVisualStyleBackColor = false;
            this.Button5P.Click += new System.EventHandler(this.Button5P_Click);
            // 
            // Button2P
            // 
            this.Button2P.BackColor = System.Drawing.Color.Transparent;
            this.Button2P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2P.BackgroundImage")));
            this.Button2P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button2P.Location = new System.Drawing.Point(17, 169);
            this.Button2P.Name = "Button2P";
            this.Button2P.Size = new System.Drawing.Size(91, 93);
            this.Button2P.TabIndex = 1;
            this.Button2P.UseVisualStyleBackColor = false;
            this.Button2P.Click += new System.EventHandler(this.Button2P_Click);
            // 
            // Button1P
            // 
            this.Button1P.BackColor = System.Drawing.Color.Transparent;
            this.Button1P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1P.BackgroundImage")));
            this.Button1P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button1P.Location = new System.Drawing.Point(6, 46);
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
            // coinsEbox
            // 
            this.coinsEbox.BackColor = System.Drawing.Color.White;
            this.coinsEbox.Controls.Add(this.q2X);
            this.coinsEbox.Controls.Add(this.p1X);
            this.coinsEbox.Controls.Add(this.p2X);
            this.coinsEbox.Controls.Add(this.p5X);
            this.coinsEbox.Controls.Add(this.p10X);
            this.coinsEbox.Controls.Add(this.p20X);
            this.coinsEbox.Controls.Add(this.p50X);
            this.coinsEbox.Controls.Add(this.q1X);
            this.coinsEbox.Controls.Add(this.p5_count);
            this.coinsEbox.Controls.Add(this.p10_count);
            this.coinsEbox.Controls.Add(this.p20_count);
            this.coinsEbox.Controls.Add(this.p50_count);
            this.coinsEbox.Controls.Add(this.q1_count);
            this.coinsEbox.Controls.Add(this.q2_count);
            this.coinsEbox.Controls.Add(this.p2_count);
            this.coinsEbox.Controls.Add(this.p1_count);
            this.coinsEbox.Controls.Add(this.q2image);
            this.coinsEbox.Controls.Add(this.q1image);
            this.coinsEbox.Controls.Add(this.p50image);
            this.coinsEbox.Controls.Add(this.p20image);
            this.coinsEbox.Controls.Add(this.p10image);
            this.coinsEbox.Controls.Add(this.p5image);
            this.coinsEbox.Controls.Add(this.p2image);
            this.coinsEbox.Controls.Add(this.p1image);
            this.coinsEbox.Location = new System.Drawing.Point(400, 12);
            this.coinsEbox.Name = "coinsEbox";
            this.coinsEbox.Size = new System.Drawing.Size(216, 640);
            this.coinsEbox.TabIndex = 1;
            this.coinsEbox.TabStop = false;
            this.coinsEbox.Text = "Coins Entered";
            // 
            // q2X
            // 
            this.q2X.AutoSize = true;
            this.q2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2X.Location = new System.Drawing.Point(78, 578);
            this.q2X.Name = "q2X";
            this.q2X.Size = new System.Drawing.Size(30, 29);
            this.q2X.TabIndex = 24;
            this.q2X.Text = "X";
            // 
            // p1X
            // 
            this.p1X.AutoSize = true;
            this.p1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1X.Location = new System.Drawing.Point(78, 43);
            this.p1X.Name = "p1X";
            this.p1X.Size = new System.Drawing.Size(30, 29);
            this.p1X.TabIndex = 23;
            this.p1X.Text = "X";
            // 
            // p2X
            // 
            this.p2X.AutoSize = true;
            this.p2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2X.Location = new System.Drawing.Point(78, 128);
            this.p2X.Name = "p2X";
            this.p2X.Size = new System.Drawing.Size(30, 29);
            this.p2X.TabIndex = 22;
            this.p2X.Text = "X";
            // 
            // p5X
            // 
            this.p5X.AutoSize = true;
            this.p5X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5X.Location = new System.Drawing.Point(78, 201);
            this.p5X.Name = "p5X";
            this.p5X.Size = new System.Drawing.Size(30, 29);
            this.p5X.TabIndex = 21;
            this.p5X.Text = "X";
            // 
            // p10X
            // 
            this.p10X.AutoSize = true;
            this.p10X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10X.Location = new System.Drawing.Point(78, 268);
            this.p10X.Name = "p10X";
            this.p10X.Size = new System.Drawing.Size(30, 29);
            this.p10X.TabIndex = 20;
            this.p10X.Text = "X";
            // 
            // p20X
            // 
            this.p20X.AutoSize = true;
            this.p20X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p20X.Location = new System.Drawing.Point(78, 340);
            this.p20X.Name = "p20X";
            this.p20X.Size = new System.Drawing.Size(30, 29);
            this.p20X.TabIndex = 19;
            this.p20X.Text = "X";
            // 
            // p50X
            // 
            this.p50X.AutoSize = true;
            this.p50X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p50X.Location = new System.Drawing.Point(78, 425);
            this.p50X.Name = "p50X";
            this.p50X.Size = new System.Drawing.Size(30, 29);
            this.p50X.TabIndex = 18;
            this.p50X.Text = "X";
            // 
            // q1X
            // 
            this.q1X.AutoSize = true;
            this.q1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1X.Location = new System.Drawing.Point(78, 505);
            this.q1X.Name = "q1X";
            this.q1X.Size = new System.Drawing.Size(30, 29);
            this.q1X.TabIndex = 17;
            this.q1X.Text = "X";
            // 
            // p5_count
            // 
            this.p5_count.AutoSize = true;
            this.p5_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5_count.Location = new System.Drawing.Point(6, 195);
            this.p5_count.Name = "p5_count";
            this.p5_count.Size = new System.Drawing.Size(35, 37);
            this.p5_count.TabIndex = 15;
            this.p5_count.Text = "0";
            // 
            // p10_count
            // 
            this.p10_count.AutoSize = true;
            this.p10_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10_count.Location = new System.Drawing.Point(6, 262);
            this.p10_count.Name = "p10_count";
            this.p10_count.Size = new System.Drawing.Size(35, 37);
            this.p10_count.TabIndex = 14;
            this.p10_count.Text = "0";
            // 
            // p20_count
            // 
            this.p20_count.AutoSize = true;
            this.p20_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p20_count.Location = new System.Drawing.Point(6, 334);
            this.p20_count.Name = "p20_count";
            this.p20_count.Size = new System.Drawing.Size(35, 37);
            this.p20_count.TabIndex = 13;
            this.p20_count.Text = "0";
            // 
            // p50_count
            // 
            this.p50_count.AutoSize = true;
            this.p50_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p50_count.Location = new System.Drawing.Point(6, 419);
            this.p50_count.Name = "p50_count";
            this.p50_count.Size = new System.Drawing.Size(35, 37);
            this.p50_count.TabIndex = 12;
            this.p50_count.Text = "0";
            // 
            // q1_count
            // 
            this.q1_count.AutoSize = true;
            this.q1_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_count.Location = new System.Drawing.Point(6, 500);
            this.q1_count.Name = "q1_count";
            this.q1_count.Size = new System.Drawing.Size(35, 37);
            this.q1_count.TabIndex = 11;
            this.q1_count.Text = "0";
            // 
            // q2_count
            // 
            this.q2_count.AutoSize = true;
            this.q2_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_count.Location = new System.Drawing.Point(6, 572);
            this.q2_count.Name = "q2_count";
            this.q2_count.Size = new System.Drawing.Size(35, 37);
            this.q2_count.TabIndex = 10;
            this.q2_count.Text = "0";
            // 
            // p2_count
            // 
            this.p2_count.AutoSize = true;
            this.p2_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_count.Location = new System.Drawing.Point(6, 122);
            this.p2_count.Name = "p2_count";
            this.p2_count.Size = new System.Drawing.Size(35, 37);
            this.p2_count.TabIndex = 9;
            this.p2_count.Text = "0";
            // 
            // p1_count
            // 
            this.p1_count.AutoSize = true;
            this.p1_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_count.Location = new System.Drawing.Point(6, 40);
            this.p1_count.Name = "p1_count";
            this.p1_count.Size = new System.Drawing.Size(35, 37);
            this.p1_count.TabIndex = 8;
            this.p1_count.Text = "0";
            // 
            // q2image
            // 
            this.q2image.BackColor = System.Drawing.Color.Transparent;
            this.q2image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2image.BackgroundImage")));
            this.q2image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2image.Location = new System.Drawing.Point(127, 560);
            this.q2image.Name = "q2image";
            this.q2image.Size = new System.Drawing.Size(79, 68);
            this.q2image.TabIndex = 7;
            this.q2image.TabStop = false;
            // 
            // q1image
            // 
            this.q1image.BackColor = System.Drawing.Color.Transparent;
            this.q1image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q1image.BackgroundImage")));
            this.q1image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q1image.Location = new System.Drawing.Point(127, 484);
            this.q1image.Name = "q1image";
            this.q1image.Size = new System.Drawing.Size(80, 69);
            this.q1image.TabIndex = 6;
            this.q1image.TabStop = false;
            // 
            // p50image
            // 
            this.p50image.BackColor = System.Drawing.Color.Transparent;
            this.p50image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p50image.BackgroundImage")));
            this.p50image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p50image.Location = new System.Drawing.Point(125, 406);
            this.p50image.Name = "p50image";
            this.p50image.Size = new System.Drawing.Size(83, 71);
            this.p50image.TabIndex = 5;
            this.p50image.TabStop = false;
            // 
            // p20image
            // 
            this.p20image.BackColor = System.Drawing.Color.Transparent;
            this.p20image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p20image.BackgroundImage")));
            this.p20image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p20image.Location = new System.Drawing.Point(125, 322);
            this.p20image.Name = "p20image";
            this.p20image.Size = new System.Drawing.Size(83, 78);
            this.p20image.TabIndex = 4;
            this.p20image.TabStop = false;
            // 
            // p10image
            // 
            this.p10image.BackColor = System.Drawing.Color.Transparent;
            this.p10image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10image.BackgroundImage")));
            this.p10image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p10image.Location = new System.Drawing.Point(127, 248);
            this.p10image.Name = "p10image";
            this.p10image.Size = new System.Drawing.Size(81, 68);
            this.p10image.TabIndex = 3;
            this.p10image.TabStop = false;
            // 
            // p5image
            // 
            this.p5image.Image = ((System.Drawing.Image)(resources.GetObject("p5image.Image")));
            this.p5image.Location = new System.Drawing.Point(125, 178);
            this.p5image.Name = "p5image";
            this.p5image.Size = new System.Drawing.Size(83, 64);
            this.p5image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p5image.TabIndex = 2;
            this.p5image.TabStop = false;
            // 
            // p2image
            // 
            this.p2image.Image = ((System.Drawing.Image)(resources.GetObject("p2image.Image")));
            this.p2image.Location = new System.Drawing.Point(125, 105);
            this.p2image.Name = "p2image";
            this.p2image.Size = new System.Drawing.Size(80, 67);
            this.p2image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2image.TabIndex = 1;
            this.p2image.TabStop = false;
            // 
            // p1image
            // 
            this.p1image.Image = ((System.Drawing.Image)(resources.GetObject("p1image.Image")));
            this.p1image.Location = new System.Drawing.Point(125, 9);
            this.p1image.Name = "p1image";
            this.p1image.Size = new System.Drawing.Size(80, 93);
            this.p1image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1image.TabIndex = 0;
            this.p1image.TabStop = false;
            this.p1image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // creditsBox
            // 
            this.creditsBox.Controls.Add(this.NOCtotal);
            this.creditsBox.Controls.Add(this.NumberOfCredit);
            this.creditsBox.Controls.Add(this.CostPerCredit);
            this.creditsBox.Controls.Add(this.CPCtotal);
            this.creditsBox.Controls.Add(this.Psign3);
            this.creditsBox.Location = new System.Drawing.Point(13, 531);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(308, 75);
            this.creditsBox.TabIndex = 2;
            this.creditsBox.TabStop = false;
            this.creditsBox.Text = "Credits";
            // 
            // NOCtotal
            // 
            this.NOCtotal.Location = new System.Drawing.Point(220, 44);
            this.NOCtotal.Name = "NOCtotal";
            this.NOCtotal.Size = new System.Drawing.Size(57, 20);
            this.NOCtotal.TabIndex = 15;
            // 
            // NumberOfCredit
            // 
            this.NumberOfCredit.AutoSize = true;
            this.NumberOfCredit.Location = new System.Drawing.Point(7, 47);
            this.NumberOfCredit.Name = "NumberOfCredit";
            this.NumberOfCredit.Size = new System.Drawing.Size(206, 13);
            this.NumberOfCredit.TabIndex = 14;
            this.NumberOfCredit.Text = "You Presently Have This Number of Credit";
            // 
            // CostPerCredit
            // 
            this.CostPerCredit.AutoSize = true;
            this.CostPerCredit.Location = new System.Drawing.Point(8, 19);
            this.CostPerCredit.Name = "CostPerCredit";
            this.CostPerCredit.Size = new System.Drawing.Size(158, 13);
            this.CostPerCredit.TabIndex = 13;
            this.CostPerCredit.Text = "Please Enter the Cost Per Credit";
            // 
            // CPCtotal
            // 
            this.CPCtotal.Location = new System.Drawing.Point(181, 16);
            this.CPCtotal.Name = "CPCtotal";
            this.CPCtotal.Size = new System.Drawing.Size(46, 20);
            this.CPCtotal.TabIndex = 12;
            this.CPCtotal.TextChanged += new System.EventHandler(this.CPCtotal_TextChanged);
            // 
            // Psign3
            // 
            this.Psign3.Location = new System.Drawing.Point(236, 19);
            this.Psign3.Name = "Psign3";
            this.Psign3.Size = new System.Drawing.Size(35, 13);
            this.Psign3.TabIndex = 11;
            this.Psign3.Text = "P";
            // 
            // Btn_reset
            // 
            this.Btn_reset.BackColor = System.Drawing.Color.Red;
            this.Btn_reset.Location = new System.Drawing.Point(29, 608);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(239, 42);
            this.Btn_reset.TabIndex = 3;
            this.Btn_reset.Text = "Reset";
            this.Btn_reset.UseVisualStyleBackColor = false;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Click a Coin To Buy Credits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(630, 653);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.coinsEbox);
            this.Controls.Add(this.Coins);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Credit Counter V2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Coins.ResumeLayout(false);
            this.Coins.PerformLayout();
            this.coinsEbox.ResumeLayout(false);
            this.coinsEbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q2image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p50image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p20image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1image)).EndInit();
            this.creditsBox.ResumeLayout(false);
            this.creditsBox.PerformLayout();
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
        private System.Windows.Forms.Label Psign2;
        private System.Windows.Forms.Label poundsign;
        private System.Windows.Forms.Label Psign;
        private System.Windows.Forms.TextBox PenceTotal;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.GroupBox coinsEbox;
        private System.Windows.Forms.PictureBox p5image;
        private System.Windows.Forms.PictureBox p2image;
        private System.Windows.Forms.PictureBox p1image;
        private System.Windows.Forms.GroupBox creditsBox;
        private System.Windows.Forms.TextBox NOCtotal;
        private System.Windows.Forms.Label NumberOfCredit;
        private System.Windows.Forms.Label CostPerCredit;
        private System.Windows.Forms.TextBox CPCtotal;
        private System.Windows.Forms.Label Psign3;
        private System.Windows.Forms.Label q2X;
        private System.Windows.Forms.Label p1X;
        private System.Windows.Forms.Label p2X;
        private System.Windows.Forms.Label p5X;
        private System.Windows.Forms.Label p10X;
        private System.Windows.Forms.Label p20X;
        private System.Windows.Forms.Label p50X;
        private System.Windows.Forms.Label q1X;
        private System.Windows.Forms.Label p5_count;
        private System.Windows.Forms.Label p10_count;
        private System.Windows.Forms.Label p20_count;
        private System.Windows.Forms.Label p50_count;
        private System.Windows.Forms.Label q1_count;
        private System.Windows.Forms.Label q2_count;
        private System.Windows.Forms.Label p2_count;
        private System.Windows.Forms.Label p1_count;
        private System.Windows.Forms.PictureBox q2image;
        private System.Windows.Forms.PictureBox q1image;
        private System.Windows.Forms.PictureBox p50image;
        private System.Windows.Forms.PictureBox p20image;
        private System.Windows.Forms.PictureBox p10image;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Label label1;
    }
}

