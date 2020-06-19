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
        private Label textLabel = new Label();
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
                
                textLabel.Width = 100;
                textLabel.Height = 100;
                textLabel.Top = 30;
                textLabel.Left = 30;
                textLabel.Text = "Presione ESC para regresar";
                textLabel.Anchor = AnchorStyles.Left;
                this.Controls.Add(textLabel);
                //Especificaciones de la grafica
                Height = ClientSize.Height;
                Width = ClientSize.Width;
                chart.Top = 10;
                chart.Left = 10;
                chart.Width = Convert.ToInt32(Width * 0.95);
                chart.Height = Convert.ToInt32(Height * 0.95);
                chart.Anchor = AnchorStyles.None;
                //chart.Dock = DockStyle.Fill;
                chart.BackColor = Color.Transparent;

                //obtener lista del top
                List<User> u = new List<User>();
                u = ControllersGame.Top();
                if (u.Count == 0)
                {
                    throw new TopTenException("Not elements in DataBase!");
                }

                //creando grafica con campos vacios
                chart.Series = new SeriesCollection
                {
                    new RowSeries {Title = "Top 10", Values = new ChartValues<int>(), DataLabels = true}
                };
                chart.AxisY.Add(new Axis {Labels = new List<string>()});

                u.Reverse();
                chart.LegendLocation = LegendLocation.Bottom;

                //llenando campos de la grafico
                foreach (var x in u)
                {
                    chart.Series[0].Values.Add(x.point);
                    chart.AxisY[0].Labels.Add(x.name);
                }
                MessageBox.Show("Top 10");
            }
            catch (TopTenException)
            {
                MessageBox.Show("No hay elementos en la base de datos!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el top");
            }
        }

        
    }
}