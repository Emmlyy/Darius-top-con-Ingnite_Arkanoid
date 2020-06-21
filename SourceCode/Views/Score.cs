using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using proyectoPOO.Controllers;
using proyectoPOO.Exceptions;
using proyectoPOO.Models;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace proyectoPOO.Views
{
    public partial class Score : UserControl
    {
        private CartesianChart chart;
        private Label txtLabel = new Label();
        public Score()
        {
            InitializeComponent();
            chart =new CartesianChart();
            this.Controls.Add(chart);
        }
        private void Score_Load(object sender, EventArgs e)
        {
            try
            {
                
                txtLabel.Width = 100;
                txtLabel.Height = 100;
                txtLabel.Top = 30;
                txtLabel.Left = 30;
                txtLabel.Text = "Presione ESC para regresar";
                txtLabel.Anchor = AnchorStyles.Left;
                this.Controls.Add(txtLabel);
                
                //graph specifications
                Height = ClientSize.Height;
                Width = ClientSize.Width;
                chart.Top = 10;
                chart.Left = 10;
                chart.Width = Convert.ToInt32(Width * 0.95);
                chart.Height = Convert.ToInt32(Height * 0.95);
                chart.Anchor = AnchorStyles.None;
                chart.BackColor = Color.Transparent;

                //get top list
                List<User> u = new List<User>();
                u = ControllersGame.Top();
                if (u.Count == 0)
                {
                    throw new TopTenException("La base de datos no tiene elementos");
                }

                //creating empty graph
                chart.Series = new SeriesCollection
                {
                    new RowSeries {Title = "Top 10", Values = new ChartValues<int>(), DataLabels = true}
                };
                chart.AxisY.Add(new Axis {Labels = new List<string>()});

                u.Reverse();
                chart.LegendLocation = LegendLocation.Bottom;

                //filling fields of the graph
                foreach (var x in u)
                {
                    chart.Series[0].Values.Add(x.point);
                    chart.AxisY[0].Labels.Add(x.name);
                }
                MessageBox.Show("Top 10");
            }
            catch (TopTenException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el top");
            }
        }
        
    }
}