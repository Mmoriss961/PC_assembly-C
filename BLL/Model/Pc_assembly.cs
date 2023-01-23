namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;


    public class Pc_assemblyModel
    {
        public long Id_Pc_assembly { get; set; }

        //public string Id_user { get; set; }

        // public long? Id_user2 { get; set; }

        public long? Id_proc2 { get; set; }
        public long? Id_mboard2 { get; set; }
        public long? Id_case2 { get; set; }

        public long? Id_cooler2 { get; set; }

        public string Id_cooler { get; set; }
        public string Id_motherboard { get; set; }

        //public string Id_power_supply { get; set; }
        public string Id_case_pc { get; set; }


        public string Id_processor { get; set; }

        //public string Id_vga { get; set; }

        //public DateTime? Time_Assembly { get; set; }

        public int? Price_end { get; set; }

        public Pc_assemblyModel() { }
        public Pc_assemblyModel(Pc_assembly p_a)
        {
            //Id_Pc_assembly = p_a.Id_Pc_assembly;
            //Id_user = p_a.users.Name;
            //Id_cooler = p_a.cooler.Name;
            //Id_case_pc = p_a.case_pc.Name;
            Id_motherboard = p_a.Motherboard.Name;
            Id_processor = p_a.processor.Name;
            Id_case_pc = p_a.case_pc.Name;//
            //Id_cooler = p_a.cooler.Name;

            //Id_power_supply = p_a.power_supply.Name;
            //Id_vga = p_a.videocard.Name;
            //Time_Assembly = p_a.Time_Assembly;
            //Price_end = p_a.case_pc.Price_rub + p_a.cooler.Price_rub + p_a.Motherboard.Price_rub + p_a.power_supply.Price_rub + p_a.processor.Price_rub + p_a.videocard.Price_rub;
            // Id_user2 = p_a.Id_user;
            Id_proc2 = p_a.Id_processor;
            Id_mboard2 = p_a.Id_motherboard;
            Id_case2 = p_a.Id_case_pc;
            //Id_cooler2 = p_a.Id_cooler;//
            Price_end = p_a.processor.Price_rub + p_a.Motherboard.Price_rub + p_a.case_pc.Price_rub;
        }
    }
}
