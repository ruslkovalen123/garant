using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGarant.Models
{
    public class Request
    {
        [FromForm(Name = "zayavkaN")]
        public string NumberOfRequest { get; set; }

        [FromForm(Name ="dogovorN")]
        public string DogovorNumber { get; set; }

        [FromForm(Name = "transtype")]
        public string Transtype { get; set; }

        [FromForm(Name = "rejim")]
        public string Rejim { get; set; }

        [FromForm(Name = "otprfirm")]

        public string FullNameOfFirm { get; set; }

        [FromForm(Name = "perevname")]

        public string PerevName { get; set; }

        [FromForm(Name = "otpraddr")]
        public string AddressOfRequestor { get; set; }

        [FromForm(Name = "perevaddr")]

        public string PerevAddress { get; set; }

        [FromForm(Name = "perevboss")]

        public string PerevBoss { get; set; }

        [FromForm(Name = "otprboss")]

        public string OtprBoss { get; set; }

        [FromForm(Name = "cmr")]

        public string Cmr { get; set; }

        [FromForm(Name = "perevnum")]
        public string NumberOfVagon { get; set; }

        [FromForm(Name = "perevkont")]

        public string NumberOfContainer { get; set; }

        [FromForm(Name = "gruzname")]

        public string NameOfGruz { get; set; }

        [FromForm(Name = "start")]

        public string StartPoint { get; set; }

        [FromForm(Name = "uktved")]

        public string CODUkrZed { get; set; }

        [FromForm(Name = "startin")]

        public string PointOfArrival { get; set; }

        [FromForm(Name = "nomenkl")]

        public string NomenklVantag { get; set; }

        [FromForm(Name = "end")]

        public string EndPointOfArrival { get; set; }

        [FromForm(Name = "kol")]

        public string NumberOfVantag { get; set; }

        [FromForm(Name = "endin")]

        public string EndPointFromUkraine { get; set; }

        [FromForm(Name = "kolall")]

        public string OverallVantag { get; set; }

        [FromForm(Name = "dolg")]

        public string Dolg { get; set; }

        [FromForm(Name = "botlvol")]

        public string OneBottleVolume { get; set; }

        [FromForm(Name = "botlspirt")]

        public string OneBottleVolumeSpirt { get; set; }

        [FromForm(Name = "faktval")]

        public string FaktCost { get; set; }

        [FromForm(Name = "faktvaltr")]

        public string FaktCostTransport { get; set; }

        [FromForm(Name = "fio")]

        public string Fio { get; set; }

        [FromForm(Name = "tel")]

        public string Tel { get; set; }

        [FromForm(Name = "more")]

        public string More { get; set; }

        [FromForm(Name = "receivervantagzh")]
        public string ReceiverName { get; set; }

        [FromForm(Name = "receiveraddress")]

        public string ReceiverAddress { get; set; }

        [FromForm(Name = "edrpocod")]

        public string RecieverCod { get; set; }


    }
}
