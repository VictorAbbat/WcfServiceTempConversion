using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceTempConversion
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ServiceConversion : IServiceConversion
    {
        public double ConvertirVersCelcius(double temp, string userName, string machineName)
        {
            Conversion conversion = new Conversion
            {
                userName = userName,
                machineName = machineName,
                dateAppel = DateTime.Now,
                valeur = temp
            };
            Dao.InsertAppel(conversion);
            return (temp - 32) / 2.0;
        }

        public double ConvertirVersFarh(double temp, string userName, string machineName)
        {
            Conversion conversion = new Conversion
            {
                userName = userName,
                machineName = machineName,
                dateAppel = DateTime.Now,
                valeur = temp
            };
            Dao.InsertAppel(conversion);
            return (2.0 * temp + 32);
        }

        public List<Conversion> GetAll()
        {
            return Dao.GetAppel();
        }
    }
}
