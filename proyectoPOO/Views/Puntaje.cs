using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace proyectoPOO
{
    public partial class Puntaje : UserControl
    {
        private CartesianChart grafico;
        public Puntaje()
        {
            InitializeComponent();
            grafico =new CartesianChart();
            this.Controls.Add(grafico);
           

        }


        private void Puntaje_Load(object sender, EventArgs e)
        {
            grafico.Top = 10;
            grafico.Left = 10;
            grafico.Width = grafico.Parent.Width - 20;
            grafico.Height = grafico.Parent.Height - 20;
            
            List<User> u =new List<User>();
            u = Obtener();
            grafico.Series = new SeriesCollection
            {new RowSeries()
                {
                    Title = "Points",
                    Values = new ChartValues<int> {}
                }
            };
            
            grafico.AxisY.Add(new Axis
            {
                Labels = new List<string>()
            });
            
            //poblar
            foreach (var x in u)
            {
                grafico.Series[0].Values.Add(x.point);
                grafico.AxisY[0].Labels.Add(x.name);
            }
            
        }

        private List<User> Obtener()
        {
            string sql = "SELECT name, points FROM user" +
                         "ORDER BY points DESC FETCH FIRST" +
                         "10 ROWS ONLY";
            List<User> list = new List<User>();
            /*DataTable dt= Connection.Query(sql);
            
            foreach (var fila in dt.Row)
            {
                list.name=fila[0].ToString();
                list.point=Convert.ToInt32(fila[1].ToString());
            }*/
            return list;
        }
    }
}