using BDDatenbankLibraryCRM.Database;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BDDatenbankLibraryCRM
{
    public class DataHelperBDDatenbankTabelle
    {

        public static string Lese_ConnectionString()
        {
            try
            {

                return BDDatenbankLibraryCRM.Properties.Settings.Default.ConnectionString;
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public static BDDatenbankTabelle Lese_mittelsDatenbankName_mittelsTabelleName_BDDatenbankTabelle(Session s, string datenbank, string tabelle)
        {
            try
            {
                return (from o in s.Query<BDDatenbankTabelle>()
                        where o.Datenbank == datenbank && o.Tabelle == tabelle
                        select o).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public static IQueryable<BDDatenbankTabelle> Lese_BDDatenbankTabelle(Session s)
        {
            try
            {
                return (from o in s.Query<BDDatenbankTabelle>()
                        select o);
            }
            catch (Exception ex)
            {
               
            }
            return null;
        }

        public static IQueryable<BDDatenbankTabelleFeld> Lese_BDDatenbankTabelleFeld(Session s)
        {
            try
            {
                return (from o in s.Query<BDDatenbankTabelleFeld>()
                        select o);
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public static IQueryable<BDDatenbankTabelleFeld> Lese_mittelsTabelle_BDDatenbankTabelleFelder(Session s, BDDatenbankTabelle tabelle)
        {
            try
            {
                return (from o in s.Query<BDDatenbankTabelleFeld>()
                        where o.Tabelle == tabelle
                        select o).OrderBy(x=>x.Feldname);
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public static bool Erstelle_mittelsTabelle_mittelsMetadata_BDDatenbankTabelleFeld(Session s, BDDatenbankTabelle tabelle, HelperClassMetadata hcMd)
        {
            try
            {

                //bdDtf.SQLServerDatentyp = hcMd.SQLServerDatentyp;
                HelperDatentypGenerisch hDtg = DataHelperBDDatenbankTabelle.Lese_mittelsDatentypName_DatentypGenerisch_ID(s, hcMd.GenerischerDatentyp);
                if (hDtg != null)
                {
                    BDDatenbankTabelleFeld bdDtf = new BDDatenbankTabelleFeld(s);
                    bdDtf.Tabelle = tabelle;
                    bdDtf.Feldname = hcMd.Feldname;
                    bdDtf.DatentypGenerisch = hDtg;
                    bdDtf.Feldlänge = hcMd.Feldlänge;
                    bdDtf.IstSchlüsselfeld = hcMd.IstSchlüsselfeld;
                    bdDtf.Save();
                    return true;
                }
                else
                {
                    Console.WriteLine("Datentyp nicht bekannt.");
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private static HelperDatentypGenerisch Lese_mittelsDatentypName_DatentypGenerisch_ID(Session s, string Datentyp)
        {
            try
            {
                return (from o in s.Query<HelperDatentypGenerisch>()
                        where o.Datentyp == Datentyp.ToLower()
                        select o).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
