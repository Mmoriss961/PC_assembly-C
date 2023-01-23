namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;

    public class SSDModel
    {

        public long Id_SSD { get; set; }

        public string Name { get; set; }

        public string Form_factor { get; set; }

        public int Price_rub { get; set; }

        public int SSD_connection_interface { get; set; }

        public int SSD_read_speed { get; set; }

        public int SSD_write_speed { get; set; }

        public int SSD_volume { get; set; }

        public SSDModel() { }
        public SSDModel(SSD ss)
        {
            Id_SSD = ss.Id_SSD;
            Name = ss.Name;
            Form_factor = ss.Form_factor;
            Price_rub = ss.Price_rub;
            SSD_connection_interface = ss.SSD_connection_interface;
            SSD_read_speed = ss.SSD_read_speed;
            SSD_write_speed = ss.SSD_write_speed;
            SSD_volume = ss.SSD_volume;

        }


    }
}
