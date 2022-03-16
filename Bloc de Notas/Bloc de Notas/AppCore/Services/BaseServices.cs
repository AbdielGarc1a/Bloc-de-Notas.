using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
   public abstract class BaseServices <T> : IServices<T>
    {
        private IModel<T> model;
        private IArchivoServices archSer;

        protected BaseServices(IModel<T> Archmodel)
        {
            this.model = Archmodel;
        }

        protected BaseServices(IArchivoServices archSer)
        {
            this.archSer = archSer;
        }

        public T Crear(string t)
        {
            return model.Crear(t);
        }

    }
}
