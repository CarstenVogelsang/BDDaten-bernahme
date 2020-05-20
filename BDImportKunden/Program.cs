using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using BDDatenbankLibraryCRM;
using BDDatenbankLibraryCRM.Database;
using DevExpress.Xpo.Metadata;

namespace BDImportKunden
{

    static class Program
    {

        //public static IDataLayer DB100 { get; private set; }
        public static IDataLayer DBBDDatenbankLibraryCRM { get; private set; }

        public static Session _sDB100;
        public static Session _sBDDatenbankLibraryCRM;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connectionStringDBPortal = DataHelperBDDatenbankTabelle.Lese_ConnectionString();

            //XPDictionary dict1 = new ReflectionDictionary();
            //dict1.CollectClassInfos(typeof(Class1), typeof(Class2), ...);  
            //IDataStore prov1 = XpoDefault.GetConnectionProvider(connectionString1, AutoCreateOption.None);
            //DB100 = new SimpleDataLayer(dict1, prov1);

            //XPDictionary dict2 = new ReflectionDictionary();
            //dict2.CollectClassInfos(typeof(Class3), typeof(Class4), ...);  
            IDataStore prov2 = XpoDefault.GetConnectionProvider(connectionStringDBPortal, AutoCreateOption.None);
            DBBDDatenbankLibraryCRM = new SimpleDataLayer(prov2);

            //Session session1 = new Session(DB1);
            _sBDDatenbankLibraryCRM = new Session(DBBDDatenbankLibraryCRM);

            //DB100.ConnectionHelper.Connect(AutoCreateOption.None);
            XpoDefault.DataLayer = DB100.ConnectionHelper.GetDataLayer(AutoCreateOption.None);
            _sDB100 = Session.DefaultSession;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            Application.Run(new Form1());

        }
    }
}