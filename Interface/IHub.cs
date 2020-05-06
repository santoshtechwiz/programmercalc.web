using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programmercalc.web.Interface
{
    public interface IHub
    {
        Task SendMessage( string message);
    }
}
