using Acodal.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace Acodal.WebApi.Controllers
{
    public class ConferenceServiceController : ApiController
    {
        ConferenceServiceModel CsModel = new ConferenceServiceModel();

        public Object Get() {
            var Conferencias = CsModel.ManagerCB.GetConferences();
            return Conferencias;
        }
    }
}
