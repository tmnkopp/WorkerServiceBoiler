using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSB.Web.Models
{
    public class Settings
    {
        public string BasketIdCookieName => "BasketId";
        public Guid UserId => Guid.Parse("{E455A3DF-7FA5-47E0-8435-179B300D531F}");
    }
}
