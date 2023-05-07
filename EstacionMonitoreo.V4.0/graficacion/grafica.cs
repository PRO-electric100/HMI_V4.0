using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace EstacionMonitoreo.V4._0.graficacion
{
    class grafica
    {
        double x;
        double y;
        int serie_N=0;
        public void pxy(double valor1, double valor2, int numS)
        {
            x = valor1;
            y = valor2;
            serie_N = numS;
        }
        public void grafico(Chart ejemplo)
        {
            //ejemplo.ChartAreas[0].Area3DStyle.Enable3D = true;        grafciacion tridimencional      
            if (ejemplo.Series[serie_N].Points.Count>50)
            {
                ejemplo.Series[serie_N].Points.RemoveAt(0);
                ejemplo.Update();
            }
            ejemplo.Series[serie_N].Points.AddXY(x, y);
        }
    }
}
