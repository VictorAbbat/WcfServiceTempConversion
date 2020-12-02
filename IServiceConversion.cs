using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTempConversion
{
    [ServiceContract]
    interface IServiceConversion
    {
        [OperationContract]
        double ConvertirVersCelcius(double temp, string userName, string machineName);

        [OperationContract]
        double ConvertirVersFarh(double temp, string userName, string machineName);

        [OperationContract]
        List<Conversion> GetAll();
    }
}
