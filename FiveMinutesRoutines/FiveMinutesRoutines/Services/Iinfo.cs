using System;
using FiveMinutesRoutines.Business;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveMinutesRoutines.Services
{
    public interface IInfo 
    {
    
            Task<IList<Info>> GetInfoGroups();
        
    }
}
