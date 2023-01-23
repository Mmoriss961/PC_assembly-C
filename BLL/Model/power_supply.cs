namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;

    public class power_supplyModel
    {
        public long Id__power_supply { get; set; }

        public string Name { get; set; }

        public int Power_supply__power { get; set; }

        public int Power_supply_PCI_E { get; set; }

        public int Price_rub { get; set; }

        public power_supplyModel() { }
        public power_supplyModel(power_supply p_s)
        {
            Id__power_supply = p_s.Id__power_supply;
            Name = p_s.Name;
            Power_supply__power = p_s.Power_supply__power;
            Power_supply_PCI_E = p_s.Power_supply_PCI_E;
            Price_rub = p_s.Price_rub;
        }

    }
}
