using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
   public class ArchivoDirecRepository: IArchDirectorio
    {

        private StreamReader streamreader;
        private BinaryReader streambinary;

        public bool Ruta(string path)
        {
            if (Path.HasExtension(path))
            {
                return true;
            }
            return false;
        }

    
        public DirectoryInfo get(string t)
        {
            return new DirectoryInfo(t);
        }
        public DirectoryInfo Crear(string t)
        {
            DirectoryInfo texto = new DirectoryInfo(t);

            return Directory.CreateDirectory(t);
        }


    }
}
