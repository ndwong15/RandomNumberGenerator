
namespace RandomNumberGenerator
{
    partial class mainForm
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
            this.nextButton = new System.Windows.Forms.Button();
            this.multiTextbox = new System.Windows.Forms.TextBox();
            this.multiLabel = new System.Windows.Forms.Label();
            this.incLabel = new System.Windows.Forms.Label();
            this.incTextbox = new System.Windows.Forms.TextBox();
            this.modLabel = new System.Windows.Forms.Label();
            this.modTextbox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(60, 145);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(127, 23);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "&Next Number";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // multiTextbox
            // 
            this.multiTextbox.Location = new System.Drawing.Point(87, 28);
            this.multiTextbox.Name = "multiTextbox";
            this.multiTextbox.Size = new System.Drawing.Size(100, 20);
            this.multiTextbox.TabIndex = 1;
            // 
            // multiLabel
            // 
            this.multiLabel.AutoSize = true;
            this.multiLabel.Location = new System.Drawing.Point(24, 32);
            this.multiLabel.Name = "multiLabel";
            this.multiLabel.Size = new System.Drawing.Size(48, 13);
            this.multiLabel.TabIndex = 2;
            this.multiLabel.Text = "Multiplier";
            // 
            // incLabel
            // 
            this.incLabel.AutoSize = true;
            this.incLabel.Location = new System.Drawing.Point(24, 58);
            this.incLabel.Name = "incLabel";
            this.incLabel.Size = new System.Drawing.Size(54, 13);
            this.incLabel.TabIndex = 4;
            this.incLabel.Text = "Increment";
            // 
            // incTextbox
            // 
            this.incTextbox.Location = new System.Drawing.Point(87, 54);
            this.incTextbox.Name = "incTextbox";
            this.incTextbox.Size = new System.Drawing.Size(100, 20);
            this.incTextbox.TabIndex = 3;
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Location = new System.Drawing.Point(24, 84);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(47, 13);
            this.modLabel.TabIndex = 6;
            this.modLabel.Text = "Modulus";
            // 
            // modTextbox
            // 
            this.modTextbox.Location = new System.Drawing.Point(87, 80);
            this.modTextbox.Name = "modTextbox";
            this.modTextbox.Size = new System.Drawing.Size(100, 20);
            this.modTextbox.TabIndex = 5;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(24, 110);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 8;
            this.seedLabel.Text = "Seed";
            // 
            // seedTextbox
            // 
            this.seedTextbox.Location = new System.Drawing.Point(87, 106);
            this.seedTextbox.Name = "seedTextbox";
            this.seedTextbox.Size = new System.Drawing.Size(100, 20);
            this.seedTextbox.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 234);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedTextbox);
            this.Controls.Add(this.modLabel);
            this.Controls.Add(this.modTextbox);
            this.Controls.Add(this.incLabel);
            this.Controls.Add(this.incTextbox);
            this.Controls.Add(this.multiLabel);
            this.Controls.Add(this.multiTextbox);
            this.Controls.Add(this.nextButton);
            this.Name = "mainForm";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox multiTextbox;
        private System.Windows.Forms.Label multiLabel;
        private System.Windows.Forms.Label incLabel;
        private System.Windows.Forms.TextBox incTextbox;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.TextBox modTextbox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox seedTextbox;
    }
}

