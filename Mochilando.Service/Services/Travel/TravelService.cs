using Mochilando.Tools.DTO.Travel;
using Mochilando.Tools.Repository.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mochilando.Service.Services.Travel
{
    public class TravelService
    {
        private ITravelRepository _travelRepository;

        public TravelService(ITravelRepository travelRepository)
        {
            _travelRepository = travelRepository;
        }

        public async Task<bool> Insert(TravelDto travel)
        {
            try
            {
                await _travelRepository.Save(travel);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
