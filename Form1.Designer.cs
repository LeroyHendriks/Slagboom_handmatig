namespace Slagboom_handmatig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOpen_Clicks = new Button();
            btnClose_Clicks = new Button();
            Uitleg = new TextBox();
            OpenofClose = new TextBox();
            SuspendLayout();
            // 
            // btnOpen_Clicks
            // 
            btnOpen_Clicks.BackColor = Color.FromArgb(128, 255, 128);
            btnOpen_Clicks.Location = new Point(100, 307);
            btnOpen_Clicks.Name = "btnOpen_Clicks";
            btnOpen_Clicks.Size = new Size(272, 106);
            btnOpen_Clicks.TabIndex = 0;
            btnOpen_Clicks.Text = "Open";
            btnOpen_Clicks.UseVisualStyleBackColor = false;
            // 
            // btnClose_Clicks
            // 
            btnClose_Clicks.BackColor = Color.FromArgb(255, 128, 128);
            btnClose_Clicks.Location = new Point(410, 307);
            btnClose_Clicks.Name = "btnClose_Clicks";
            btnClose_Clicks.Size = new Size(284, 106);
            btnClose_Clicks.TabIndex = 1;
            btnClose_Clicks.Text = "Sluiten";
            btnClose_Clicks.UseVisualStyleBackColor = false;
            // 
            // Uitleg
            // 
            Uitleg.BorderStyle = BorderStyle.None;
            Uitleg.Font = new Font("Segoe UI Black", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Uitleg.Location = new Point(40, 12);
            Uitleg.Name = "Uitleg";
            Uitleg.Size = new Size(711, 50);
            Uitleg.TabIndex = 2;
            Uitleg.Text = "Open of Sluit de slagboom handmatig";
            // 
            // OpenofClose
            // 
            OpenofClose.BackColor = SystemColors.Control;
            OpenofClose.BorderStyle = BorderStyle.None;
            OpenofClose.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenofClose.Location = new Point(40, 108);
            OpenofClose.Multiline = true;
            OpenofClose.Name = "OpenofClose";
            OpenofClose.ReadOnly = true;
            OpenofClose.Size = new Size(711, 40);
            OpenofClose.TabIndex = 3;
            OpenofClose.TabStop = false;
            OpenofClose.TextAlign = HorizontalAlignment.Center;
            OpenofClose.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenofClose);
            Controls.Add(Uitleg);
            Controls.Add(btnClose_Clicks);
            Controls.Add(btnOpen_Clicks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Slagboom Handmatig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen_Clicks;
        private Button btnClose_Clicks;
        private TextBox Uitleg;
        private TextBox OpenofClose;
    }
}
