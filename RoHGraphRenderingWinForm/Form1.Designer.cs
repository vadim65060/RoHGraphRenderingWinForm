
namespace RoHGraphRenderingWinForm
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
            this.graphRenderingUserControl1 = new RoHGraphRenderingWinForm.UserControls.GraphRenderingUserControl();
            this.SuspendLayout();
            // 
            // graphRenderingUserControl1
            // 
            this.graphRenderingUserControl1.Location = new System.Drawing.Point(42, 25);
            this.graphRenderingUserControl1.Name = "graphRenderingUserControl1";
            this.graphRenderingUserControl1.Size = new System.Drawing.Size(746, 223);
            this.graphRenderingUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.graphRenderingUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.GraphRenderingUserControl graphRenderingUserControl1;
    }
}

