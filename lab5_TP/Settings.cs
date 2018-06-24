using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diagrams_lab5_
{
    public static class Settings
    {
        /// <summary>
        /// Color of diagram elements
        /// </summary>
        public static Color[] ColorOfDiagramMember = new Color[2] { Color.Black, Color.Green};
        /// <summary>
        /// Color of diagram markers
        /// </summary>
        public static Color[] ColorOfDiagramMarker =new Color[4] { Color.Red , Color.Orange, Color.Yellow, Color.Violet};
        /// <summary>
        /// Indicator of legend visible
        /// </summary>
        public static bool legend = true;
        /// <summary>
        /// Font for diagram
        /// </summary>
        public static Font fontOfDiagram = 
            new Font("Arial", 12.0f ,FontStyle.Regular);
        /// <summary>
        /// Persentage array of inflation
        /// </summary>
        public static double[][] amountOfWages = null;
        /// <summary>
        /// Years array info
        /// </summary>
        public static int[][] yeras = null;
        /// <summary>
        /// Chat stile
        /// </summary>
        public static SeriesChartType typeOfChart = SeriesChartType.Column;
        /// <summary>
        /// Enable 3D
        /// </summary>
        public static bool enable3D = false;
        /// <summary>
        /// set marker style
        /// </summary>
        public static MarkerStyle[] Mstyle = new MarkerStyle[4]
                           { MarkerStyle.None,MarkerStyle.None, MarkerStyle.Cross, MarkerStyle.Square};
        /// <summary>
        /// Number of series
        /// </summary>
        public static int SeriesNum = 1;
        /// <summary>
        /// Enable secont chart
        /// </summary>
        public static bool TwoCharts = false;

        public static bool FourCharts = false;
    }
}
