using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _91_MLLabelled.MLModel;

namespace _91_MLLabelled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ModelInput sampleData = new ModelInput();

            sampleData.Col0 = tboxInput.Text.Trim();

            var predictionResult = MLModel.Predict(sampleData);

            tboxOutput.Text = predictionResult.PredictedLabel == 0 ? "Negative" : "Positive";
            tboxPredict.Text = $" P1 : {predictionResult.Score[0] * 100}%, P2 : {predictionResult.Score[1] * 100}% ";
        }
    }
}
