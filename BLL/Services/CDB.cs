using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;

namespace BLL.Services
{
    public class CDB
    {

        public enum enAuthtorizationWindowType { Unknow = -1, AdminWindow = 1, ClienWindow = 2 }

        public CDB()
        {
            db = new Model1();
            db.Pc_assembly.Load();
            db.cooler.Load();
            db.DDR.Load();
            db.HDD.Load();
            db.Motherboard.Load();
            db.power_supply.Load();
            db.processor.Load();
            db.SSD.Load();
            db.users.Load();
            db.videocard.Load();
            db.case_pc.Load();


        }

        public List<case_pcModel> GetCase_pc()
        {
            return db.case_pc.ToList().Select(i => new case_pcModel(i)).ToList();

        }
        public List<Pc_assemblyModel> GetPc_Assemblies()
        {
            return db.Pc_assembly.ToList().Select(i => new Pc_assemblyModel(i)).ToList();

        }
        public List<coolerModel> GetCooler()
        {
            return db.cooler.ToList().Select(i => new coolerModel(i)).ToList();

        }
        public List<DDRModel> GetDDR()
        {
            return db.DDR.ToList().Select(i => new DDRModel(i)).ToList();

        }
        public List<HDDModel> GetHDD()
        {
            return db.HDD.ToList().Select(i => new HDDModel(i)).ToList();

        }
        public List<power_supplyModel> GetPower_supply()
        {
            return db.power_supply.ToList().Select(i => new power_supplyModel(i)).ToList();

        }
        public List<processorModel> GetProcessor()
        {
            return db.processor.ToList().Select(i => new processorModel(i)).ToList();

        }
        public List<SSDModel> GetSSD()
        {
            return db.SSD.ToList().Select(i => new SSDModel(i)).ToList();

        }
        public List<MotherboardModel> GetMotherboard()
        {
            return db.Motherboard.ToList().Select(i => new MotherboardModel(i)).ToList();

        }

        public List<usersModel> GetUsers()
        {
            return db.users.ToList().Select(i => new usersModel(i)).ToList();

        }
        public List<videocardModel> GetVideocard()
        {
            return db.videocard.ToList().Select(i => new videocardModel(i)).ToList();

        }

        public bool SetUser(string s)
        {
            if (s.Count() == 0) return false;
            sUser_ = s;
            return true;
        }
        public bool SetPass(string s)
        {
            if (s.Count() == 0) return false;
            sPass_ = s;
            return true;
        }
        public string GetUserName()
        {
            return UserName_;
        }
        public string GetUserSurname()
        {
            return UserSurname_;
        }

        public enAuthtorizationWindowType Authorization()
        {

            BD_connect db = new BD_connect();
            DataTable table = new DataTable();
            string Root = "";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Email` = @uL AND `Password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = sUser_;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = sPass_;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)

            {
                UserName_ = table.Rows[0][1].ToString();
                UserSurname_ = table.Rows[0][2].ToString();
                Root = table.Rows[0][5].ToString();
                if (Root == "1")
                {
                    return enAuthtorizationWindowType.AdminWindow;
                }
                else if (Root == "0")
                {
                    return enAuthtorizationWindowType.ClienWindow;
                }
                else
                {
                    return enAuthtorizationWindowType.Unknow;
                }
            }
            else
                return enAuthtorizationWindowType.Unknow;

        }

        public void CreateCase_pc(case_pcModel c_p)
        {

            db.case_pc.Add(new case_pc()
            {
                Name = c_p.Name,
                Max_height_cooler = c_p.Max_height_cooler,
                Integrated_power_supply = c_p.Integrated_power_supply,
                Max_length_video = c_p.Max_length_video,
                Form_factor_2_5 = c_p.Form_factor_2_5,
                Form_factor_3_5 = c_p.Form_factor_3_5,
                Form_factor_mboard = c_p.Form_factor_mboard,
                Price_rub = c_p.Price_rub
            });
            Save();
        }
        public void CreateSborka(Pc_assemblyModel c_p)
        {

            db.Pc_assembly.Add(new Pc_assembly()
            {
                Id_motherboard = c_p.Id_mboard2,
                Id_processor = c_p.Id_proc2,
                Id_case_pc = c_p.Id_case2,
                //Id_cooler = c_p.Id_cooler2,
                Price_end = c_p.Price_end
            });
            Save();
        }









        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public void DeleteCase_PC(int id)
        {
            case_pc p = db.case_pc.Find(id);
            if (p != null)
            {
                db.case_pc.Remove(p);
                Save();
            }
        }
        public void UpdateCase_PC(case_pcModel c_p)
        {
            case_pc ca = db.case_pc.Find(c_p.Id_case);
            ca.Name = c_p.Name;
            ca.Max_height_cooler = c_p.Max_height_cooler;
            ca.Integrated_power_supply = c_p.Integrated_power_supply;
            ca.Max_length_video = c_p.Max_length_video;
            ca.Form_factor_2_5 = c_p.Form_factor_2_5;
            ca.Form_factor_3_5 = c_p.Form_factor_3_5;
            ca.Form_factor_mboard = c_p.Form_factor_mboard;
            ca.Price_rub = c_p.Price_rub;
            Save();

        }
        private string sUser_;
        private string sPass_;
        private string UserName_;
        private string UserSurname_;
        private Model1 db;



    }

}



