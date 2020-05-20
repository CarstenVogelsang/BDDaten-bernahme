using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Collections;
using BDImportKunden.DB100;
using DevExpress.Xpo;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using System.Reflection;
using BDDatenbankLibraryCRM;
using BDDatenbankLibraryCRM.Database;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
//using DevExpress.ClipboardSource.SpreadsheetML;

namespace BDImportKunden
{
    public partial class Form1 : RibbonForm
    {

        //HelperClassMetadata _mdAktuell;
        Worksheet _worksheet1 = null;
        IWorkbook _workbook = null;
        List <HelperClassMetadata> _liMd;

        public Form1()
        {
            InitializeComponent();

            IQueryable<BDDatenbankTabelle> iqBddt = DataHelperBDDatenbankTabelle.Lese_BDDatenbankTabelle(Program._sBDDatenbankLibraryCRM);
            repositoryItemLookUpEditDBTabelleAuswahl.DataSource = iqBddt;
            repositoryItemLookUpEditDBTabelleAuswahl.ValueMember = "Tabelle";
            repositoryItemLookUpEditDBTabelleAuswahl.DisplayMember = "Tabelle";


        }

        private void barButtonItemTabelleVorbereiten_ItemClick(object sender, ItemClickEventArgs e)
        {

            //KUND kund = new KUND(Session.DefaultSession);
            //KUND1 kund1 = new KUND1(Session.DefaultSession);
            //List<HelperClassMetadata> LiMd1 = DataHelperKunde.LeseMetadata(kund);
            //List<HelperClassMetadata> LiMd2 = DataHelperKunde.LeseMetadata(kund1);
            //LiMd1.AddRange(LiMd2);
            //_liMd = LiMd1;


            //Eine Leerzeile einfügen, die die zu importierenden Feldnamen enthält
            _worksheet1.Rows["1"].Insert();

            BDDatenbankTabelle bdDt = DataHelperBDDatenbankTabelle.Lese_mittelsDatenbankName_mittelsTabelleName_BDDatenbankTabelle(Program._sBDDatenbankLibraryCRM, "DB100", "KUND");
            IQueryable<BDDatenbankTabelleFeld> iqBdDtf = DataHelperBDDatenbankTabelle.Lese_mittelsTabelle_BDDatenbankTabelleFelder(Program._sBDDatenbankLibraryCRM, bdDt);
            CellValue[] valuesFeldnamen = new CellValue[iqBdDtf.Count()];
            for (int i = 0; i < iqBdDtf.Count(); i++)
            {
                valuesFeldnamen[i] = iqBdDtf.ElementAt(i).Feldname;
            }

            int cols = AnzahlSpalten();
            if (cols > 0)
            {
                for (int i = 0; i < cols; i++)
                {
                    CellRange cR = _worksheet1[0, i];
                    _worksheet1.CustomCellInplaceEditors.Add(cR, CustomCellInplaceEditorType.ComboBox, ValueObject.CreateListSource(valuesFeldnamen));
                }
            }

            //LookUpEdit lookupEdit1 = new LookUpEdit();
            //_worksheet1.CustomCellInplaceEditors.Add(cR, lookupEdit1);

            //repositoryItemLookUpEdit1.DataSource = LiMd1;
            //repositoryItemLookUpEdit1.ValueMember = "Feldname";
            //repositoryItemLookUpEdit1.DisplayMember = "Feldname";

            //Alle leeren Zeilen löschen
            int lz = LetzteZeile();
            if (lz > 0)
            {
                for (int i = 1; i < lz; i++)
                {
                    if (lz > i) LeerzeileEleminieren(ref lz, ref i);
                }
            }

            //Formatierungen entfernen
            //_worksheet1.ClearFormats(_worksheet1.Range.Parse("R[1]C[1]:R[" + lz + "]C[" + cols + "]", ReferenceStyle.UseDocumentSettings));
            _worksheet1.ClearFormats(_worksheet1.Range.FromLTRB(0, 0, cols, lz));


            //Outlines entfernen
            _worksheet1.ClearOutline();

        }

        private int AnzahlSpalten()
        {
            try
            {
                CellRange usedRange = _worksheet1.GetUsedRange();
                int cols = usedRange.ColumnCount;
                return cols;
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        private int LetzteZeile()
        {
            try
            {
                CellRange usedRange = _worksheet1.GetUsedRange();
                int row = usedRange.RowCount;
                return row;
            }
            catch (Exception ex)
            {

            }
            return 0;
        }

        private void LeerzeileEleminieren(ref int lz, ref int rowIndex)
        {
            try
            {
                int cols = AnzahlSpalten();
                if (cols > 0)
                {
                    int AnzahlGefüllteZellen = 0;
                    for (int i = 0; i < cols; i++)
                    {
                        Cell c = _worksheet1.Cells[rowIndex, i];
                        if (c.Value.TextValue != null)
                            AnzahlGefüllteZellen++;
                    }
                    if (AnzahlGefüllteZellen == 0)
                    {
                        _worksheet1.Rows[rowIndex].Delete();
                        rowIndex--;
                        lz--;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        //private void barButtonItemFeldnameHinzufügen_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    object value = repositoryItemLookUpEdit1.GetDataSourceRowByKeyValue(barEditItem1.EditValue);
        //    if (_worksheet1 != null && value != null)
        //    {
        //        _mdAktuell = (HelperClassMetadata)value;
        //        _worksheet1.Cells["A1"].Value = _mdAktuell.Feldname;
        //    }
        //}

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            //object value = (sender as LookUpEdit).EditValue;
            //if (value != null)
            //{
            //    _mdAktuell = (HelperClassMetadata)value;
            //}
        }



        private void barButtonItemTabelleImportieren_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                //if (_liMd.Count <= 0)
                //{
                //    MessageBox.Show("Error: Feldnamen können nicht überpürft werden.");
                //    return;
                //}

                //Sind in den Spalten nur korrekt geschriebene Feldnamen?
                //Todo durch alle Spalten
                //if (_liMd.Exists(x => x.Feldname.Contains(Feldname)))
                //{

                //}

                bool resultCheckFeldnamen = CheckFeldnamen(AnzahlSpalten());
                if (!resultCheckFeldnamen) return;
                int lz = LetzteZeile();
                if (lz > 0)
                {
                    for (int row = 1; row < lz; row++)
                    {
                        int cols = AnzahlSpalten();
                        if (cols > 0)
                        {
                            KUND ku = null;

                            CellValue cellValueKundeKennung = _worksheet1.Cells[row, 0].Value;
                            if (cellValueKundeKennung != null)
                            {
                                ku = DataHelperKunde.LeseKunde(cellValueKundeKennung.TextValue);
                            }
                            if (ku == null)
                            {
                                ku = new KUND(Session.DefaultSession);
                                //Kundenkennung aus Nachname und Vorname
                                //=LINKS(WECHSELN(WECHSELN(VERKETTEN(B20;" ";C20);" ";"");"-";"");15)
                                ku.Kunde = "K" + row.ToString().PadLeft(4, '0'); //ToDo
                                //KUND1 ku1 = new KUND1(Session.DefaultSession);
                            }

                            string pn = nameof(ku.Kunde);

                            for (int col = 0; col < cols; col++)
                            {
                                Cell cell = _worksheet1.Cells[row, col];
                                var cellValue = cell.Value;
                                string Feldname = _worksheet1.Cells[0, col].Value.TextValue;

                                if (!string.IsNullOrEmpty(Feldname) && cellValue != null && cellValue.Type != CellValueType.None)
                                {
                                    PropertyInfo propKu = ku.GetType().GetProperty(Feldname, BindingFlags.Public | BindingFlags.Instance);
                                    if (propKu.Name != pn && propKu != null && propKu.CanWrite)
                                    {
                                        Type typeZiel = propKu.PropertyType;
                                        Type typeQuelle = null;
                                        if (cellValue.Type == CellValueType.Numeric)
                                        {
                                            object value = null;
                                            if (Type.GetTypeCode(typeZiel) == TypeCode.String)
                                            {
                                                value = cellValue.NumericValue.ToString();
                                            }
                                            else
                                            {
                                                typeQuelle = cellValue.NumericValue.GetType();
                                                switch (Type.GetTypeCode(typeQuelle))
                                                {
                                                    case TypeCode.Byte:
                                                        break;
                                                    case TypeCode.SByte:
                                                        break;
                                                    case TypeCode.UInt16:
                                                        break;
                                                    case TypeCode.UInt32:
                                                        break;
                                                    case TypeCode.UInt64:
                                                        break;
                                                    case TypeCode.Int16:
                                                        break;
                                                    case TypeCode.Int32:
                                                        break;
                                                    case TypeCode.Int64:
                                                        break;
                                                    case TypeCode.Decimal:
                                                        break;
                                                    case TypeCode.Double:
                                                        if (Type.GetTypeCode(typeZiel) == TypeCode.Decimal)
                                                        {
                                                            value = (decimal)cellValue.NumericValue;
                                                        }
                                                        break;
                                                    case TypeCode.Single:
                                                        break;
                                                }
                                            }
                                            if (value != null)
                                            {
                                                propKu.SetValue(ku, value, null);
                                            }
                                            else
                                            {
                                                string typeQuelleName = typeQuelle != null ? typeQuelle.Name : "Quelle ???";
                                                MessageBox.Show(Feldname + ": Konvertierung von " + typeQuelleName + " zu " + typeZiel.Name + " fehlt.");
                                            }
                                        }
                                        else if (cellValue.Type == CellValueType.Text)
                                        {
                                            typeQuelle = cellValue.TextValue.GetType();
                                            if (typeQuelle == typeZiel)
                                            {
                                                propKu.SetValue(ku, cellValue.TextValue, null);
                                            }
                                        }
                                        else if (cellValue.Type == CellValueType.DateTime)
                                        {
                                            propKu.SetValue(ku, cellValue.DateTimeValue, null);
                                        }
                                        else
                                        {
                                            propKu.SetValue(ku, cellValue.TextValue, null);
                                        }
                                    }
                                    //PropertyInfo propKu1 = ku.GetType().GetProperty(Feldname, BindingFlags.Public | BindingFlags.Instance);
                                    //if (null != propKu1 && propKu1.CanWrite)
                                    //{
                                    //    propKu1.SetValue(ku, cellValue, null);
                                    //}
                                }
                            }
                            BDDatenbankTabelle bdDt = DataHelperBDDatenbankTabelle.Lese_mittelsDatenbankName_mittelsTabelleName_BDDatenbankTabelle(Program._sBDDatenbankLibraryCRM, "DB100", "KUND");
                            IQueryable<BDDatenbankTabelleFeld> iqBdDtf = DataHelperBDDatenbankTabelle.Lese_mittelsTabelle_BDDatenbankTabelleFelder(Program._sBDDatenbankLibraryCRM, bdDt);
                            foreach (BDDatenbankTabelleFeld bdDtf in iqBdDtf)
                            {
                                bool IstSchlüsselfeld = bdDtf.IstSchlüsselfeld;
                                string Datentyp = bdDtf.DatentypGenerisch.Datentyp;
                                string Feldname = bdDtf.Feldname;
                                int Feldlänge = bdDtf.Feldlänge;
                                if (!IstSchlüsselfeld)
                                {
                                    PropertyInfo propKu = ku.GetType().GetProperty(Feldname, BindingFlags.Public | BindingFlags.Instance);
                                    if (propKu != null && propKu.CanWrite)
                                    {
                                        var value = propKu.GetValue(ku);
                                        if (Datentyp == "string")
                                        {
                                            string s = (string)value;
                                            if (s != null && Feldlänge > 0 && s.Length > Feldlänge)
                                            {
                                                string sAbgeschnitten = s.Substring(0, Feldlänge-1);
                                                propKu.SetValue(ku, sAbgeschnitten, null);
                                            }
                                            else if (s == null || string.IsNullOrEmpty(s))
                                                propKu.SetValue(ku, "", null);
                                        }
                                        else if (Datentyp == "int")
                                        {
                                            int? i = (int)value;
                                            int imin = 0;
                                            if (i == null || i < imin)
                                                propKu.SetValue(ku, imin, null);
                                        }
                                        else if (Datentyp == "decimal")
                                        {
                                            decimal? d = (decimal)value;
                                            decimal dmin = 0m;
                                            if (d == null || d < dmin)
                                                propKu.SetValue(ku, dmin, null);
                                        }
                                        else if (Datentyp == "datetime")
                                        {
                                            DateTime dt = (DateTime)value;
                                            DateTime dtmin = new DateTime(1900, 1, 1);
                                            if (dt == null || dt < dtmin)
                                                propKu.SetValue(ku, dtmin, null);
                                        }
                                    }
                                }
                            }
                            ku.Save();
                            _worksheet1.Cells[row, 0].Value = ku.Kunde;
                            //ku1.CompoundKey1.Kunde = ku.Kunde;
                            //ku1.CompoundKey1.Nr = 1;
                            //ku1.Save();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private bool CheckFeldnamen(int cols)
        {
            try
            {
                if (cols > 0)
                {
                    var list = new List<(int i, string Feldname, string Zelladresse)>();
                    var list2 = new List<(int i, string Feldname, string Zelladresse)>();
                    for (int i = 0; i < cols; i++)
                    {
                        Cell cell = _worksheet1[0, i];
                        if (cell.Value != null && cell.Value.TextValue != null)
                        {
                            if (list.Count == 0 | (!list.Exists(x => x.Feldname.Contains(cell.Value.TextValue))))
                                list.Add((i, cell.Value.TextValue, cell.ColumnIndex + "," + cell.RowIndex));
                            else
                            {
                                list2.Add((i, cell.Value.TextValue, cell.ColumnIndex + "," + cell.RowIndex));
                            }
                        }
                    }
                    if (list2.Count() > 0)
                    {
                        string msg = "Sie haben Feldnamen doppelt vergeben:";
                        foreach ((int i, string Feldname, string Zelladresse) item in list2)
                        {
                            msg += Environment.NewLine + "Feldname: "  +item.Feldname + " Zelle: " + item.Zelladresse;
                        }
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private void barButtonItemSpaltenAutomatischBearbeiten_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                bool resultCheckFeldnamen = CheckFeldnamen(AnzahlSpalten());
                if (!resultCheckFeldnamen) return;

            }
            catch (Exception)
            {

            }
        }

        private void barButtonItemPlzOrtSplitten_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cell cPlzOrt = spreadsheetControl.ActiveCell;
                int spalte = cPlzOrt.ColumnIndex;
                _worksheet1.Columns.Insert(spalte);
                _worksheet1.Columns.Insert(spalte);
                Cell cOrt = _worksheet1.Cells[cPlzOrt.RowIndex, spalte - 1];
                cOrt.Value = "Ort";
                Cell cPlz = _worksheet1.Cells[cPlzOrt.RowIndex, spalte - 2];
                cPlz.Value = "Plz";

                int lz = LetzteZeile();
                if (lz > 0)
                {
                    for (int i = 1; i < lz; i++)
                    {
                        Cell cPlzOrtRow = _worksheet1.Cells[i, cPlzOrt.ColumnIndex+2];
                        string PlzOrt = cPlzOrtRow.Value.TextValue;
                        if (!string.IsNullOrEmpty(PlzOrt))
                        {
                            string[] arrPlzOrt = PlzOrt.Split(' ');
                            if (arrPlzOrt.Length == 3)
                            {
                                Cell cOrtRow = _worksheet1.Cells[i, cPlzOrtRow.ColumnIndex - 1];
                                cOrtRow.Value = arrPlzOrt[2];
                                Cell cPlzRow = _worksheet1.Cells[i, cPlzOrtRow.ColumnIndex - 2];
                                cPlzRow.Value = arrPlzOrt[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private BDDatenbankTabelle _bdDt;

        private void barButtonItemDatenbankVorbereiten_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_bdDt != null)
            {
                IQueryable<BDDatenbankTabelleFeld> iqDtf = DataHelperBDDatenbankTabelle.Lese_mittelsTabelle_BDDatenbankTabelleFelder(Program._sBDDatenbankLibraryCRM, _bdDt);
                if (iqDtf.Count() == 0)
                {
                    //Alle Felder anlegen
                    KUND kund = new KUND(Program._sDB100);
                    List<HelperClassMetadata> LiMd1 = DataHelperKunde.LeseMetadata(kund);
                    foreach (HelperClassMetadata hcMd in LiMd1)
                    {
                        bool result = DataHelperBDDatenbankTabelle.Erstelle_mittelsTabelle_mittelsMetadata_BDDatenbankTabelleFeld(Program._sBDDatenbankLibraryCRM, _bdDt, hcMd);
                    }
                }
            }
        }

        private void barEditItemDBTabelleAuswahl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemLookUpEditDBTabelleAuswahl_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            _bdDt = (BDDatenbankTabelle)repositoryItemLookUpEditDBTabelleAuswahl.GetDataSourceRowByKeyValue(lookUpEdit.EditValue); 
        }

        private void barButtonItemStrasseHausnummerSplitten_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cell cStrasseHausNr = spreadsheetControl.ActiveCell;
                int spalte = cStrasseHausNr.ColumnIndex;
                _worksheet1.Columns.Insert(spalte);
                _worksheet1.Columns.Insert(spalte);
                Cell cHausNr = _worksheet1.Cells[cStrasseHausNr.RowIndex, spalte - 1];
                cHausNr.Value = "LiHausNr";
                Cell cStrasse = _worksheet1.Cells[cStrasseHausNr.RowIndex, spalte - 2];
                cStrasse.Value = "LiStrasse";
                int lz = LetzteZeile();
                if (lz > 0)
                {
                    for (int i = 1; i < lz; i++)
                    {
                        Cell cStrasseHausNrRow = _worksheet1.Cells[i, cStrasseHausNr.ColumnIndex + 2];
                        string StrasseHausNr = cStrasseHausNrRow.Value.TextValue;
                        if (!string.IsNullOrEmpty(StrasseHausNr))
                        {
                            string[] arrStrasseHausNr = StrasseHausNr.Split(' ');
                            if (arrStrasseHausNr.Length == 3)
                            {
                                Cell cHausNrRow = _worksheet1.Cells[i, cStrasseHausNrRow.ColumnIndex - 1];
                                cHausNrRow.Value = arrStrasseHausNr[2];
                                Cell cStrasseRow = _worksheet1.Cells[i, cStrasseHausNrRow.ColumnIndex - 2];
                                cStrasseRow.Value = arrStrasseHausNr[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void spreadsheetControl_DocumentLoaded(object sender, EventArgs e)
        {
            _workbook = spreadsheetControl.Document;
            _worksheet1 = _workbook.Worksheets[0];
        }
    }
}