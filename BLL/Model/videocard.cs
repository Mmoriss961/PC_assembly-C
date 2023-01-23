namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;

    public  class videocardModel
    {
        public long Id_vga { get; set; }

        public string Name { get; set; }

        public int Video_frequency { get; set; }

        public int Memory_type { get; set; }

        public int Memory_frequency { get; set; }

        public int Video_memory { get; set; }

        public int Video_benchmark { get; set; }

        public int Power_supply_unit { get; set; }

        public int Video_length { get; set; }

        public int Price_rub { get; set; }

        public int Video_PCI_e { get; set; }

        public videocardModel() { }
        public videocardModel(videocard vi)
        {
            Id_vga = vi.Id_vga;
            Name = vi.Name;
            Video_frequency = vi.Video_frequency;
            Memory_type = vi.Memory_type;
            Memory_frequency = vi.Memory_frequency;
            Video_memory = vi.Video_memory;
            Video_benchmark = vi.Video_benchmark;
            Power_supply_unit = vi.Power_supply_unit;
            Video_length = vi.Video_length;
            Price_rub = vi.Price_rub;
            Video_PCI_e = vi.Video_PCI_e;
        }


    }
}
