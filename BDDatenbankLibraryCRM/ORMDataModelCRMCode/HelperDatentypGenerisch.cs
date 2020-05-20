using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace BDDatenbankLibraryCRM.Database
{

    public partial class HelperDatentypGenerisch
    {
        public HelperDatentypGenerisch(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
