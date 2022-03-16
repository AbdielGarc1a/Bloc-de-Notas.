using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
   public interface IArchivoServices: IModel <DirectoryInfo>
    {
        bool Ruta(string path);

        DirectoryInfo get(string path);
    }
}
