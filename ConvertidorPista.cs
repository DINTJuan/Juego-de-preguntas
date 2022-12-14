using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Juego_de_preguntas
{
    class ConvertidorPista : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string respuesta = value.ToString();
            string pista ="";
            for(int i=0; i<respuesta.Length;i++)
            {
                if(i == 0 || i == respuesta.Length -1)
                {
                    pista += respuesta[i];
                }
                else
                {
                    pista += "*";
                }
                
            }
            return pista;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
