namespace choose_your_own_adventure_game
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
            this.outputlabel = new System.Windows.Forms.Label();
            this.Yesbutton = new System.Windows.Forms.Button();
            this.Nobutton = new System.Windows.Forms.Button();
            this.Dogbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.dielabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputlabel
            // 
            this.outputlabel.BackColor = System.Drawing.Color.Black;
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.Color.Red;
            this.outputlabel.Location = new System.Drawing.Point(179, 13);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(725, 75);
            this.outputlabel.TabIndex = 0;
            // 
            // Yesbutton
            // 
            this.Yesbutton.Location = new System.Drawing.Point(12, 528);
            this.Yesbutton.Name = "Yesbutton";
            this.Yesbutton.Size = new System.Drawing.Size(486, 59);
            this.Yesbutton.TabIndex = 1;
            this.Yesbutton.Text = "Yes";
            this.Yesbutton.UseVisualStyleBackColor = true;
            this.Yesbutton.Click += new System.EventHandler(this.Yesbutton_Click);
            // 
            // Nobutton
            // 
            this.Nobutton.Location = new System.Drawing.Point(534, 528);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(486, 59);
            this.Nobutton.TabIndex = 2;
            this.Nobutton.Text = "No";
            this.Nobutton.UseVisualStyleBackColor = true;
            this.Nobutton.Click += new System.EventHandler(this.Nobutton_Click);
            // 
            // Dogbutton
            // 
            this.Dogbutton.Location = new System.Drawing.Point(12, 593);
            this.Dogbutton.Name = "Dogbutton";
            this.Dogbutton.Size = new System.Drawing.Size(1008, 55);
            this.Dogbutton.TabIndex = 3;
            this.Dogbutton.Text = "Dog";
            this.Dogbutton.UseVisualStyleBackColor = true;
            this.Dogbutton.Click += new System.EventHandler(this.Dogbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(12, 467);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(1008, 55);
            this.Nextbutton.TabIndex = 4;
            this.Nextbutton.Text = "next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // dielabel
            // 
            this.dielabel.BackColor = System.Drawing.Color.Transparent;
            this.dielabel.Font = new System.Drawing.Font("Monotxt_IV25", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dielabel.ForeColor = System.Drawing.Color.Red;
            this.dielabel.Location = new System.Drawing.Point(12, 155);
            this.dielabel.Name = "dielabel";
            this.dielabel.Size = new System.Drawing.Size(1008, 265);
            this.dielabel.TabIndex = 5;
            this.dielabel.Text = "You died";
            this.dielabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::choose_your_own_adventure_game.Properties.Resources.bedroom;
            this.ClientSize = new System.Drawing.Size(1032, 649);
            this.Controls.Add(this.dielabel);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Dogbutton);
            this.Controls.Add(this.Nobutton);
            this.Controls.Add(this.Yesbutton);
            this.Controls.Add(this.outputlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button Yesbutton;
        private System.Windows.Forms.Button Nobutton;
        private System.Windows.Forms.Button Dogbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Label dielabel;
    }
}

