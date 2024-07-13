namespace TextEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private int width; // the width of the page
        private int height; // the height of the page
        private double ratio; // 8.5 / 11 = .77 * 300 height pixels = 231 width pixel


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
            TextPanel = new RichTextBox();
            SuspendLayout();
            // 
            // TextPanel
            // 
            TextPanel.Dock = DockStyle.Fill;
            TextPanel.Location = new Point(0, 0);
            TextPanel.Name = "TextPanel";
            TextPanel.Size = new Size(800, 450);
            TextPanel.TabIndex = 0;
            TextPanel.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(TextPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TextPanel;
    }
}
