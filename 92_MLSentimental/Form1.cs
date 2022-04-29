using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _92_MLSentimental.MLModel1;

namespace _92_MLSentimental
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

            
            var predictionResult = MLModel1.Predict(sampleData);

            tboxResult.Text = predictionResult.PredictedLabel.ToString() == "0" ? "Negative" : "Positive";
            tboxPercent.Text = $" P1 : {predictionResult.Score[0] * 100}%, P2 : {predictionResult.Score[1] * 100}% ";
        }
    }
}
