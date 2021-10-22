
namespace floppyBird
{
    partial class FloppyDuck
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
            this.components = new System.ComponentModel.Container();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::floppyBird.Properties.Resources.pipedown;
            this.pbPipe3.Location = new System.Drawing.Point(598, -3);
            this.pbPipe3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(88, 138);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 0;
            this.pbPipe3.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::floppyBird.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(20, 177);
            this.pbBird.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(75, 69);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Image = global::floppyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 584);
            this.pbGround.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1216, 73);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::floppyBird.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(910, -3);
            this.pbPipe4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(102, 225);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 0;
            this.pbPipe4.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::floppyBird.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(555, 358);
            this.pbPipe1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(85, 216);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 1;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::floppyBird.Properties.Resources.pipe;
            this.pbPipe2.Location = new System.Drawing.Point(827, 465);
            this.pbPipe2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(85, 109);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 1;
            this.pbPipe2.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(28, 9);
            this.lblScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(96, 29);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Skore: ";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // FloppyDuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 657);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FloppyDuck";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FloppyDuck_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
    }
}

