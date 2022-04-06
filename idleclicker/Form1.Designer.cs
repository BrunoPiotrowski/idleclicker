namespace idleclicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradebutton2 = new System.Windows.Forms.Button();
            this.buttonleveltextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "klikaj ziom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "kasa $0";
            // 
            // upgradebutton2
            // 
            this.upgradebutton2.Location = new System.Drawing.Point(588, 342);
            this.upgradebutton2.Name = "upgradebutton2";
            this.upgradebutton2.Size = new System.Drawing.Size(75, 62);
            this.upgradebutton2.TabIndex = 2;
            this.upgradebutton2.Text = "upgrade\r\n($10)";
            this.upgradebutton2.UseVisualStyleBackColor = true;
            this.upgradebutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonleveltextbox
            // 
            this.buttonleveltextbox.Location = new System.Drawing.Point(586, 308);
            this.buttonleveltextbox.Name = "buttonleveltextbox";
            this.buttonleveltextbox.ReadOnly = true;
            this.buttonleveltextbox.Size = new System.Drawing.Size(77, 23);
            this.buttonleveltextbox.TabIndex = 3;
            this.buttonleveltextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonleveltextbox.TextChanged += new System.EventHandler(this.buttonleveltextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonleveltextbox);
            this.Controls.Add(this.upgradebutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradebutton2;
        private TextBox buttonleveltextbox;
    }
}