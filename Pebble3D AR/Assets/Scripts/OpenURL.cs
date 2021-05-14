using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{

    public void OpenUltimakerRequest()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/requests/new");
    }

    public void OpenUltimakerFirmware()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360012490620");
    }

    public void OpenER27Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011574780-ER27-Unspecified-error");
    }

    public void OpenER29Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011681999-ER29-Print-core-min-temp");
    }

    public void OpenER31Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011682179-ER31-Print-core-heater-error");
    }

    public void OpenER39Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360012116599-ER39-Incorrect-print-temperature-specified");
    }

    public void OpenER41Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011682639-ER41-Motion-controller-failed-to-update");
    }
    public void OpenER42Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011682659-ER42-Print-job-not-suitable-for-printer");
    }

    public void OpenER44Link()
    {
        Application.OpenURL("https://support.ultimaker.com/hc/en-us/articles/360011575840-ER44-Unable-to-download-firmware-due-to-lack-of-space-on-printer");
    }

    public void OpenRibbonCable()
    {
        Application.OpenURL("https://support.raise3d.com/Pro2-Series/how-to-replace-the-ribbon-cable-4-351.html");
    }

    public void OpenThermocouple()
    {
        Application.OpenURL("https://support.raise3d.com/E2/how-to-replace-the-thermocouple-20-1343.html");
    }
}
