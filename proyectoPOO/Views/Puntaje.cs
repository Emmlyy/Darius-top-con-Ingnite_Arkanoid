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
    public partial class Puntaje : UserControl
    {
        private CartesianChart chart;
        public Puntaje()
        {
            InitializeComponent();
            chart =new CartesianChart();
            this.Controls.Add(chart);
           

        }


        private void Puntaje_Load(object sender, EventArgs e)
        {
            try
            {
                chart.Top = 10;
                chart.Left = 10;
                chart.Width = 300;
                chart.Height = 300;
                chart.Dock = DockStyle.Fill;
                chart.BackColor = Color.Transparent;
                
                List<User> u = new List<User>();
                u = Obtener();
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
        private List<User> Obtener()
        {
            string sql = "SELECT \"UserID\", \"Points\" FROM public.\"User\" ORDER BY \"Points\" DESC FETCH FIRST 10 ROWS ONLY;";
            List<User> list = new List<User>();
            DataTable dt= Connection.Query(sql);
            foreach (DataRow fila in dt.Rows)
            {
                User u= new User();
                u.name = fila[0].ToString();
                u.point=Convert.ToInt32(fila[1].ToString());
                list.Add(u);
            }
            return list;
        }
    }
}