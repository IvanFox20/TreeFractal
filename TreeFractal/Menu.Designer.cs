namespace TreeFractal
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
            this.label_AngleAlpha = new System.Windows.Forms.Label();
            this.label_BetaAngle = new System.Windows.Forms.Label();
            this.label_Coef = new System.Windows.Forms.Label();
            this.label_StartLength = new System.Windows.Forms.Label();
            this.label_StepsCount = new System.Windows.Forms.Label();
            this.textBox_AlphaAngle = new System.Windows.Forms.TextBox();
            this.textBox_BetaAngle = new System.Windows.Forms.TextBox();
            this.textBox_Coef = new System.Windows.Forms.TextBox();
            this.textBox_StartLength = new System.Windows.Forms.TextBox();
            this.textBox_StepsCount = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AngleAlpha
            // 
            this.label_AngleAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AngleAlpha.Location = new System.Drawing.Point(75, 27);
            this.label_AngleAlpha.Name = "label_AngleAlpha";
            this.label_AngleAlpha.Size = new System.Drawing.Size(126, 23);
            this.label_AngleAlpha.TabIndex = 0;
            this.label_AngleAlpha.Text = "Угол альфа";
            // 
            // label_BetaAngle
            // 
            this.label_BetaAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BetaAngle.Location = new System.Drawing.Point(75, 68);
            this.label_BetaAngle.Name = "label_BetaAngle";
            this.label_BetaAngle.Size = new System.Drawing.Size(126, 23);
            this.label_BetaAngle.TabIndex = 1;
            this.label_BetaAngle.Text = "Угол бета";
            // 
            // label_Coef
            // 
            this.label_Coef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Coef.Location = new System.Drawing.Point(75, 98);
            this.label_Coef.Name = "label_Coef";
            this.label_Coef.Size = new System.Drawing.Size(126, 60);
            this.label_Coef.TabIndex = 2;
            this.label_Coef.Text = "Коэффициент уменьшения";
            // 
            // label_StartLength
            // 
            this.label_StartLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StartLength.Location = new System.Drawing.Point(75, 158);
            this.label_StartLength.Name = "label_StartLength";
            this.label_StartLength.Size = new System.Drawing.Size(126, 43);
            this.label_StartLength.TabIndex = 3;
            this.label_StartLength.Text = "Начальная длина";
            // 
            // label_StepsCount
            // 
            this.label_StepsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StepsCount.Location = new System.Drawing.Point(75, 205);
            this.label_StepsCount.Name = "label_StepsCount";
            this.label_StepsCount.Size = new System.Drawing.Size(126, 48);
            this.label_StepsCount.TabIndex = 4;
            this.label_StepsCount.Text = "Количество шагов";
            // 
            // textBox_AlphaAngle
            // 
            this.textBox_AlphaAngle.Location = new System.Drawing.Point(207, 27);
            this.textBox_AlphaAngle.Name = "textBox_AlphaAngle";
            this.textBox_AlphaAngle.Size = new System.Drawing.Size(100, 20);
            this.textBox_AlphaAngle.TabIndex = 5;
            this.textBox_AlphaAngle.Text = "25";
            // 
            // textBox_BetaAngle
            // 
            this.textBox_BetaAngle.Location = new System.Drawing.Point(207, 68);
            this.textBox_BetaAngle.Name = "textBox_BetaAngle";
            this.textBox_BetaAngle.Size = new System.Drawing.Size(100, 20);
            this.textBox_BetaAngle.TabIndex = 6;
            this.textBox_BetaAngle.Text = "25";
            // 
            // textBox_Coef
            // 
            this.textBox_Coef.Location = new System.Drawing.Point(207, 111);
            this.textBox_Coef.Name = "textBox_Coef";
            this.textBox_Coef.Size = new System.Drawing.Size(100, 20);
            this.textBox_Coef.TabIndex = 7;
            this.textBox_Coef.Text = "0,8";
            // 
            // textBox_StartLength
            // 
            this.textBox_StartLength.Location = new System.Drawing.Point(207, 160);
            this.textBox_StartLength.Name = "textBox_StartLength";
            this.textBox_StartLength.Size = new System.Drawing.Size(100, 20);
            this.textBox_StartLength.TabIndex = 8;
            this.textBox_StartLength.Text = "40";
            // 
            // textBox_StepsCount
            // 
            this.textBox_StepsCount.Location = new System.Drawing.Point(207, 207);
            this.textBox_StepsCount.Name = "textBox_StepsCount";
            this.textBox_StepsCount.Size = new System.Drawing.Size(100, 20);
            this.textBox_StepsCount.TabIndex = 9;
            this.textBox_StepsCount.Text = "10";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.MintCream;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(75, 277);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(232, 89);
            this.button_Start.TabIndex = 10;
            this.button_Start.Text = "Построить фрактал";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(387, 422);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_StepsCount);
            this.Controls.Add(this.textBox_StartLength);
            this.Controls.Add(this.textBox_Coef);
            this.Controls.Add(this.textBox_BetaAngle);
            this.Controls.Add(this.textBox_AlphaAngle);
            this.Controls.Add(this.label_StepsCount);
            this.Controls.Add(this.label_StartLength);
            this.Controls.Add(this.label_Coef);
            this.Controls.Add(this.label_BetaAngle);
            this.Controls.Add(this.label_AngleAlpha);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button_Start;

        private System.Windows.Forms.Label label_StepsCount;

        private System.Windows.Forms.TextBox textBox_StepsCount;

        private System.Windows.Forms.TextBox textBox_AlphaAngle;
        private System.Windows.Forms.TextBox textBox_BetaAngle;
        private System.Windows.Forms.TextBox textBox_Coef;
        private System.Windows.Forms.TextBox textBox_StartLength;
        private System.Windows.Forms.Label label_StartLength;

        private System.Windows.Forms.Label label_Coef;

        private System.Windows.Forms.Label label_AngleAlpha;
        private System.Windows.Forms.Label label_BetaAngle;

        #endregion
    }
}