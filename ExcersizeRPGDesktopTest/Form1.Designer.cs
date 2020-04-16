namespace ExcersizeRPGDesktopTest
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
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.timerLbl = new System.Windows.Forms.Label();
            this.brawlerBtn = new System.Windows.Forms.Button();
            this.knightBtn = new System.Windows.Forms.Button();
            this.thiefBtn = new System.Windows.Forms.Button();
            this.mageBtn = new System.Windows.Forms.Button();
            this.startPauseBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.Location = new System.Drawing.Point(378, 59);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(109, 39);
            this.instructionsLbl.TabIndex = 0;
            this.instructionsLbl.Text = "label1";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(378, 145);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(35, 13);
            this.timerLbl.TabIndex = 1;
            this.timerLbl.Text = "label2";
            // 
            // brawlerBtn
            // 
            this.brawlerBtn.Location = new System.Drawing.Point(90, 207);
            this.brawlerBtn.Name = "brawlerBtn";
            this.brawlerBtn.Size = new System.Drawing.Size(75, 23);
            this.brawlerBtn.TabIndex = 2;
            this.brawlerBtn.Text = "button1";
            this.brawlerBtn.UseVisualStyleBackColor = true;
            this.brawlerBtn.Click += new System.EventHandler(this.BrawlerBtn_Click);
            // 
            // knightBtn
            // 
            this.knightBtn.Location = new System.Drawing.Point(198, 207);
            this.knightBtn.Name = "knightBtn";
            this.knightBtn.Size = new System.Drawing.Size(75, 23);
            this.knightBtn.TabIndex = 3;
            this.knightBtn.Text = "button2";
            this.knightBtn.UseVisualStyleBackColor = true;
            this.knightBtn.Click += new System.EventHandler(this.KnightBtn_Click);
            // 
            // thiefBtn
            // 
            this.thiefBtn.Location = new System.Drawing.Point(362, 207);
            this.thiefBtn.Name = "thiefBtn";
            this.thiefBtn.Size = new System.Drawing.Size(75, 23);
            this.thiefBtn.TabIndex = 4;
            this.thiefBtn.Text = "button3";
            this.thiefBtn.UseVisualStyleBackColor = true;
            this.thiefBtn.Click += new System.EventHandler(this.ThiefBtn_Click);
            // 
            // mageBtn
            // 
            this.mageBtn.Location = new System.Drawing.Point(532, 207);
            this.mageBtn.Name = "mageBtn";
            this.mageBtn.Size = new System.Drawing.Size(75, 23);
            this.mageBtn.TabIndex = 5;
            this.mageBtn.Text = "button4";
            this.mageBtn.UseVisualStyleBackColor = true;
            this.mageBtn.Click += new System.EventHandler(this.MageBtn_Click);
            // 
            // startPauseBtn
            // 
            this.startPauseBtn.Location = new System.Drawing.Point(362, 315);
            this.startPauseBtn.Name = "startPauseBtn";
            this.startPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.startPauseBtn.TabIndex = 6;
            this.startPauseBtn.Text = "button5";
            this.startPauseBtn.UseVisualStyleBackColor = true;
            this.startPauseBtn.Click += new System.EventHandler(this.StartPauseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startPauseBtn);
            this.Controls.Add(this.mageBtn);
            this.Controls.Add(this.thiefBtn);
            this.Controls.Add(this.knightBtn);
            this.Controls.Add(this.brawlerBtn);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.instructionsLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Button brawlerBtn;
        private System.Windows.Forms.Button knightBtn;
        private System.Windows.Forms.Button thiefBtn;
        private System.Windows.Forms.Button mageBtn;
        private System.Windows.Forms.Button startPauseBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

