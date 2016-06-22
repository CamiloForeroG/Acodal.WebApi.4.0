using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repository;

namespace Business
{
    public class CongressBusiness
    {
        CongresoAcodalRepository DB = new CongresoAcodalRepository();

        public object GetConferences() {
            var Conferences = (
                from c in DB.Conferencias
                select new
                {
                    c.Id,
                    c.Nombre,
                    Salon = c.Salone.Salon,
                    c.HoraInicio,
                    c.HoraFin,
                    Expositores = c.Expositors.Select(p => new { p.Nombre, pais = p.Pai.Pais })
                }
                );

            return Conferences;

        }
    }
}
