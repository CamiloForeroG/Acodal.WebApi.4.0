using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CongresoAcodalRepository : CongresoAcodalEntities
    {
        public CongresoAcodalRepository()
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
