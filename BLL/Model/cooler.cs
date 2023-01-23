namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;


    public  class coolerModel
    {

        public long Id_cooler { get; set; }

        public string Name { get; set; }

        public int Cooler_height { get; set; }

        public int Cooler_Max_TDP { get; set; }

        public string Cooler_Socket { get; set; }

        public int Price_rub { get; set; }

        public coolerModel() { }
        public coolerModel(cooler co)
        {
            Id_cooler = co.Id_cooler;
            Name = co.Name;
            Cooler_height = co.Cooler_height;
            Cooler_Max_TDP = co.Cooler_Max_TDP;
            Cooler_Max_TDP = co.Cooler_Max_TDP;
            Cooler_Socket = co.Cooler_Socket;
            Price_rub = co.Price_rub;

        }

    }
}
