
namespace Snake_Game
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
            this.components = new System.ComponentModel.Container();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.snakeBody1 = new System.Windows.Forms.PictureBox();
            this.snakeBody2 = new System.Windows.Forms.PictureBox();
            this.snakeHead = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBody1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBody2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Interval = 800;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // snakeBody1
            // 
            this.snakeBody1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.snakeBody1.Location = new System.Drawing.Point(110, 136);
            this.snakeBody1.Name = "snakeBody1";
            this.snakeBody1.Size = new System.Drawing.Size(20, 20);
            this.snakeBody1.TabIndex = 1;
            this.snakeBody1.TabStop = false;
            // 
            // snakeBody2
            // 
            this.snakeBody2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.snakeBody2.Location = new System.Drawing.Point(110, 160);
            this.snakeBody2.Name = "snakeBody2";
            this.snakeBody2.Size = new System.Drawing.Size(20, 20);
            this.snakeBody2.TabIndex = 2;
            this.snakeBody2.TabStop = false;
            // 
            // snakeHead
            // 
            this.snakeHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.snakeHead.Location = new System.Drawing.Point(110, 110);
            this.snakeHead.Name = "snakeHead";
            this.snakeHead.Size = new System.Drawing.Size(20, 20);
            this.snakeHead.TabIndex = 0;
            this.snakeHead.TabStop = false;
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.Gold;
            this.food.Location = new System.Drawing.Point(0, 0);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(20, 20);
            this.food.TabIndex = 3;
            this.food.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 441);
            this.Controls.Add(this.food);
            this.Controls.Add(this.snakeBody2);
            this.Controls.Add(this.snakeHead);
            this.Controls.Add(this.snakeBody1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.snakeBody1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeBody2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.PictureBox snakeBody1;
        private System.Windows.Forms.PictureBox snakeBody2;
        private System.Windows.Forms.PictureBox snakeHead;
        private System.Windows.Forms.PictureBox food;
    }
}

