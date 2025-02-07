using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using M64MM.Additions;
using M64MM.Utils;
using ExtraExtraControls.Properties;

namespace ExtraExtraControls
{
    public class Module : IModule
    {


       

        static mainForm frmMain = new mainForm();

        public string SafeName => "ExtraEXTRAControls";

        public string Description => "Modifies SM64 Save files to have 120 Stars";

        public Image AddonIcon => Resources.XSM_ICON;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tcOpen = new ToolCommand("Extra Extra Controls...");
            tcOpen.Summoned += (a, b) => openForm();
            tcl.Add(tcOpen);
            return tcl;
        }

        public void openForm()
        {
            if (frmMain == null || frmMain.IsDisposed)
            {
                frmMain = new mainForm();
            }
            frmMain.Show();
        }

        public void Initialize()
        {

        }

        public void OnBaseAddressFound()
        {
           
        }

        public void OnBaseAddressZero()
        {
     
        }

        public void Reset()
        {

        }

        public void Update()
        {
           
        }

        public void OnCoreEntAddressChange(uint addr)
        {
            // :P
        }
    }
}
