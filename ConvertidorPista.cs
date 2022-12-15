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
            if(value != null)
            {
            string respuesta = value.ToString();
            string pista ="";
            for(int i=0; i<respuesta.Length;i++)
            {
                if(i == 0 || i == respuesta.Length -1)
                {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                    pista += respuesta[i];
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
                }
                else
                {
#pragma warning disable S1643 // Strings should not be concatenated using '+' in a loop
                    pista += "*";
#pragma warning restore S1643 // Strings should not be concatenated using '+' in a loop
                }
                
            }
            return pista;
            }
            else
            {
                return " ";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
