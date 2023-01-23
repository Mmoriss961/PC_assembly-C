namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;

    public class case_pcModel
    {

        public long Id_case { get; set; }

        public string Name { get; set; }

        public int Max_height_cooler { get; set; }

        public int? Integrated_power_supply { get; set; }

        public int Max_length_video { get; set; }

        public int Price_rub { get; set; }

        public int? Form_factor_2_5 { get; set; }

        public int? Form_factor_3_5 { get; set; }

        public string Form_factor_mboard { get; set; }

        public case_pcModel() { }
        public case_pcModel(case_pc c_p)
        {
            Id_case = c_p.Id_case;
            Name = c_p.Name;
            Max_height_cooler = c_p.Max_height_cooler;
            Integrated_power_supply = c_p.Integrated_power_supply;
            Max_length_video = c_p.Max_length_video;
            Form_factor_2_5 = c_p.Form_factor_2_5;
            Form_factor_3_5 = c_p.Form_factor_3_5;
            Form_factor_mboard = c_p.Form_factor_mboard;
            Price_rub = c_p.Price_rub;
        }

    }
}
