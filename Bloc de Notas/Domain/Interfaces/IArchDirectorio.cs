using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IArchDirectorio: IModel<DirectoryInfo>
    {
        bool Ruta(string path);

        DirectoryInfo get(string path);

    }
}
