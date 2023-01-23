namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;

    public  class HDDModel
    {

        public long Id_HDD { get; set; }

        public string Name { get; set; }

        public int HDD_volume { get; set; }

        public int Price_rub { get; set; }

        public int HDD_read_speed { get; set; }

        public int HDD_write_speed { get; set; }

        public HDDModel() { }
        public HDDModel(HDD hd)
        {
            Id_HDD = hd.Id_HDD;
            Name = hd.Name;
            HDD_volume = hd.HDD_volume;
            Price_rub = hd.Price_rub;
            HDD_read_speed = hd.HDD_read_speed;
            HDD_write_speed = hd.HDD_write_speed;

        }

    }
}
