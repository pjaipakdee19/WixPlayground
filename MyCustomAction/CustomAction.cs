using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;

namespace MyCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult ShowLicenseInfo(Session session)
        {
            frmLicenseInfo frmInfo = new frmLicenseInfo();
            if (frmInfo.ShowDialog() == DialogResult.Cancel)
                return ActionResult.UserExit;

            return ActionResult.Success;
        }
    }
}
