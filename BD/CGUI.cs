using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public class CGUI
    {

        ////public bool OpenWindow(System.Windows.Forms.Form frm)
        ////{
        ////    if (frm == null) return false;
        ////    frm.Show();
        ////    return true;
        ////}

        //#region loginForm


        //public CGUI(LoginForm loginForm)
        //{
        //    this.loginForm = loginForm;
        //}




        //public void button1_Click()
        //{
        //    if (CDBObj_ == null) return;

        //    CDBObj_.SetUser(loginForm.Login.Text);
        //    CDBObj_.SetPass(loginForm.Password.Text);
        //    var venAuthorizationWindowType = CDBObj_.Authorization();
        //    string sUserName = CDBObj_.GetUserName();
        //    string sUserSurname = CDBObj_.GetUserSurname();


        //    if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.Unknow)
        //        MessageBox.Show("Такой пользователь не найден.Проверьте правильность вводимых данных и повторите попытку.");

        //    if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.AdminWindow)
        //    {

        //        loginForm.Hide();
        //        AdminMainForm adminMainForm = new AdminMainForm();
        //        adminMainForm.Username.Text = "Здравствуйте," + "  "+ sUserName +"  "+ sUserSurname;
        //        //adminMainForm.Usersurname.Text = sUserSurname;
        //        adminMainForm.Show();


        //    }

        //    else if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.ClienWindow)
        //    {
        //        loginForm.Hide();
        //        ClienMainForm clienMainForm = new ClienMainForm();
        //        clienMainForm.Show();


        //    }

        //}

        //#endregion
        //private Thread th;
        //private BLL.Services.CDB CDBObj_ = new BLL.Services.CDB();
        //private LoginForm loginForm = new LoginForm();
    }
}
