using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo.Metadata.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDImportKunden
{
    class HelperCommon
    {

        public string[] GetObjectProperties(Type objectType)
        {
            XPClassInfo classInfo = Session.DefaultSession.Dictionary.GetClassInfo(objectType);
            if (classInfo != null)
                return GetObjectProperties(classInfo, new ArrayList());
            return new string[] { };
        }

        public string[] GetObjectProperties(XPClassInfo xpoInfo, ArrayList processed)
        {
            if (processed.Contains(xpoInfo)) return new string[] { };
            processed.Add(xpoInfo);
            ArrayList result = new ArrayList();
            foreach (XPMemberInfo m in xpoInfo.PersistentProperties)
                if (!(m is ServiceField) && m.IsPersistent)
                {
                    result.Add(m.Name);
                    if (m.ReferenceType != null)
                    {
                        string[] childProps = GetObjectProperties(m.ReferenceType, processed);
                        foreach (string child in childProps)
                            result.Add(string.Format("{0}.{1}", m.Name, child));
                    }
                }

            foreach (XPMemberInfo m in xpoInfo.CollectionProperties)
            {
                string[] childProps = GetObjectProperties(m.CollectionElementType, processed);
                foreach (string child in childProps)
                    result.Add(string.Format("{0}.{1}", m.Name, child));
            }
            return result.ToArray(typeof(string)) as string[];
        }

    }
}
