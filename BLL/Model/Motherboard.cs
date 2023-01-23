namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;
    public class MotherboardModel
    {
        public long Id_mboard { get; set; }
        public string Name { get; set; }
        public string Mboard_size { get; set; }

        public int Mboard_DDR { get; set; }

        public int Mboard_max_DDR { get; set; }

        public int Mboard_max_frenquency_DDR { get; set; }

        public int Price_rub { get; set; }

        public string Mboard_socket { get; set; }

        public int? Mboard_M2 { get; set; }

        public int Mboard_Sata_III { get; set; }

        public MotherboardModel() { }
        public MotherboardModel(Motherboard mo)
        {
            Id_mboard = mo.Id_mboard;
            Name = mo.Name;
            Mboard_size = mo.Mboard_size;
            Price_rub = mo.Price_rub;
            Mboard_DDR = mo.Mboard_DDR;
            Mboard_max_DDR = mo.Mboard_max_DDR;
            Mboard_max_frenquency_DDR = mo.Mboard_max_frenquency_DDR;
            Mboard_socket = mo.Mboard_socket;
            Mboard_M2 = mo.Mboard_M2;
            Mboard_Sata_III = mo.Mboard_Sata_III;

        }
    }
}
