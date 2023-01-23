using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ReportPCA
    {


        public class ReportData
        {
            public long? Id { get; set; }
            public string Name_user2 { get; set; }
            public DateTime? Date { get; set; }
            public string Email { get; set; }
            public int? Price_end { get; set; }

        }
        public class sborka
        {
            public string socket { get; set; }
            public string ff { get; set;}
        
        }

        public static List<ReportData> GetReportPcAssembly(DateTime dateTime, DateTime dateTime2)
        {
            Model1 db = new Model1();
            Pc_assembly p = new Pc_assembly();

            var qwe = db.Pc_assembly

            .Join(db.users, ph => ph.Id_user, m => m.Id_user, (ph, m) => ph)
            .Where(i => i.Time_Assembly >= dateTime && i.Time_Assembly <= dateTime2)
            .Select(a => new ReportData() { Id = a.Id_user, Name_user2 = a.users.Name + "  " + a.users.Surname, Email = a.users.Email, Date = a.Time_Assembly, Price_end = a.case_pc.Price_rub + a.cooler.Price_rub + a.Motherboard.Price_rub + a.power_supply.Price_rub + a.processor.Price_rub + a.videocard.Price_rub }).ToList();
            return qwe;

        }

        public static string  GetSocketProc(int Id)
        {
            Model1 db = new Model1();
   
            string qwe = db.processor
            .Where(i => i.Id_proc == Id)
            .OrderBy(i => i.Price_rub)
            .Select(i => i.Socket).FirstOrDefault().ToString();
            
            return qwe;
        }

        public static long GetFinMboard(string soc)
        {
            Model1 db = new Model1();

            long qwe = db.Motherboard
            .Where(i => i.Mboard_socket == soc)
            .OrderBy(i => i.Price_rub)
            .Select(i => i.Id_mboard).FirstOrDefault();

            return qwe;
        }

        public static string GetSizeMboard(int Id)
        {
            Model1 db = new Model1();

            string qwe = db.Motherboard
            .Where(i => i.Id_mboard ==Id)
            .Select(i => i.Mboard_size).FirstOrDefault().ToString();

            return qwe;
        }

        public static long GetFinCasePC(string ff)
        {
            Model1 db = new Model1();

            long qwe = db.case_pc
            .Where(i => i.Form_factor_mboard == ff)
            .OrderBy(i => i.Price_rub)
            .Select(i => i.Id_case).FirstOrDefault();

            return qwe;
        }

        //public static int GetMaxcoolerCasePC(int hf)
        //{
        //    Model1 db = new Model1();

        //    int qwe1 = db.case_pc
        //    .Where(i => i.Id_case == hf)
        //    .Select(i => i.Max_height_cooler).FirstOrDefault();

        //    return qwe1;
        //}

        //public static long GetFinCooler(int h,string cs)
        //{
        //    Model1 db = new Model1();
        //    long qwe = db.cooler
        //    .Where(i =>i.Cooler_height <=h && i.Cooler_Socket == cs)
        //    .OrderBy(i => i.Price_rub)
        //    .Select(i => i.Id_cooler).FirstOrDefault();

        //    return qwe;
        //}

    }
}
