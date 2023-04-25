using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Svg.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace ReportesDevExpress
{
    public partial class ReporteForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            ///Establecer la última Aparaciencia usada por el usuario.
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(Properties.Settings.Default.Apariencia);
            ///Si la apariencia es tipo SVG, le establezco el color de la paleta.
            if (WindowsFormsSettings.DefaultLookAndFeel.IsSvgSkin())
                WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(Properties.Settings.Default.Apariencia, Properties.Settings.Default.ColorPaleta);

            ///Refrescar, para notificar a todos los controles de que el estilo ha cambiado.
            WindowsFormsSettings.DefaultLookAndFeel.UpdateStyleSettings();
            //barEditItemIdioma.EditValue = Properties.Settings.Default.Idioma;
            //ComboIdioma.EditValueChanging += ComboIdioma_EditValueChanging;
            //XtraReport reporte = new XtraReport();
            //ReportDesignTool formulario = new ReportDesignTool(reporte);
            //formulario.ShowRibbonDesignerDialog();
        }

        private void ComboIdioma_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //var resultado = XtraMessageBox.Show("Atención!!!, para aplicar el idioma la aplicación debe ser reiniciada.\n\n" +
            //                                     "¿Desea aplicar el idioma y reiniciar la aplicación?", "AVISO - APLICAR IDIOMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if (resultado == DialogResult.Yes)
            //{
            //    //e.Cancel = false;
            //    Properties.Settings.Default.Idioma = e.NewValue.ToString();
            //    ///Guardar los cambios en la configuracion
            //    Properties.Settings.Default.Save();
            //    Application.Restart();
            //}
            //else
            //{
            //    //Properties.Settings.Default.Idioma = e.OldValue.ToString();
            //    e.Cancel = true;
            //}
        }

        private void ReporteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///Si la Apariencia es SVG
            if (WindowsFormsSettings.DefaultLookAndFeel.IsSvgSkin())
            {
                ///Guardar la Apariencia Actual
                Properties.Settings.Default.Apariencia = WindowsFormsSettings.DefaultLookAndFeel.SkinName;
                ///Guardar el color de la paleta actual
                Properties.Settings.Default.ColorPaleta = string.IsNullOrEmpty(WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName) ?
                                                          "Default" : WindowsFormsSettings.DefaultLookAndFeel.ActiveSvgPaletteName;
            }
            else  ///Guardar la Apariencia Actual
                Properties.Settings.Default.Apariencia = WindowsFormsSettings.DefaultLookAndFeel.SkinName;

            ///Guardar los cambios en la configuracion
            Properties.Settings.Default.Save();
        }


    }
}
