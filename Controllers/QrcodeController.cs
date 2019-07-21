using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_Alert.Controllers
{
    // QrcodeController

    public class QrcodeController : Controller
    {
        public IActionResult QrCodeScan()
        {
            return View();
        }

       
    }

}
