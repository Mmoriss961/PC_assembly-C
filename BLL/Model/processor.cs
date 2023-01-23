namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;


    public  class processorModel
    {

        public long Id_proc { get; set; }
        public string Name { get; set; }

        public string Socket { get; set; }

        public int Number_cores { get; set; }

        public int Proc_Frequency { get; set; }

        public int Price_rub { get; set; }

        public int TDP { get; set; }

        public int Proc_benchmark { get; set; }

        public int Proc_max_frenquency_DDR { get; set; }

        public int Proc_DDR { get; set; }

        public int Proc_max_syze_DDR { get; set; }

        public processorModel() { }
        public processorModel(processor pr)
        {
            Id_proc = pr.Id_proc;
            Name = pr.Name;
            Socket = pr.Socket;
            Number_cores = pr.Number_cores;
            Proc_Frequency = pr.Proc_Frequency;
            Price_rub = pr.Price_rub;
            TDP = pr.TDP;
            Proc_benchmark = pr.Proc_benchmark;
            Proc_max_frenquency_DDR = pr.Proc_max_frenquency_DDR;
            Proc_DDR = pr.Proc_DDR;
            Proc_max_syze_DDR = pr.Proc_max_syze_DDR;
        }


    }
}
