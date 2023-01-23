namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;


    public  class DDRModel
    {
        public long Id_DDR { get; set; }

        public string Name { get; set; }

        public int DDR_type { get; set; }

        public int DDR_frenquency { get; set; }

        public int DDR_quantity { get; set; }

        public int DDR_size { get; set; }

        public int DDR_rub { get; set; }

        public DDRModel() { }
        public DDRModel(DDR dd)
        {
            Id_DDR = dd.Id_DDR;
            Name = dd.Name;
            DDR_type = dd.DDR_type;
            DDR_frenquency = dd.DDR_frenquency;
            DDR_quantity = dd.DDR_quantity;
            DDR_size = dd.DDR_size;
            DDR_rub = dd.DDR_rub;

        }
    }
}
