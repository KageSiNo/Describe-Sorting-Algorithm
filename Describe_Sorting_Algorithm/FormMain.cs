using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Describe_Sorting_Algorithm
{
    public partial class FormMain : Form
    {
        const int MIN_VALUE = 10;
        const int MAX_VALUE = 500;


        string Algorithm { get; set; }
        Graphics MainGraphics { get; set; }
        Visualizer Visualizer { get; set; }


        public FormMain()
        {
            InitializeComponent();

        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            MainGraphics = pnlMain.CreateGraphics();
            Visualizer = new Visualizer(MainGraphics, 30);
            Visualizer.ElapsedTimeChange += this.Visualizer_ElapsedTimeChange;
            Visualizer.ComparisonsChange += this.Visualizer_ComparisonsChange;
            Visualizer.SwapsChange += this.Visualizer_SwapsChange;
            this.BackColor = ConstColor.BACKGROUP;
            this.pnlMain.BackColor = ConstColor.BACKGROUP_CANVAS;
            this.Algorithm = "Selection Sort";

            SetFPSByTrackBar(trackBarFPS);

            richTxbAlg.Text = Visualizer.GetAlgorithm("Selection Sort");

        }

        private void Visualizer_SwapsChange(object sender, EventArgs e)
        {
            lbSwaps.Invoke(new MethodInvoker(() =>
            {
                lbSwaps.Text = Visualizer.Swaps.ToString();
            }));
        }

        private void Visualizer_ComparisonsChange(object sender, EventArgs e)
        {
            lbComparisons.Invoke(new MethodInvoker(() =>
            {
                lbComparisons.Text = Visualizer.Comparisons.ToString();
            }));
        }

        private void Visualizer_ElapsedTimeChange(object sender, EventArgs e)
        {
            //lbElap.Invoke(new MethodInvoker(() =>
            //{

            //}));
            if (Visualizer.ElapsedTime == 0)
            {
                lbElap.Text = "0.0 ms";
                return;
            }
            lbElap.Text = Visualizer.ElapsedTime.ToString() + " ms";
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(ConstColor.BACKGROUP_CANVAS);
            Visualizer.DrawArray(e.Graphics);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            lbComparisons.Text = lbSwaps.Text = "0";
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            Run();
            //Visualizer.Sniff(UpdateInfoSort, 0);
        }


        private void btnCreateRnd_Click(object sender, EventArgs e)
        {
            if (Visualizer == null) return;
            CreateArray();
            lbComparisons.Text = lbSwaps.Text = "0";
        }

        void Reset()
        {
            if (Visualizer != null)
            {
                Visualizer.ResetArray();
            }
        }

        public void Run()
        {
            if (Visualizer != null)
            {
                Visualizer.Run(Algorithm);
            }

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioBtn = sender as RadioButton;
            if (radioBtn == null)
                return;

            if (radioBtn.Checked == true)
            {
                Algorithm = radioBtn.Text;

                if (Visualizer != null)
                    richTxbAlg.Text = Visualizer.GetAlgorithm(radioBtn.Text);
            }
        }

        private void trackBarFPS_Scroll(object sender, EventArgs e)
        {
            if (Visualizer == null)
                return;
            SetFPSByTrackBar(trackBarFPS);
        }

        void CreateArray()
        {
            if (Visualizer.IsRunning)
                return;

            // caculator width
            int num = (int)nudValue.Value;
            float width = ((float)(pnlMain.Width - num - 8) / num);

            Visualizer.NumItem = num;
            Visualizer.InitArray(MIN_VALUE, MAX_VALUE, width, pnlMain.Height - 10);
            MainGraphics.Clear(ConstColor.BACKGROUP_CANVAS);
            Visualizer.DrawArray(MainGraphics);
        }

        void SetFPSByTrackBar(TrackBar t)
        {
            Visualizer.FPS = t.Value;
            lbFPS.Text = "FPS: " + Visualizer.FPS.ToString();
        }
        void UpdateInfoSort()
        {
            lbSwaps.Invoke(new MethodInvoker(() =>
            {
                lbSwaps.Text = Visualizer.Swaps.ToString();
            }));

            lbComparisons.Invoke(new MethodInvoker(() =>
            {
                lbComparisons.Text = Visualizer.Comparisons.ToString();
            }));
        }

    }
}
