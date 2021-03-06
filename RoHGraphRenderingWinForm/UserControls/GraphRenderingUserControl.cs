using System;
using System.Windows.Forms;
using OxyPlot;
using RoHGraphRenderingWinForm.Сlasses;

namespace RoHGraphRenderingWinForm.UserControls
{
    public partial class GraphRenderingUserControl : UserControl
    {
        public PlotModel Model { get; } = new PlotModel();
        private Graph graph = new();

        public GraphRenderingUserControl()
        {
            InitializeComponent();
            TextBoxAttenuation0.Text = graph.Attenuation0.ToString();
            TextBoxAttenuation1.Text = graph.Attenuation1.ToString();
            TextBoxAttenuation2.Text = graph.Attenuation2.ToString();
            TextBoxBrightness.Text = graph.Brightness.ToString();
            TextBoxRange.Text = graph.Range.ToString();
            plotView.Model = Model;
            ModelUpdate();
        }

        public void SetConstants(double brightness, double range, double attenuation0, double attenuation1,
            double attenuation2)
        {
            graph.Brightness = brightness;
            graph.Range = range;
            graph.Attenuation0 = attenuation0;
            graph.Attenuation1 = attenuation1;
            graph.Attenuation2 = attenuation2;
            ModelUpdate();
        }

        private void ModelUpdate()
        {
            Model.Series.Clear();
            Model.Series.Add(graph.PointsCalculate());
            Model.InvalidatePlot(true);
        }

        private void TextBoxAttenuation0_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxAttenuation0.Text))
            {
                graph.Attenuation0 = Double.Parse(TextBoxAttenuation0.Text);
                ModelUpdate();
            }
        }

        private void TextBoxAttenuation1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxAttenuation1.Text))
            {
                graph.Attenuation1 = Double.Parse(TextBoxAttenuation1.Text);
                ModelUpdate();
            }
        }

        private void TextBoxAttenuation2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxAttenuation2.Text))
            {
                graph.Attenuation2 = Double.Parse(TextBoxAttenuation2.Text);
                ModelUpdate();
            }
        }

        private void TextBoxBrightness_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxBrightness.Text))
            {
                graph.Brightness = Double.Parse(TextBoxBrightness.Text);
                ModelUpdate();
            }
        }

        private void TextBoxRange_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxRange.Text))
            {
                graph.Range = Double.Parse(TextBoxRange.Text);
                ModelUpdate();
            }
        }
    }
}
