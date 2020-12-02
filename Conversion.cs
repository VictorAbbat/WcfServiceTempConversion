using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTempConversion
{
    [BsonIgnoreExtraElements]
    [DataContract]
    class Conversion
    {
        [DataMember]
        public string userName;
        [DataMember]
        public string machineName;
        [DataMember]
        public double valeur;
        [DataMember]
        public DateTime dateAppel;
    }
}
