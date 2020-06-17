using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using PieChart = LiveCharts.WinForms.PieChart;

namespace proyectoPOO
{
    public partial class Score : UserControl
    {
        private CartesianChart chart;
        public Score()
        {
            InitializeComponent();
            chart =new CartesianChart();
            this.Controls.Add(chart);
           

        }


        private void Puntaje_Load(object sender, EventArgs e)
        {
            try
            {
                //Especificaciones de la grafica
                chart.Top = 10;
                chart.Left = 10;
                chart.Width = 300;
                chart.Height = 300;
                chart.Dock = DockStyle.Fill;
                chart.BackColor = Color.Transparent;
                
                //obtener lista del top
                List<User> u = new List<User>();
                u = ControllersGame.Top();
                
                //creando grafica con campos vacios
                chart.Series = new SeriesCollection
                {
                    new RowSeries{Title = "Top 10", Values = new ChartValues<int>(),DataLabels = true}
                };
                chart.AxisY.Add(new Axis{Labels = new List<string>()});
                
                /*FORMA 2
                 foreach (var x in u)
                {
                    chart.Series.Add(new RowSeries()
                    {
                        Title = x.name,
                        Values = new ChartValues<double>{x.point}
                        
                    });
                }*/
                u.Reverse();
                chart.LegendLocation = LegendLocation.Bottom;
                
                //llenando campos de la grafico
                foreach (var x in u)
                {
                    chart.Series[0].Values.Add(x.point);
                    chart.AxisY[0].Labels.Add(x.name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en grafica");
            }
        }
        
    }
}