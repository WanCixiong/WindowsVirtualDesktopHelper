using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace WindowsVirtualDesktopHelper.VirtualDesktopAPI
{
    public class Loader
    {

        public const string VirtualDesktopWin11_23H2_2921 = "VirtualDesktopWin11_23H2_2921";
        public const string VirtualDesktopWin11_23H2 = "VirtualDesktopWin11_23H2";
        public const string VirtualDesktopWin11_22H2 = "VirtualDesktopWin11_22H2";
        public const string VirtualDesktopWin11_21H2 = "VirtualDesktopWin11_21H2";
        public const string VirtualDesktopWin11_Insider = "VirtualDesktopWin11_Insider";
        public const string VirtualDesktopWin11_Insider22631 = "VirtualDesktopWin11_Insider22631";
        public const string VirtualDesktopWin11_Insider25314 = "VirtualDesktopWin11_Insider25314";
        public const string VirtualDesktopWin10 = "VirtualDesktopWin10";

        public static int GetWindowsBuildVersion()
        {
            // via https://stackoverflow.com/questions/69038560/detect-windows-11-with-net-framework-or-windows-api
            var reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var currentBuildStr = (string)reg.GetValue("CurrentBuild");
            var currentBuild = int.Parse(currentBuildStr);
            return currentBuild;
        }

        // Revision
        public static int GetWindowsBuildRevision()
        {
            var reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var currentRevision = (int)reg.GetValue("UBR");
            return currentRevision;
        }

        public static string GetImplementationForOS()
        {
            // We need to load the correct API for correct windows version...
            // See https://www.anoopcnair.com/windows-11-version-numbers-build-numbers-major/ for versions
            int currentBuild = 0;
            int currentBuildRevision = 0;
            currentBuild = GetWindowsBuildVersion();
            currentBuildRevision = GetWindowsBuildRevision();
            if (currentBuild >= 25314)
            {
                return VirtualDesktopWin11_Insider25314;
            }
            else if (currentBuild >= 25158)
            {
                return VirtualDesktopWin11_Insider;
            }
            else if (currentBuild >= 23403)
            {
                return VirtualDesktopWin11_Insider;
            }
            else if (currentBuild >= 22631)
            {
                return VirtualDesktopWin11_Insider22631;
            }
            else if (currentBuild >= 22621)
            {
                if (currentBuildRevision >= 2921 && currentBuildRevision < 3007)
                {
                    return VirtualDesktopWin11_23H2_2921;
                }
                else if (currentBuildRevision >= 2050)
                {
                    return VirtualDesktopWin11_23H2;
                }
                else
                {
                    return VirtualDesktopWin11_22H2;
                }
            }
            else if (currentBuild >= 22000)
            {
                return VirtualDesktopWin11_21H2;
            }
            else if (currentBuild >= 21996)
            {
                return VirtualDesktopWin11_21H2;
            }
            else
            {
                return VirtualDesktopWin10;
            }
        }
    }
}
