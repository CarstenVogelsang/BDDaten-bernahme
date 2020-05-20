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
namespace BDImportKunden.DB100
{

    public partial class KUND : XPLiteObject
    {
        string fKunde;
        /// <summary>
        /// Eindeutiges Schlüssel-Feld
        /// </summary>
        [Key]
        [Size(15)]
        public string Kunde
        {
            get { return fKunde; }
            set { SetPropertyValue<string>(nameof(Kunde), ref fKunde, value); }
        }
        string fAnrede;
        /// <summary>
        /// Dr, / Herr / Frau
        /// </summary>
        [Size(10)]
        public string Anrede
        {
            get { return fAnrede; }
            set { SetPropertyValue<string>(nameof(Anrede), ref fAnrede, value); }
        }
        string fAnredetext;
        [Size(50)]
        public string Anredetext
        {
            get { return fAnredetext; }
            set { SetPropertyValue<string>(nameof(Anredetext), ref fAnredetext, value); }
        }
        string fName;
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fName2;
        public string Name2
        {
            get { return fName2; }
            set { SetPropertyValue<string>(nameof(Name2), ref fName2, value); }
        }
        string fVorname;
        [Size(50)]
        public string Vorname
        {
            get { return fVorname; }
            set { SetPropertyValue<string>(nameof(Vorname), ref fVorname, value); }
        }
        string fStrasse;
        [Size(50)]
        public string Strasse
        {
            get { return fStrasse; }
            set { SetPropertyValue<string>(nameof(Strasse), ref fStrasse, value); }
        }
        string fPlz;
        [Size(15)]
        public string Plz
        {
            get { return fPlz; }
            set { SetPropertyValue<string>(nameof(Plz), ref fPlz, value); }
        }
        string fOrt;
        [Size(50)]
        public string Ort
        {
            get { return fOrt; }
            set { SetPropertyValue<string>(nameof(Ort), ref fOrt, value); }
        }
        string fLand;
        [Size(30)]
        public string Land
        {
            get { return fLand; }
            set { SetPropertyValue<string>(nameof(Land), ref fLand, value); }
        }
        string fTelefon1;
        [Size(40)]
        public string Telefon1
        {
            get { return fTelefon1; }
            set { SetPropertyValue<string>(nameof(Telefon1), ref fTelefon1, value); }
        }
        string fTelefon2;
        [Size(40)]
        public string Telefon2
        {
            get { return fTelefon2; }
            set { SetPropertyValue<string>(nameof(Telefon2), ref fTelefon2, value); }
        }
        string fTelefon3;
        [Size(40)]
        public string Telefon3
        {
            get { return fTelefon3; }
            set { SetPropertyValue<string>(nameof(Telefon3), ref fTelefon3, value); }
        }
        string fTelefax;
        [Size(40)]
        public string Telefax
        {
            get { return fTelefax; }
            set { SetPropertyValue<string>(nameof(Telefax), ref fTelefax, value); }
        }
        string fEMail1;
        [Size(50)]
        public string EMail1
        {
            get { return fEMail1; }
            set { SetPropertyValue<string>(nameof(EMail1), ref fEMail1, value); }
        }
        string fEMail2;
        [Size(50)]
        public string EMail2
        {
            get { return fEMail2; }
            set { SetPropertyValue<string>(nameof(EMail2), ref fEMail2, value); }
        }
        decimal fAuftragsSperre;
        public decimal AuftragsSperre
        {
            get { return fAuftragsSperre; }
            set { SetPropertyValue<decimal>(nameof(AuftragsSperre), ref fAuftragsSperre, value); }
        }
        DateTime fKundeSeit;
        public DateTime KundeSeit
        {
            get { return fKundeSeit; }
            set { SetPropertyValue<DateTime>(nameof(KundeSeit), ref fKundeSeit, value); }
        }
        string fNameGeb1;
        [Size(30)]
        public string NameGeb1
        {
            get { return fNameGeb1; }
            set { SetPropertyValue<string>(nameof(NameGeb1), ref fNameGeb1, value); }
        }
        DateTime fGeburtsdatum1;
        public DateTime Geburtsdatum1
        {
            get { return fGeburtsdatum1; }
            set { SetPropertyValue<DateTime>(nameof(Geburtsdatum1), ref fGeburtsdatum1, value); }
        }
        decimal fWeckerAktiv1;
        public decimal WeckerAktiv1
        {
            get { return fWeckerAktiv1; }
            set { SetPropertyValue<decimal>(nameof(WeckerAktiv1), ref fWeckerAktiv1, value); }
        }
        string fNameGeb2;
        [Size(30)]
        public string NameGeb2
        {
            get { return fNameGeb2; }
            set { SetPropertyValue<string>(nameof(NameGeb2), ref fNameGeb2, value); }
        }
        DateTime fGeburtsdatum2;
        public DateTime Geburtsdatum2
        {
            get { return fGeburtsdatum2; }
            set { SetPropertyValue<DateTime>(nameof(Geburtsdatum2), ref fGeburtsdatum2, value); }
        }
        decimal fWeckerAktiv2;
        public decimal WeckerAktiv2
        {
            get { return fWeckerAktiv2; }
            set { SetPropertyValue<decimal>(nameof(WeckerAktiv2), ref fWeckerAktiv2, value); }
        }
        string fNameGeb3;
        [Size(30)]
        public string NameGeb3
        {
            get { return fNameGeb3; }
            set { SetPropertyValue<string>(nameof(NameGeb3), ref fNameGeb3, value); }
        }
        DateTime fGeburtsdatum3;
        public DateTime Geburtsdatum3
        {
            get { return fGeburtsdatum3; }
            set { SetPropertyValue<DateTime>(nameof(Geburtsdatum3), ref fGeburtsdatum3, value); }
        }
        decimal fWeckerAktiv3;
        public decimal WeckerAktiv3
        {
            get { return fWeckerAktiv3; }
            set { SetPropertyValue<decimal>(nameof(WeckerAktiv3), ref fWeckerAktiv3, value); }
        }
        string fNameGeb4;
        [Size(30)]
        public string NameGeb4
        {
            get { return fNameGeb4; }
            set { SetPropertyValue<string>(nameof(NameGeb4), ref fNameGeb4, value); }
        }
        DateTime fGeburtsdatum4;
        public DateTime Geburtsdatum4
        {
            get { return fGeburtsdatum4; }
            set { SetPropertyValue<DateTime>(nameof(Geburtsdatum4), ref fGeburtsdatum4, value); }
        }
        decimal fWeckerAktiv4;
        public decimal WeckerAktiv4
        {
            get { return fWeckerAktiv4; }
            set { SetPropertyValue<decimal>(nameof(WeckerAktiv4), ref fWeckerAktiv4, value); }
        }
        string fNameGeb5;
        [Size(30)]
        public string NameGeb5
        {
            get { return fNameGeb5; }
            set { SetPropertyValue<string>(nameof(NameGeb5), ref fNameGeb5, value); }
        }
        DateTime fGeburtsdatum5;
        public DateTime Geburtsdatum5
        {
            get { return fGeburtsdatum5; }
            set { SetPropertyValue<DateTime>(nameof(Geburtsdatum5), ref fGeburtsdatum5, value); }
        }
        decimal fWeckerAktiv5;
        public decimal WeckerAktiv5
        {
            get { return fWeckerAktiv5; }
            set { SetPropertyValue<decimal>(nameof(WeckerAktiv5), ref fWeckerAktiv5, value); }
        }
        decimal fRabatt;
        public decimal Rabatt
        {
            get { return fRabatt; }
            set { SetPropertyValue<decimal>(nameof(Rabatt), ref fRabatt, value); }
        }
        decimal fVkp1Flag;
        public decimal Vkp1Flag
        {
            get { return fVkp1Flag; }
            set { SetPropertyValue<decimal>(nameof(Vkp1Flag), ref fVkp1Flag, value); }
        }
        decimal fVkp2FlagBrutto;
        public decimal Vkp2FlagBrutto
        {
            get { return fVkp2FlagBrutto; }
            set { SetPropertyValue<decimal>(nameof(Vkp2FlagBrutto), ref fVkp2FlagBrutto, value); }
        }
        decimal fVkp2FlagNetto;
        public decimal Vkp2FlagNetto
        {
            get { return fVkp2FlagNetto; }
            set { SetPropertyValue<decimal>(nameof(Vkp2FlagNetto), ref fVkp2FlagNetto, value); }
        }
        string fSteuernummer;
        [Size(15)]
        public string Steuernummer
        {
            get { return fSteuernummer; }
            set { SetPropertyValue<string>(nameof(Steuernummer), ref fSteuernummer, value); }
        }
        decimal fLieferquote;
        public decimal Lieferquote
        {
            get { return fLieferquote; }
            set { SetPropertyValue<decimal>(nameof(Lieferquote), ref fLieferquote, value); }
        }
        decimal fZahlungsart;
        public decimal Zahlungsart
        {
            get { return fZahlungsart; }
            set { SetPropertyValue<decimal>(nameof(Zahlungsart), ref fZahlungsart, value); }
        }
        decimal fWaehrung;
        public decimal Waehrung
        {
            get { return fWaehrung; }
            set { SetPropertyValue<decimal>(nameof(Waehrung), ref fWaehrung, value); }
        }
        decimal fUmsatzGes;
        public decimal UmsatzGes
        {
            get { return fUmsatzGes; }
            set { SetPropertyValue<decimal>(nameof(UmsatzGes), ref fUmsatzGes, value); }
        }
        decimal fBonusUmsatzGes;
        public decimal BonusUmsatzGes
        {
            get { return fBonusUmsatzGes; }
            set { SetPropertyValue<decimal>(nameof(BonusUmsatzGes), ref fBonusUmsatzGes, value); }
        }
        decimal fUmsatz;
        public decimal Umsatz
        {
            get { return fUmsatz; }
            set { SetPropertyValue<decimal>(nameof(Umsatz), ref fUmsatz, value); }
        }
        decimal fBonusUmsatz;
        public decimal BonusUmsatz
        {
            get { return fBonusUmsatz; }
            set { SetPropertyValue<decimal>(nameof(BonusUmsatz), ref fBonusUmsatz, value); }
        }
        decimal fForderung;
        public decimal Forderung
        {
            get { return fForderung; }
            set { SetPropertyValue<decimal>(nameof(Forderung), ref fForderung, value); }
        }
        decimal fGuthaben;
        public decimal Guthaben
        {
            get { return fGuthaben; }
            set { SetPropertyValue<decimal>(nameof(Guthaben), ref fGuthaben, value); }
        }
        string fBank;
        [Size(40)]
        public string Bank
        {
            get { return fBank; }
            set { SetPropertyValue<string>(nameof(Bank), ref fBank, value); }
        }
        string fBLZ;
        [Size(25)]
        public string BLZ
        {
            get { return fBLZ; }
            set { SetPropertyValue<string>(nameof(BLZ), ref fBLZ, value); }
        }
        string fKontoNr;
        [Size(25)]
        public string KontoNr
        {
            get { return fKontoNr; }
            set { SetPropertyValue<string>(nameof(KontoNr), ref fKontoNr, value); }
        }
        string fKKName;
        [Size(20)]
        public string KKName
        {
            get { return fKKName; }
            set { SetPropertyValue<string>(nameof(KKName), ref fKKName, value); }
        }
        string fKKNummer;
        [Size(20)]
        public string KKNummer
        {
            get { return fKKNummer; }
            set { SetPropertyValue<string>(nameof(KKNummer), ref fKKNummer, value); }
        }
        string fKKPruef;
        [Size(5)]
        public string KKPruef
        {
            get { return fKKPruef; }
            set { SetPropertyValue<string>(nameof(KKPruef), ref fKKPruef, value); }
        }
        string fKKGueltig;
        [Size(5)]
        public string KKGueltig
        {
            get { return fKKGueltig; }
            set { SetPropertyValue<string>(nameof(KKGueltig), ref fKKGueltig, value); }
        }
        decimal fletzteBestellNr;
        public decimal letzteBestellNr
        {
            get { return fletzteBestellNr; }
            set { SetPropertyValue<decimal>(nameof(letzteBestellNr), ref fletzteBestellNr, value); }
        }
        decimal fInlandPrivat;
        public decimal InlandPrivat
        {
            get { return fInlandPrivat; }
            set { SetPropertyValue<decimal>(nameof(InlandPrivat), ref fInlandPrivat, value); }
        }
        decimal fInlandGeschaeft;
        public decimal InlandGeschaeft
        {
            get { return fInlandGeschaeft; }
            set { SetPropertyValue<decimal>(nameof(InlandGeschaeft), ref fInlandGeschaeft, value); }
        }
        decimal fAusland;
        public decimal Ausland
        {
            get { return fAusland; }
            set { SetPropertyValue<decimal>(nameof(Ausland), ref fAusland, value); }
        }
        decimal fLaden;
        public decimal Laden
        {
            get { return fLaden; }
            set { SetPropertyValue<decimal>(nameof(Laden), ref fLaden, value); }
        }
        decimal fVersand;
        public decimal Versand
        {
            get { return fVersand; }
            set { SetPropertyValue<decimal>(nameof(Versand), ref fVersand, value); }
        }
        decimal fBonusKunde;
        public decimal BonusKunde
        {
            get { return fBonusKunde; }
            set { SetPropertyValue<decimal>(nameof(BonusKunde), ref fBonusKunde, value); }
        }
        decimal fSkontoKunde;
        public decimal SkontoKunde
        {
            get { return fSkontoKunde; }
            set { SetPropertyValue<decimal>(nameof(SkontoKunde), ref fSkontoKunde, value); }
        }
        decimal fEMailAngebot;
        public decimal EMailAngebot
        {
            get { return fEMailAngebot; }
            set { SetPropertyValue<decimal>(nameof(EMailAngebot), ref fEMailAngebot, value); }
        }
        decimal fEMailBestaetigung;
        public decimal EMailBestaetigung
        {
            get { return fEMailBestaetigung; }
            set { SetPropertyValue<decimal>(nameof(EMailBestaetigung), ref fEMailBestaetigung, value); }
        }
        decimal fEMailReservier;
        public decimal EMailReservier
        {
            get { return fEMailReservier; }
            set { SetPropertyValue<decimal>(nameof(EMailReservier), ref fEMailReservier, value); }
        }
        decimal fEMailLieferschein;
        public decimal EMailLieferschein
        {
            get { return fEMailLieferschein; }
            set { SetPropertyValue<decimal>(nameof(EMailLieferschein), ref fEMailLieferschein, value); }
        }
        decimal fEMailRechnung;
        public decimal EMailRechnung
        {
            get { return fEMailRechnung; }
            set { SetPropertyValue<decimal>(nameof(EMailRechnung), ref fEMailRechnung, value); }
        }
        decimal fEMailVoraus;
        public decimal EMailVoraus
        {
            get { return fEMailVoraus; }
            set { SetPropertyValue<decimal>(nameof(EMailVoraus), ref fEMailVoraus, value); }
        }
        decimal fEMailStatus;
        public decimal EMailStatus
        {
            get { return fEMailStatus; }
            set { SetPropertyValue<decimal>(nameof(EMailStatus), ref fEMailStatus, value); }
        }
        decimal fEMailSprache1;
        public decimal EMailSprache1
        {
            get { return fEMailSprache1; }
            set { SetPropertyValue<decimal>(nameof(EMailSprache1), ref fEMailSprache1, value); }
        }
        decimal fEMailSprache2;
        public decimal EMailSprache2
        {
            get { return fEMailSprache2; }
            set { SetPropertyValue<decimal>(nameof(EMailSprache2), ref fEMailSprache2, value); }
        }
        decimal fEMailSprache3;
        public decimal EMailSprache3
        {
            get { return fEMailSprache3; }
            set { SetPropertyValue<decimal>(nameof(EMailSprache3), ref fEMailSprache3, value); }
        }
        decimal fWahlZahl1;
        public decimal WahlZahl1
        {
            get { return fWahlZahl1; }
            set { SetPropertyValue<decimal>(nameof(WahlZahl1), ref fWahlZahl1, value); }
        }
        decimal fWahlZahl2;
        public decimal WahlZahl2
        {
            get { return fWahlZahl2; }
            set { SetPropertyValue<decimal>(nameof(WahlZahl2), ref fWahlZahl2, value); }
        }
        decimal fWahlZahl3;
        public decimal WahlZahl3
        {
            get { return fWahlZahl3; }
            set { SetPropertyValue<decimal>(nameof(WahlZahl3), ref fWahlZahl3, value); }
        }
        decimal fWahlZahl4;
        public decimal WahlZahl4
        {
            get { return fWahlZahl4; }
            set { SetPropertyValue<decimal>(nameof(WahlZahl4), ref fWahlZahl4, value); }
        }
        decimal fWahlZahl5;
        public decimal WahlZahl5
        {
            get { return fWahlZahl5; }
            set { SetPropertyValue<decimal>(nameof(WahlZahl5), ref fWahlZahl5, value); }
        }
        string fWahlFeld1;
        [Size(25)]
        public string WahlFeld1
        {
            get { return fWahlFeld1; }
            set { SetPropertyValue<string>(nameof(WahlFeld1), ref fWahlFeld1, value); }
        }
        string fWahlFeld2;
        [Size(25)]
        public string WahlFeld2
        {
            get { return fWahlFeld2; }
            set { SetPropertyValue<string>(nameof(WahlFeld2), ref fWahlFeld2, value); }
        }
        string fWahlFeld3;
        [Size(25)]
        public string WahlFeld3
        {
            get { return fWahlFeld3; }
            set { SetPropertyValue<string>(nameof(WahlFeld3), ref fWahlFeld3, value); }
        }
        string fWahlFeld4;
        [Size(25)]
        public string WahlFeld4
        {
            get { return fWahlFeld4; }
            set { SetPropertyValue<string>(nameof(WahlFeld4), ref fWahlFeld4, value); }
        }
        string fWahlFeld5;
        [Size(25)]
        public string WahlFeld5
        {
            get { return fWahlFeld5; }
            set { SetPropertyValue<string>(nameof(WahlFeld5), ref fWahlFeld5, value); }
        }
        string fZusatzFeld1;
        [Size(1)]
        public string ZusatzFeld1
        {
            get { return fZusatzFeld1; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld1), ref fZusatzFeld1, value); }
        }
        string fZusatzFeld2;
        [Size(1)]
        public string ZusatzFeld2
        {
            get { return fZusatzFeld2; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld2), ref fZusatzFeld2, value); }
        }
        string fZusatzFeld3;
        [Size(1)]
        public string ZusatzFeld3
        {
            get { return fZusatzFeld3; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld3), ref fZusatzFeld3, value); }
        }
        string fZusatzFeld4;
        [Size(1)]
        public string ZusatzFeld4
        {
            get { return fZusatzFeld4; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld4), ref fZusatzFeld4, value); }
        }
        string fZusatzFeld5;
        [Size(1)]
        public string ZusatzFeld5
        {
            get { return fZusatzFeld5; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld5), ref fZusatzFeld5, value); }
        }
        string fZusatzFeld6;
        [Size(1)]
        public string ZusatzFeld6
        {
            get { return fZusatzFeld6; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld6), ref fZusatzFeld6, value); }
        }
        string fZusatzFeld7;
        [Size(1)]
        public string ZusatzFeld7
        {
            get { return fZusatzFeld7; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld7), ref fZusatzFeld7, value); }
        }
        string fZusatzFeld8;
        [Size(1)]
        public string ZusatzFeld8
        {
            get { return fZusatzFeld8; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld8), ref fZusatzFeld8, value); }
        }
        string fZusatzFeld9;
        [Size(1)]
        public string ZusatzFeld9
        {
            get { return fZusatzFeld9; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld9), ref fZusatzFeld9, value); }
        }
        string fZusatzFeld10;
        [Size(1)]
        public string ZusatzFeld10
        {
            get { return fZusatzFeld10; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld10), ref fZusatzFeld10, value); }
        }
        string fZusatzFeld11;
        [Size(1)]
        public string ZusatzFeld11
        {
            get { return fZusatzFeld11; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld11), ref fZusatzFeld11, value); }
        }
        string fZusatzFeld12;
        [Size(1)]
        public string ZusatzFeld12
        {
            get { return fZusatzFeld12; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld12), ref fZusatzFeld12, value); }
        }
        string fZusatzFeld13;
        [Size(1)]
        public string ZusatzFeld13
        {
            get { return fZusatzFeld13; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld13), ref fZusatzFeld13, value); }
        }
        string fZusatzFeld14;
        [Size(1)]
        public string ZusatzFeld14
        {
            get { return fZusatzFeld14; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld14), ref fZusatzFeld14, value); }
        }
        string fZusatzFeld15;
        [Size(1)]
        public string ZusatzFeld15
        {
            get { return fZusatzFeld15; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld15), ref fZusatzFeld15, value); }
        }
        string fZusatzFeld16;
        [Size(1)]
        public string ZusatzFeld16
        {
            get { return fZusatzFeld16; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld16), ref fZusatzFeld16, value); }
        }
        string fZusatzFeld17;
        [Size(1)]
        public string ZusatzFeld17
        {
            get { return fZusatzFeld17; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld17), ref fZusatzFeld17, value); }
        }
        string fZusatzFeld18;
        [Size(1)]
        public string ZusatzFeld18
        {
            get { return fZusatzFeld18; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld18), ref fZusatzFeld18, value); }
        }
        string fZusatzFeld19;
        [Size(1)]
        public string ZusatzFeld19
        {
            get { return fZusatzFeld19; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld19), ref fZusatzFeld19, value); }
        }
        string fZusatzFeld20;
        [Size(1)]
        public string ZusatzFeld20
        {
            get { return fZusatzFeld20; }
            set { SetPropertyValue<string>(nameof(ZusatzFeld20), ref fZusatzFeld20, value); }
        }
        string fTextSeite;
        [Size(SizeAttribute.Unlimited)]
        public string TextSeite
        {
            get { return fTextSeite; }
            set { SetPropertyValue<string>(nameof(TextSeite), ref fTextSeite, value); }
        }
        decimal fAvaSperre;
        public decimal AvaSperre
        {
            get { return fAvaSperre; }
            set { SetPropertyValue<decimal>(nameof(AvaSperre), ref fAvaSperre, value); }
        }
        decimal fiShopKunde;
        public decimal iShopKunde
        {
            get { return fiShopKunde; }
            set { SetPropertyValue<decimal>(nameof(iShopKunde), ref fiShopKunde, value); }
        }
        decimal fGnpFlag;
        public decimal GnpFlag
        {
            get { return fGnpFlag; }
            set { SetPropertyValue<decimal>(nameof(GnpFlag), ref fGnpFlag, value); }
        }
        decimal fNnpFlag;
        public decimal NnpFlag
        {
            get { return fNnpFlag; }
            set { SetPropertyValue<decimal>(nameof(NnpFlag), ref fNnpFlag, value); }
        }
        decimal fEkpFlag;
        public decimal EkpFlag
        {
            get { return fEkpFlag; }
            set { SetPropertyValue<decimal>(nameof(EkpFlag), ref fEkpFlag, value); }
        }
        decimal fKalkFaktor;
        public decimal KalkFaktor
        {
            get { return fKalkFaktor; }
            set { SetPropertyValue<decimal>(nameof(KalkFaktor), ref fKalkFaktor, value); }
        }
        decimal fFormularSprache1;
        public decimal FormularSprache1
        {
            get { return fFormularSprache1; }
            set { SetPropertyValue<decimal>(nameof(FormularSprache1), ref fFormularSprache1, value); }
        }
        decimal fFormularSprache2;
        public decimal FormularSprache2
        {
            get { return fFormularSprache2; }
            set { SetPropertyValue<decimal>(nameof(FormularSprache2), ref fFormularSprache2, value); }
        }
        decimal fFormularSprache3;
        public decimal FormularSprache3
        {
            get { return fFormularSprache3; }
            set { SetPropertyValue<decimal>(nameof(FormularSprache3), ref fFormularSprache3, value); }
        }
        string fSuchFeld1;
        [Size(25)]
        public string SuchFeld1
        {
            get { return fSuchFeld1; }
            set { SetPropertyValue<string>(nameof(SuchFeld1), ref fSuchFeld1, value); }
        }
        string fSuchFeld2;
        [Size(25)]
        public string SuchFeld2
        {
            get { return fSuchFeld2; }
            set { SetPropertyValue<string>(nameof(SuchFeld2), ref fSuchFeld2, value); }
        }
        decimal fKundSperre;
        public decimal KundSperre
        {
            get { return fKundSperre; }
            set { SetPropertyValue<decimal>(nameof(KundSperre), ref fKundSperre, value); }
        }
        decimal fKundRabattSperre;
        public decimal KundRabattSperre
        {
            get { return fKundRabattSperre; }
            set { SetPropertyValue<decimal>(nameof(KundRabattSperre), ref fKundRabattSperre, value); }
        }
        string fIBAN;
        [Size(30)]
        public string IBAN
        {
            get { return fIBAN; }
            set { SetPropertyValue<string>(nameof(IBAN), ref fIBAN, value); }
        }
        string fBIC;
        [Size(11)]
        public string BIC
        {
            get { return fBIC; }
            set { SetPropertyValue<string>(nameof(BIC), ref fBIC, value); }
        }
        decimal fKundStatus;
        public decimal KundStatus
        {
            get { return fKundStatus; }
            set { SetPropertyValue<decimal>(nameof(KundStatus), ref fKundStatus, value); }
        }
        string fKundInfo;
        [Size(200)]
        public string KundInfo
        {
            get { return fKundInfo; }
            set { SetPropertyValue<string>(nameof(KundInfo), ref fKundInfo, value); }
        }
        decimal fVkp2Vkp1Flag;
        public decimal Vkp2Vkp1Flag
        {
            get { return fVkp2Vkp1Flag; }
            set { SetPropertyValue<decimal>(nameof(Vkp2Vkp1Flag), ref fVkp2Vkp1Flag, value); }
        }
        DateTime fAnlagedatum;
        public DateTime Anlagedatum
        {
            get { return fAnlagedatum; }
            set { SetPropertyValue<DateTime>(nameof(Anlagedatum), ref fAnlagedatum, value); }
        }
        decimal fkeineWerbung;
        public decimal keineWerbung
        {
            get { return fkeineWerbung; }
            set { SetPropertyValue<decimal>(nameof(keineWerbung), ref fkeineWerbung, value); }
        }
        string fLoeschKz;
        [Size(1)]
        public string LoeschKz
        {
            get { return fLoeschKz; }
            set { SetPropertyValue<string>(nameof(LoeschKz), ref fLoeschKz, value); }
        }
        DateTime fVorgangsdatum;
        public DateTime Vorgangsdatum
        {
            get { return fVorgangsdatum; }
            set { SetPropertyValue<DateTime>(nameof(Vorgangsdatum), ref fVorgangsdatum, value); }
        }
        string fVorgang;
        [Size(2)]
        public string Vorgang
        {
            get { return fVorgang; }
            set { SetPropertyValue<string>(nameof(Vorgang), ref fVorgang, value); }
        }
        decimal fBuchpreisRabatt;
        public decimal BuchpreisRabatt
        {
            get { return fBuchpreisRabatt; }
            set { SetPropertyValue<decimal>(nameof(BuchpreisRabatt), ref fBuchpreisRabatt, value); }
        }
    }

}