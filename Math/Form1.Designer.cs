namespace Math
{
    partial class frmMain
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
            this.doneButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLable = new System.Windows.Forms.Label();
            this.plusLable = new System.Windows.Forms.Label();
            this.timeLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Location = new System.Drawing.Point(24, 158);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(507, 54);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(507, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(24, 132);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(507, 20);
            this.answerBox.TabIndex = 2;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.aLabel.Location = new System.Drawing.Point(263, 45);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(37, 43);
            this.aLabel.TabIndex = 3;
            this.aLabel.Text = "0";
            // 
            // bLable
            // 
            this.bLable.AutoSize = true;
            this.bLable.Font = new System.Drawing.Font("Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bLable.Location = new System.Drawing.Point(472, 45);
            this.bLable.Name = "bLable";
            this.bLable.Size = new System.Drawing.Size(37, 43);
            this.bLable.TabIndex = 4;
            this.bLable.Text = "0";
            // 
            // plusLable
            // 
            this.plusLable.AutoSize = true;
            this.plusLable.Font = new System.Drawing.Font("Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.plusLable.Location = new System.Drawing.Point(367, 45);
            this.plusLable.Name = "plusLable";
            this.plusLable.Size = new System.Drawing.Size(38, 43);
            this.plusLable.TabIndex = 5;
            this.plusLable.Text = "+";
            // 
            // timeLable
            // 
            this.timeLable.AutoSize = true;
            this.timeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.Location = new System.Drawing.Point(-8, 15);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(68, 73);
            this.timeLable.TabIndex = 6;
            this.timeLable.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 308);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.plusLable);
            this.Controls.Add(this.bLable);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.doneButton);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLable;
        private System.Windows.Forms.Label plusLable;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Timer timer1;
    }
}

