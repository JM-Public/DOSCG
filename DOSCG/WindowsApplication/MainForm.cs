using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using WindowsApplication.Providers;

namespace WindowsApplication
{
    public partial class MainForm : Form
    {
        const string EMPTY_API_KEY = "...enter your Google API Key...";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region " Loading XYZ Problem "

            // ! จากโจทย์ X, Y, 5, 9, 15, 23, Z คือ ลำดับพหุนามดีกรีสอง และมีพจน์ทั่วไป คือ an = 3 + (n - 1)(n - 2)
            // ! ref https://www.opendurian.com/learn/sequence_pattern_identification/
            int GeneralTerm(int n) => 3 + (n - 1) * (n - 2);

            var ASCProvider = new ArithmeticSequenceCalculator(GeneralTerm);

            // ! Finding X value ( n = 1 )
            XTextBox.Text = ASCProvider.GetValue(N: 1).ToString();

            // ! Finding Y value ( n = 2 )
            YTextBox.Text = ASCProvider.GetValue(N: 2).ToString();

            // ! Finding Z value ( n = 7 )
            ZTextBox.Text = ASCProvider.GetValue(N: 7).ToString();

            #endregion

            #region " Loading BC Problem "

            // ! จากโจทย์ A = 21, A + B = 23, A + C = -21
            // ! จะได้ A = 21, B = 23 - A, C = -21 - A

            int A = 21;

            // ! Finding B value ( B = 23 - A )
            BTextBox.Text = (23 - A).ToString();

            // ! Finding C value ( C = -21 - A )
            CTextBox.Text = (-21 - A).ToString();

            #endregion
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            RouteListView.Items.Clear();

            #region " Loading Google API Finding best route SCG to Central World "

            var DSPProvider = new DirectionsServiceProvider();

            var parameters = new Dictionary<string, string>()
            {
                { "origin", "SCG+สำนักงานใหญ่+บางซื่อ+1+Siam+Cement+Alley,+Bang+Sue,+Bangkok+10800" },
                { "destination", "Central+World,+Rama+I+Road,+Pathum+Wan,+Pathum+Wan+District,+Bangkok" },
                { "key", $"{(APIKeyTextBox.Text == EMPTY_API_KEY ? string.Empty : APIKeyTextBox.Text)}" }
            };

            try
            {
                var direction = DSPProvider.GetDirection(parameters);

                foreach (var step in direction.Routes[0].Legs[0].Steps)
                {
                    RouteListView.Items.Add(new ListViewItem(new[] { step.Maneuver ?? "go-straight", Regex.Replace(step.HtmlInstructions, "<.*?>", String.Empty), step.Distance.Text }));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            #endregion
        }
    }
}
