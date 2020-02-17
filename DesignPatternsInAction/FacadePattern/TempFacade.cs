using FacadePattern.ExternalServices;

namespace FacadePattern
{
    public class TempFacade
    {
        public int GetTemp(string postalCode)
        {
            var zoneFinder = new ZoneFinder();
            var zone = zoneFinder.GetZone(postalCode);
            var tempratureService = new TempratureService();
            var tempf = tempratureService.GetTemp(zone);
            var tempConvertor = new TempConvertor();
            var finalTemp = tempConvertor.GetS(tempf);
            return finalTemp;
        }
    }
}