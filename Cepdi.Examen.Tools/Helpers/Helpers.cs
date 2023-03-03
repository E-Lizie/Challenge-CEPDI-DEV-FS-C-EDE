using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cepdi.Tools.Helpers
{
    public static class Helpers
    {
        /// <summary>
        /// Convierte un archivo a un arreglo de string y elimina la cabezera
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns>Lista con los valores del archivo</returns>
        public static IEnumerable<string> OpenFile(string path) {

            var lines = File.ReadAllLines(path).ToList();

            lines.RemoveAt(0);

            return lines;

        }
    }
}
