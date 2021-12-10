
namespace RoHGraphRenderingWinForm.UserControls
{
    partial class GraphRenderingUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Attenuation0 = new System.Windows.Forms.Label();
            this.TextBoxBrightness = new System.Windows.Forms.TextBox();
            this.TextBoxAttenuation2 = new System.Windows.Forms.TextBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.TextBoxAttenuation1 = new System.Windows.Forms.TextBox();
            this.TextBoxAttenuation0 = new System.Windows.Forms.TextBox();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Attenuation0);
            this.groupBox1.Controls.Add(this.TextBoxBrightness);
            this.groupBox1.Controls.Add(this.TextBoxAttenuation2);
            this.groupBox1.Controls.Add(this.TextBoxRange);
            this.groupBox1.Controls.Add(this.TextBoxAttenuation1);
            this.groupBox1.Controls.Add(this.TextBoxAttenuation0);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Attenuation2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attenuation1";
            // 
            // Attenuation0
            // 
            this.Attenuation0.AutoSize = true;
            this.Attenuation0.Location = new System.Drawing.Point(6, 25);
            this.Attenuation0.Name = "Attenuation0";
            this.Attenuation0.Size = new System.Drawing.Size(76, 15);
            this.Attenuation0.TabIndex = 6;
            this.Attenuation0.Text = "Attenuation0";
            // 
            // TextBoxBrightness
            // 
            this.TextBoxBrightness.Location = new System.Drawing.Point(88, 109);
            this.TextBoxBrightness.Name = "TextBoxBrightness";
            this.TextBoxBrightness.Size = new System.Drawing.Size(100, 23);
            this.TextBoxBrightness.TabIndex = 1;
            this.TextBoxBrightness.TextChanged += new System.EventHandler(this.TextBoxBrightness_TextChanged);
            // 
            // TextBoxAttenuation2
            // 
            this.TextBoxAttenuation2.Location = new System.Drawing.Point(88, 80);
            this.TextBoxAttenuation2.Name = "TextBoxAttenuation2";
            this.TextBoxAttenuation2.Size = new System.Drawing.Size(100, 23);
            this.TextBoxAttenuation2.TabIndex = 2;
            this.TextBoxAttenuation2.TextChanged += new System.EventHandler(this.TextBoxAttenuation2_TextChanged);
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(88, 138);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.Size = new System.Drawing.Size(100, 23);
            this.TextBoxRange.TabIndex = 3;
            this.TextBoxRange.TextChanged += new System.EventHandler(this.TextBoxRange_TextChanged);
            // 
            // TextBoxAttenuation1
            // 
            this.TextBoxAttenuation1.Location = new System.Drawing.Point(88, 51);
            this.TextBoxAttenuation1.Name = "TextBoxAttenuation1";
            this.TextBoxAttenuation1.Size = new System.Drawing.Size(100, 23);
            this.TextBoxAttenuation1.TabIndex = 4;
            this.TextBoxAttenuation1.TextChanged += new System.EventHandler(this.TextBoxAttenuation1_TextChanged);
            // 
            // TextBoxAttenuation0
            // 
            this.TextBoxAttenuation0.Location = new System.Drawing.Point(88, 22);
            this.TextBoxAttenuation0.Name = "TextBoxAttenuation0";
            this.TextBoxAttenuation0.Size = new System.Drawing.Size(100, 23);
            this.TextBoxAttenuation0.TabIndex = 5;
            this.TextBoxAttenuation0.TextChanged += new System.EventHandler(this.TextBoxAttenuation0_TextChanged);
            // 
            // plotView
            // 
            this.plotView.Location = new System.Drawing.Point(239, 12);
            this.plotView.MinimumSize = new System.Drawing.Size(50, 50);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(462, 173);
            this.plotView.TabIndex = 0;
            this.plotView.Text = "plotView1";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.plotView);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 194);
            this.panel1.TabIndex = 7;
            // 
            // GraphRenderingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GraphRenderingUserControl";
            this.Size = new System.Drawing.Size(719, 203);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxBrightness;
        private System.Windows.Forms.TextBox TextBoxAttenuation2;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.TextBox TextBoxAttenuation1;
        private System.Windows.Forms.TextBox TextBoxAttenuation0;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.Label Attenuation0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
