using GestordeCasosPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestordeCasosPF.Library
{
    public class LTipoServicio
    {
        private ApplicationDbContext context;

        public LTipoServicio(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
