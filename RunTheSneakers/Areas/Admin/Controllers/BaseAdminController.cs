using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace RunTheSneakers.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Authorize(Roles = "Admin")]
    public abstract class BaseAdminController : Controller
    {
        //controller is mostly required to provide
        //area and identity annotations to all controllers
        // in the folder
    }
}