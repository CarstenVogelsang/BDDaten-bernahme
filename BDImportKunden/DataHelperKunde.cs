using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.ComponentModel;
using System.Reflection;
using BDImportKunden.DB100;
using System.Linq.Expressions;
using DevExpress.Xpo.Metadata.Helpers;
using System.Collections;
using BDDatenbankLibraryCRM;
using BDDatenbankLibraryCRM.Database;


namespace BDImportKunden
{

    public class DataHelperKunde
    {

        public static IQueryable<KUND> LeseKunden()
        {
            try
            {
                return (from o in Session.DefaultSession.Query<KUND>() 
                        select o);
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public static KUND LeseKunde(string KundeKennung)
        {
            try
            {
                return (from o in Session.DefaultSession.Query<KUND>()
                        where o.Kunde == KundeKennung
                        select o).FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public static List<HelperClassMetadata> LeseMetadata(object obj)
        {
            List<HelperClassMetadata> liMetadata = new List<HelperClassMetadata>();
            XPClassInfo kundClassInfo = Session.DefaultSession.GetClassInfo(obj);
            foreach (XPMemberInfo m in kundClassInfo.PersistentProperties)
                if (!(m is ServiceField) && m.IsPersistent)
                {
                    if (!(m.IsKey && m.IsIdentity))
                    {
                        HelperClassMetadata md = new HelperClassMetadata();
                        md.Tabelle = m.Owner.TableName;
                        md.Feldname = m.Name;
                        md.IstSchlüsselfeld = m.IsKey ? true : false;
                        md.Feldlänge = m.MappingFieldSize;
                        md.GenerischerDatentyp = m.MemberType.Name;
                        //md.SQLServerDatentyp = "";
                        //md.Beschreibung = m.???;
                        liMetadata.Add(md);
                    }
                }
            return liMetadata;
        }




    }
}
