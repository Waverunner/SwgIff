using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWB.IffEditor.Plugin;
using Waverunner.Swg.IO;
using WeifenLuo.WinFormsUI.Docking;

namespace Waverunner.Swg.Plugins
{
    public partial class LsbPlugin : DockContent, IPlugin
    {
        private static string VERSION = "1.0.0.0";
        public static bool DEBUG_MODE = false;
        // Type
        private static uint LSB = 1413567308;
        // Header
        private static uint IFF = 1297239878;
        private SwgIff iff { get; set; }
        private LightsaberAppearance lsb { get; set; }

        public LsbPlugin()
        {
            InitializeComponent();
            toolStrip.Renderer = new NoCornerBorderToolStripRender();

            OnNewLSBSuccess();
        }

        // IEditor
        public void OpenFromTree(byte[] data, string fileName)
        {
            PluginTools.DebugPrint("Opening: " + fileName);

            iff = new SwgIff(fileName);
            lsb = new LightsaberAppearance();

            iff.Open(data, lsb);

            if (!iff.HasLoaded)
            {
                PluginTools.ShowError(fileName + " is not a valid Lightsaber Appearance Template file");
                return;
            }

            FileName = fileName;

            OnLsbLoadSuccess();
        }

        public void OpenFromFile(string fileName)
        {
            OpenFromTree(File.ReadAllBytes(fileName), fileName);
        }
        // End IEditor

        public void OnLsbLoadSuccess()
        {
            tableLayoutPanelAttributes.Enabled = true;
            tableLayoutPanelUpperBlade.Enabled = true;

            // Base
            textBoxAppearance.Text = lsb.AppearanceTemplate;
            textBoxSound.Text = lsb.Sound;

            // Flicker
            if (lsb.Flicker != null)
                populateFlickerUI(lsb.Flicker);

            // Blade
            int blades = lsb.Blades.Count;
            if (blades == 1)
            {
                populateUpperBladeUI(lsb.Blades[0]);
            }
            else if (blades == 2)
            {
                populateUpperBladeUI(lsb.Blades[0]);
                populateLowerBladeUI(lsb.Blades[1]);
            }

            ChangesMade = false;
        }

        public void OnNewLSBSuccess()
        {
            FileName = "New_Lightsaber_Blade_Appearance.lsb";
            tableLayoutPanelAttributes.Enabled = true;
            tableLayoutPanelUpperBlade.Enabled = true;

            // Basics Defaults
            textBoxAppearance.Text = "appearance/wp_mle_sword_lightsaber_leather.apt";
            textBoxSound.Text = "sound/wep_idle1_lightsaber.snd";

            // Flicker Defaults
            buttonFlickerColor.BackColor = Color.FromArgb(255, 32, 32, 32);
            buttonFlickerColor.Text = "255, 32, 32, 32";
            textBoxFlickerTimeMin.Text = ".02";
            textBoxFlickerTimeMax.Text = ".10";
            textBoxFlickerRangeMin.Text = "1.0";
            textBoxFlickerRangeMax.Text = "2.0";
            checkBoxFlickerAware.Checked = false;

            // Blade Defaults
            textBoxUpperCloseSpd.Text = "0.5";
            textBoxUpperOpenSpd.Text = "0.5";
            textBoxUpperLength.Text = "1.8";
            textBoxUpperWidth.Text = "0.15";
            textBoxUpperShdr.Text = "shader/lightsaberblade.sht";

            textBoxLowerCloseSpd.Text = "0.5";
            textBoxLowerOpenSpd.Text = "0.5";
            textBoxLowerLength.Text = "1.8";
            textBoxLowerWidth.Text = "0.15";
            textBoxLowerShdr.Text = "shader/lightsaberblade.sht";
        }

        #region IEditor Interface

        public event EventHandler HasChangesChanged;
        private bool m_isDirty = false;
        public bool ChangesMade
        {
            get { return m_isDirty; }
            set
            {
                if (m_isDirty != value && HasChangesChanged != null)
                {
                    m_isDirty = value;
                    HasChangesChanged(this, null);
                }
            }
        }
        public bool HasChanges() { return m_isDirty; }

        public event EventHandler DocumentNameChanged;
        private string m_fileName = "New LSB Editor";
        public string FileName
        {
            get { return m_fileName; }
            set { m_fileName = value; if (DocumentNameChanged != null) { DocumentNameChanged(this, null); } }
        }
        public string DocumentName() { return m_fileName; }

        StatusBarController sbController = new StatusBarController(new Dictionary<string, string>()
        {
            {"LSB_LOAD_DATA", "0"}
        });

        public StatusBarController StatusBarController()
        {
            return sbController;
        }

        public bool SupportsFile(string filename, uint header, uint type)
        {
            return (header == IFF && type == LSB);
        }
        #endregion

        #region IPlugin Interface

        public void InitialisePlugin()
        {
            if (DEBUG_MODE)
            {
                PluginTools.DebugPrint("Plugin Initialized.");
            }
        }

        public void DisposePlugin()
        {
        }

        public PluginInformation Information
        {
            get { return new PluginInformation("LSB Editor", "Editor for LSB files", "Waverunner", VERSION); }
        }

        public Image PluginIcon
        {
            get { return Properties.Resources.PluginIcon; }
        }

        public IHost Host { get; set; }
        #endregion

        #region Interface Populators
        private void populateFlickerUI(LightsaberFlicker flicker)
        {
            buttonFlickerColor.BackColor = flicker.Color;
            buttonFlickerColor.Text = flicker.Color.ToString().Replace("Color", "").Replace("=", "").Replace("[", "")
                .Replace("]", "").Replace("A", "").Replace("R", "").Replace("G", "").Replace("B", "");
            textBoxFlickerTimeMin.Text = flicker.MinTime.ToString();
            textBoxFlickerTimeMax.Text = flicker.MaxTime.ToString();
            textBoxFlickerRangeMin.Text = flicker.MinRange.ToString();
            textBoxFlickerRangeMax.Text = flicker.MaxRange.ToString();
            checkBoxFlickerAware.Checked = flicker.IsDayNightAware;

            checkBoxFlicker.Checked = true;
        }

        private void populateUpperBladeUI(LightsaberBlade blade)
        {
            textBoxUpperCloseSpd.Text = blade.CloseRate.ToString();
            textBoxUpperOpenSpd.Text = blade.OpenRate.ToString();
            textBoxUpperLength.Text = blade.Length.ToString();
            textBoxUpperWidth.Text = blade.Width.ToString();
            textBoxUpperShdr.Text = blade.Shader;

            tableLayoutPanelUpperBlade.Enabled = true;
        }

        private void populateLowerBladeUI(LightsaberBlade blade)
        {
            textBoxLowerCloseSpd.Text = blade.CloseRate.ToString();
            textBoxLowerOpenSpd.Text = blade.OpenRate.ToString();
            textBoxLowerLength.Text = blade.Length.ToString();
            textBoxLowerWidth.Text = blade.Width.ToString();
            textBoxLowerShdr.Text = blade.Shader;

            checkBoxDblBlade.Checked = true;
        }
        #endregion

        #region Interface Controls
        private void onNewLSB(object sender, EventArgs e)
        {
            if (HasChanges())
            {
                DialogResult result = PluginTools.ShowQuestion("Would you like to save changes to the current file before creating a new one?");
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        // TODO: Save changes
                        break;
                    case DialogResult.No:
                        OnNewLSBSuccess();
                        break;
                    case DialogResult.Cancel:
                        break;
                    default: break;
                }
            }
            else
            {
                OnNewLSBSuccess();
            }
        }

        private void onOpenLSB(object sender, EventArgs e)
        {
            if (HasChanges() && PluginTools.ShowQuestion("Are you sure you want to open another file? Your changes will not be saved.") == DialogResult.No)
                return;

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                OpenFromFile(openFileDialog.FileName);
            }
            catch (Exception exc)
            {
                PluginTools.ShowException(exc);
            }
        }

        private void changeFlickerColor(Color color)
        {
            buttonFlickerColor.BackColor = color;
            buttonFlickerColor.Text = color.A + ", " + color.R + ", " + color.G + ", " + color.B;
        }

        private void buttonFlickerColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            changeFlickerColor(colorDialog.Color);

            control_ChangesMade(sender, e);
        }

        private void checkBoxDblBlade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDblBlade.Checked)
                tableLayoutPanelLowerBlade.Enabled = true;
            else
                tableLayoutPanelLowerBlade.Enabled = false;

            control_ChangesMade(sender, e);
        }

        private void checkBoxFlicker_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlicker.Checked)
                tableLayoutPanelFlicker.Enabled = true;
            else
                tableLayoutPanelFlicker.Enabled = false;

            control_ChangesMade(sender, e);
        }

        private void control_ChangesMade(object sender, EventArgs e)
        {
            ChangesMade = true;
        }
        #endregion
    }

    #region LSB Model
    public class LightsaberAppearance : ISwgIffHandler
    {
        private int _bladeIndex { get; set; }

        public string AppearanceTemplate { get; set; }
        public string Sound { get; set; }
        public LightsaberFlicker Flicker { get; set; }
        public List<LightsaberBlade> Blades { get; set; }

        public LightsaberAppearance() { Blades = new List<LightsaberBlade>(); }

        #region ISwgIffHandler
        public void OnEnterForm(string oldForm, string newForm, int size)
        {
            switch (newForm)
            {
                case "LGHT":
                    Flicker = new LightsaberFlicker();
                    break;
                case "BLAD":
                    LightsaberBlade blade = new LightsaberBlade();
                    Blades.Add(blade);
                    _bladeIndex = Blades.IndexOf(blade);
                    break;
                default: break;
            }
        }

        public void OnEnterChunk(IffDataStream chunkStream, string chunk, string currentForm, int size)
        {
            switch (currentForm)
            {
                case "0000": PopulateBase(chunkStream, chunk); break;
                case "LGHT": PopulateFlicker(chunkStream, chunk); break;
                case "BLAD": PopulateBlade(chunkStream, chunk); break;
                default: break;
            }
        }

        public bool CanHandleType(string type)
        {
            if (type.Equals("LSAT"))
                return true;
            else return false;
        }
        #endregion

        public void PopulateBase(IffDataStream data, string chunk)
        {
            switch (chunk)
            {
                case "BASE": AppearanceTemplate = data.ReadAscii(); break;
                case "ASND": Sound = data.ReadAscii(); break;
                default: break;
            }
        }

        public void PopulateBlade(IffDataStream data, string chunk)
        {
            LightsaberBlade blade = Blades[_bladeIndex];
            if (blade == null)
                return;

            switch (chunk)
            {
                case "SHDR": blade.Shader = data.ReadAscii(); break;
                case "LGTH": blade.Length = data.ReadFloat(); break;
                case "WDTH": blade.Width = data.ReadFloat(); break;
                case "OPEN": blade.OpenRate = data.ReadFloat(); break;
                case "CLOS": blade.CloseRate = data.ReadFloat(); break;
                default: break;
            }
        }

        public void PopulateFlicker(IffDataStream data, string chunk)
        {
            switch (chunk)
            {
                case "COLR":
                    Flicker.Color = data.ReadRgba();
                    break;
                case "RANG":
                    Flicker.MinRange = data.ReadFloat();
                    Flicker.MaxRange = data.ReadFloat();
                    break;
                case "TIME":
                    Flicker.MinTime = data.ReadFloat();
                    Flicker.MaxTime = data.ReadFloat();
                    break;
                case "DAYN":
                    Flicker.IsDayNightAware = data.ReadBool();
                    break;
                default: break;
            }
        }
    }

    public class LightsaberBlade
    {
        public string Shader { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float OpenRate { get; set; }
        public float CloseRate { get; set; }

        public LightsaberBlade() { }

        public override string ToString()
        {
            return String.Format("Shader {0} with a length of {1} and an open rate of {2}", Shader, Length, OpenRate);
        }
    }

    public class LightsaberFlicker
    {
        public Color Color { get; set; }
        public float MinRange { get; set; }
        public float MaxRange { get; set; }
        public float MinTime { get; set; }
        public float MaxTime { get; set; }
        public bool IsDayNightAware { get; set; }

        public LightsaberFlicker() { }

        public override string ToString()
        {
            return String.Format("Color {0} with a max time of {1} and is this day/night aware? {2}", Color.ToString(), MaxTime, IsDayNightAware);
        }
    }
    #endregion

    #region Misc.
    public class PluginTools
    {
        public static void ShowMessage(string text) { MessageBox.Show(text, "LSB Editor", MessageBoxButtons.OK); }
        public static DialogResult ShowQuestion(string text) { return MessageBox.Show(text, "LSB Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question); }
        public static void ShowError(string text) { MessageBox.Show(text, "LSB Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        public static void ShowException(Exception exc) { MessageBox.Show(exc.Message + "\n" + exc.StackTrace, Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand); }

        public static void DebugPrint(string text)
        {
            if (!LsbPlugin.DEBUG_MODE)
                return;
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("lsb_debug_print.txt", true);
                file.WriteLine(text);
                file.Close();
            }
            catch (System.IO.IOException)
            {

            }
        }
    }

    #region Form classes
    public class NoCornerBorderToolStripRender : ToolStripProfessionalRenderer
    {
        public NoCornerBorderToolStripRender()
        {
            this.RoundedEdges = false;
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }
    }
    #endregion

#endregion
}
