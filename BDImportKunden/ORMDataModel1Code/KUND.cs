using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace BDImportKunden.DB100
{

    public partial class KUND
    {
        public KUND(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
