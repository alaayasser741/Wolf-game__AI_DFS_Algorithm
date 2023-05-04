
namespace WindowsFormsApp1
{
    partial class game
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
            this.side2 = new System.Windows.Forms.PictureBox();
            this.side1 = new System.Windows.Forms.PictureBox();
            this.water = new System.Windows.Forms.PictureBox();
            this.ship_move = new System.Windows.Forms.PictureBox();
            this.cab_move = new System.Windows.Forms.PictureBox();
            this.goat_move = new System.Windows.Forms.PictureBox();
            this.wolf_move = new System.Windows.Forms.PictureBox();
            this.wolf = new System.Windows.Forms.PictureBox();
            this.goat = new System.Windows.Forms.PictureBox();
            this.cabbage = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.farmer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SolveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.side2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.side1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cab_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmer)).BeginInit();
            this.SuspendLayout();
            // 
            // side2
            // 
            this.side2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___4_;
            this.side2.Location = new System.Drawing.Point(-6, 575);
            this.side2.Margin = new System.Windows.Forms.Padding(4);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(321, 161);
            this.side2.TabIndex = 0;
            this.side2.TabStop = false;
            // 
            // side1
            // 
            this.side1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___4_;
            this.side1.Location = new System.Drawing.Point(1035, 575);
            this.side1.Margin = new System.Windows.Forms.Padding(4);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(321, 161);
            this.side1.TabIndex = 1;
            this.side1.TabStop = false;
            this.side1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // water
            // 
            this.water.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___6_1;
            this.water.Image = global::WindowsFormsApp1.Properties.Resources.water;
            this.water.Location = new System.Drawing.Point(315, 612);
            this.water.Margin = new System.Windows.Forms.Padding(4);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(720, 124);
            this.water.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.water.TabIndex = 3;
            this.water.TabStop = false;
            // 
            // ship_move
            // 
            this.ship_move.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___7_;
            this.ship_move.Location = new System.Drawing.Point(489, 0);
            this.ship_move.Margin = new System.Windows.Forms.Padding(4);
            this.ship_move.Name = "ship_move";
            this.ship_move.Size = new System.Drawing.Size(104, 127);
            this.ship_move.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship_move.TabIndex = 4;
            this.ship_move.TabStop = false;
            this.ship_move.Click += new System.EventHandler(this.ship_move_Click);
            // 
            // cab_move
            // 
            this.cab_move.BackColor = System.Drawing.Color.Transparent;
            this.cab_move.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___8_;
            this.cab_move.Location = new System.Drawing.Point(593, 0);
            this.cab_move.Margin = new System.Windows.Forms.Padding(4);
            this.cab_move.Name = "cab_move";
            this.cab_move.Size = new System.Drawing.Size(88, 127);
            this.cab_move.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cab_move.TabIndex = 5;
            this.cab_move.TabStop = false;
            this.cab_move.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // goat_move
            // 
            this.goat_move.BackColor = System.Drawing.Color.Transparent;
            this.goat_move.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___9_2;
            this.goat_move.Image = global::WindowsFormsApp1.Properties.Resources.AI___9_;
            this.goat_move.Location = new System.Drawing.Point(680, 0);
            this.goat_move.Margin = new System.Windows.Forms.Padding(4);
            this.goat_move.Name = "goat_move";
            this.goat_move.Size = new System.Drawing.Size(80, 127);
            this.goat_move.TabIndex = 6;
            this.goat_move.TabStop = false;
            this.goat_move.Click += new System.EventHandler(this.goat_move_Click);
            // 
            // wolf_move
            // 
            this.wolf_move.BackColor = System.Drawing.Color.Transparent;
            this.wolf_move.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___9_2;
            this.wolf_move.Image = global::WindowsFormsApp1.Properties.Resources.AI___10_;
            this.wolf_move.Location = new System.Drawing.Point(760, 0);
            this.wolf_move.Margin = new System.Windows.Forms.Padding(4);
            this.wolf_move.Name = "wolf_move";
            this.wolf_move.Size = new System.Drawing.Size(85, 127);
            this.wolf_move.TabIndex = 7;
            this.wolf_move.TabStop = false;
            this.wolf_move.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // wolf
            // 
            this.wolf.BackColor = System.Drawing.Color.Transparent;
            this.wolf.Image = global::WindowsFormsApp1.Properties.Resources.Wolf;
            this.wolf.Location = new System.Drawing.Point(1253, 513);
            this.wolf.Margin = new System.Windows.Forms.Padding(4);
            this.wolf.Name = "wolf";
            this.wolf.Size = new System.Drawing.Size(86, 62);
            this.wolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wolf.TabIndex = 8;
            this.wolf.TabStop = false;
            this.wolf.Click += new System.EventHandler(this.wolf_Click);
            // 
            // goat
            // 
            this.goat.BackColor = System.Drawing.Color.Transparent;
            this.goat.Image = global::WindowsFormsApp1.Properties.Resources.Goat__1_;
            this.goat.Location = new System.Drawing.Point(1160, 513);
            this.goat.Margin = new System.Windows.Forms.Padding(4);
            this.goat.Name = "goat";
            this.goat.Size = new System.Drawing.Size(86, 62);
            this.goat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goat.TabIndex = 9;
            this.goat.TabStop = false;
            this.goat.Click += new System.EventHandler(this.goat_Click);
            // 
            // cabbage
            // 
            this.cabbage.BackColor = System.Drawing.Color.Transparent;
            this.cabbage.Image = global::WindowsFormsApp1.Properties.Resources.Carrot;
            this.cabbage.Location = new System.Drawing.Point(1096, 528);
            this.cabbage.Margin = new System.Windows.Forms.Padding(4);
            this.cabbage.Name = "cabbage";
            this.cabbage.Size = new System.Drawing.Size(57, 47);
            this.cabbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cabbage.TabIndex = 10;
            this.cabbage.TabStop = false;
            this.cabbage.Click += new System.EventHandler(this.cabbage_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.plocked1;
            this.pictureBox11.Location = new System.Drawing.Point(842, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(512, 127);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.plocked;
            this.pictureBox12.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(495, 127);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // ship
            // 
            this.ship.BackColor = System.Drawing.Color.Transparent;
            this.ship.Image = global::WindowsFormsApp1.Properties.Resources.Boat3;
            this.ship.Location = new System.Drawing.Point(855, 575);
            this.ship.Margin = new System.Windows.Forms.Padding(4);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(173, 37);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 13;
            this.ship.TabStop = false;
            this.ship.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // farmer
            // 
            this.farmer.BackColor = System.Drawing.Color.Transparent;
            this.farmer.Image = global::WindowsFormsApp1.Properties.Resources.Farmer;
            this.farmer.Location = new System.Drawing.Point(855, 432);
            this.farmer.Margin = new System.Windows.Forms.Padding(4);
            this.farmer.Name = "farmer";
            this.farmer.Size = new System.Drawing.Size(56, 143);
            this.farmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.farmer.TabIndex = 14;
            this.farmer.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(617, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 62);
            this.label1.TabIndex = 15;
            this.label1.Text = "....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 62);
            this.label2.TabIndex = 15;
            this.label2.Text = "......";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(243, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "......";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(874, 31);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(154, 52);
            this.SolveButton.TabIndex = 17;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AI___5_1;
            this.ClientSize = new System.Drawing.Size(1351, 719);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmer);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.cabbage);
            this.Controls.Add(this.goat);
            this.Controls.Add(this.wolf);
            this.Controls.Add(this.wolf_move);
            this.Controls.Add(this.goat_move);
            this.Controls.Add(this.cab_move);
            this.Controls.Add(this.ship_move);
            this.Controls.Add(this.water);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.side2);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1369, 766);
            this.MinimumSize = new System.Drawing.Size(1363, 766);
            this.Name = "game";
            this.Text = "wolf,goat and cabbage";
            this.Load += new System.EventHandler(this.wolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.side2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.side1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cab_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox side2;
        private System.Windows.Forms.PictureBox side1;
        private System.Windows.Forms.PictureBox water;
        private System.Windows.Forms.PictureBox ship_move;
        private System.Windows.Forms.PictureBox cab_move;
        private System.Windows.Forms.PictureBox goat_move;
        private System.Windows.Forms.PictureBox wolf_move;
        private System.Windows.Forms.PictureBox wolf;
        private System.Windows.Forms.PictureBox goat;
        private System.Windows.Forms.PictureBox cabbage;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox farmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SolveButton;
    }
}

