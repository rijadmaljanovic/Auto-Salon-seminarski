using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class SMSMessageVM
    {
        public string To { get; set; }
        public string ContentMsg { get; set; }
        public string PhoneNumber { get; set; }
    }
}
