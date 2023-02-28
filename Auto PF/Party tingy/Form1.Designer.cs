
namespace Party_tingy
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.pfButton = new System.Windows.Forms.Button();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.labelPortremove = new System.Windows.Forms.Label();
            this.portRemoveTextBox = new System.Windows.Forms.TextBox();
            this.pfremoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automatic Port forwarding";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(53, 62);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(71, 20);
            this.ipLabel.TabIndex = 1;
            this.ipLabel.Text = "Enter IP:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipTextBox.ForeColor = System.Drawing.Color.Lime;
            this.ipTextBox.Location = new System.Drawing.Point(57, 85);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(192, 19);
            this.ipTextBox.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(57, 107);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(84, 20);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Enter port:";
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portTextBox.ForeColor = System.Drawing.Color.Lime;
            this.portTextBox.Location = new System.Drawing.Point(57, 130);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(192, 19);
            this.portTextBox.TabIndex = 4;
            // 
            // pfButton
            // 
            this.pfButton.BackColor = System.Drawing.Color.Black;
            this.pfButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pfButton.FlatAppearance.BorderSize = 0;
            this.pfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfButton.Location = new System.Drawing.Point(57, 165);
            this.pfButton.Name = "pfButton";
            this.pfButton.Size = new System.Drawing.Size(178, 59);
            this.pfButton.TabIndex = 5;
            this.pfButton.Text = "Press to Portforward";
            this.pfButton.UseVisualStyleBackColor = false;
            this.pfButton.Click += new System.EventHandler(this.pfButton_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.consoleTextBox.Location = new System.Drawing.Point(12, 316);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(754, 116);
            this.consoleTextBox.TabIndex = 6;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(57, 290);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(67, 20);
            this.consoleLabel.TabIndex = 7;
            this.consoleLabel.Text = "Console";
            // 
            // labelPortremove
            // 
            this.labelPortremove.AutoSize = true;
            this.labelPortremove.Location = new System.Drawing.Point(531, 107);
            this.labelPortremove.Name = "labelPortremove";
            this.labelPortremove.Size = new System.Drawing.Size(81, 20);
            this.labelPortremove.TabIndex = 8;
            this.labelPortremove.Text = "Enter Port";
            // 
            // portRemoveTextBox
            // 
            this.portRemoveTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portRemoveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portRemoveTextBox.ForeColor = System.Drawing.Color.Lime;
            this.portRemoveTextBox.Location = new System.Drawing.Point(535, 130);
            this.portRemoveTextBox.Name = "portRemoveTextBox";
            this.portRemoveTextBox.Size = new System.Drawing.Size(185, 19);
            this.portRemoveTextBox.TabIndex = 9;
            // 
            // pfremoveButton
            // 
            this.pfremoveButton.BackColor = System.Drawing.Color.Black;
            this.pfremoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pfremoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pfremoveButton.Location = new System.Drawing.Point(535, 165);
            this.pfremoveButton.Name = "pfremoveButton";
            this.pfremoveButton.Size = new System.Drawing.Size(185, 59);
            this.pfremoveButton.TabIndex = 10;
            this.pfremoveButton.Text = "Press to remove Portforward";
            this.pfremoveButton.UseVisualStyleBackColor = false;
            this.pfremoveButton.Click += new System.EventHandler(this.pfremoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.pfremoveButton);
            this.Controls.Add(this.portRemoveTextBox);
            this.Controls.Add(this.labelPortremove);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.pfButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button pfButton;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Label labelPortremove;
        private System.Windows.Forms.TextBox portRemoveTextBox;
        private System.Windows.Forms.Button pfremoveButton;
    }
}

