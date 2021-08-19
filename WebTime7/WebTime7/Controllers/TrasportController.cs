using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTime7.Models;
using WebTime7.Repository;

namespace WebTime7.Controllers
{
    public class TrasportController : BaseController<TrasportModel,TrasportRepository>
    {
        public TrasportController()
        {

        }
    }
}
