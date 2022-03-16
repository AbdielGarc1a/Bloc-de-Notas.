using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ArchivoServices : BaseServices<DirectoryInfo>, IArchivoServices
    {
        IArchDirectorio ArchivoS;

        public ArchivoServices(IArchDirectorio archivosR) : base(archivosR)
        {
            this.ArchivoS = archivosR;
        }

        public bool Ruta(string path)
        {
            return ArchivoS.Ruta(path);
        }

        public DirectoryInfo get(string path)
        {
            return ArchivoS.get(path);
        }

    }

}