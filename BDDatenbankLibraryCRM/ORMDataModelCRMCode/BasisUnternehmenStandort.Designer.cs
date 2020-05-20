﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace BDDatenbankLibraryCRM.Database
{

    public partial class BasisUnternehmenStandort : XPCustomObject
    {
        Guid fOid;
        [Key(true)]
        public Guid Oid
        {
            get { return fOid; }
            set { SetPropertyValue<Guid>(nameof(Oid), ref fOid, value); }
        }
        Guid fStandortTyp;
        [Indexed(Name = @"iStandortTyp_BasisUnternehmenStandort")]
        public Guid StandortTyp
        {
            get { return fStandortTyp; }
            set { SetPropertyValue<Guid>(nameof(StandortTyp), ref fStandortTyp, value); }
        }
        Guid fUnternehmen;
        [Indexed(Name = @"iUnternehmen_BasisUnternehmenStandort")]
        public Guid Unternehmen
        {
            get { return fUnternehmen; }
            set { SetPropertyValue<Guid>(nameof(Unternehmen), ref fUnternehmen, value); }
        }
        GeoAdresse fStandortAdresse;
        [Indexed(Name = @"iStandortAdresse_BasisUnternehmenStandort")]
        [Association(@"BasisUnternehmenStandortReferencesGeoAdresse")]
        public GeoAdresse StandortAdresse
        {
            get { return fStandortAdresse; }
            set { SetPropertyValue<GeoAdresse>(nameof(StandortAdresse), ref fStandortAdresse, value); }
        }
        bool fIstZentrale;
        public bool IstZentrale
        {
            get { return fIstZentrale; }
            set { SetPropertyValue<bool>(nameof(IstZentrale), ref fIstZentrale, value); }
        }
    }

}