using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaArea
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /**/
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           /* float radioc = float.Parse(radio.Text);
            float PI = 3.1416f;
            float areatotal3 = PI * (radioc * radioc);
            area3.Text = areatotal3.ToString();*/
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            /**/
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectangulo
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1: //Triangulo
                    panelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                case 2: //Circulo
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 3: //Trapecio
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectangulo
                    var ControlAreaRectangulo = (ControlAreaRectangulo)panelConfiguracion.Children[0];

                    float baser = float.Parse(ControlAreaRectangulo.base1.Text);
                    float alturar = float.Parse(ControlAreaRectangulo.altura1.Text);
                    area = baser * alturar;
                    break;

                case 1: //Triangulo
                    var ControlAreaTriangulo = (ControlAreaTriangulo)panelConfiguracion.Children[0];

                    float baset = float.Parse(ControlAreaTriangulo.base2.Text);
                    float alturat = float.Parse(ControlAreaTriangulo.altura2.Text);
                    area = (baset * alturat) / 2;
                    break;

                case 2: //Circulo
                    var ControlAreaCirculo = (ControlAreaCirculo)panelConfiguracion.Children[0];

                    float radio = float.Parse(ControlAreaCirculo.radio.Text);
                    area = 3.14159f * radio * radio;
                    break;

                case 3://Trapecio
                    var ControlAreaTrapecio = (ControlAreaTrapecio)panelConfiguracion.Children[0];

                    float alturatr = float.Parse(ControlAreaTrapecio.altura3.Text);
                    float basemayortr = float.Parse(ControlAreaTrapecio.basemayor.Text);
                    float basemenortr = float.Parse(ControlAreaTrapecio.basemenor.Text);
                    area = alturatr * ((basemayortr + basemenortr) / 2);
                    break;

                default:
                    break;
            }
            lblResultadoArea.Text = area.ToString();
        }
    }
}
