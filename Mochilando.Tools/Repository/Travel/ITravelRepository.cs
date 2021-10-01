using Mochilando.Tools.DTO.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mochilando.Tools.Repository.Travel
{
    public interface ITravelRepository
    {
        Task Save(TravelDto travel);
    }
}
