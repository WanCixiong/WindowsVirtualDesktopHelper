using System;
using WindowsVirtualDesktopHelper.VirtualDesktopAPI;
using WindowsVirtualDesktopHelper.VirtualDesktopAPI.Implementation;

class Program
{
    static IVirtualDesktopManager GetDesktopManagerForCurrentOS()
    {
        string implementation = Loader.GetImplementationForOS();
        switch (implementation)
        {
            case Loader.VirtualDesktopWin11_23H2_2921:
                return new VirtualDesktopWin11_23H2_2921();
            case Loader.VirtualDesktopWin11_23H2:
                return new VirtualDesktopWin11_23H2();
            case Loader.VirtualDesktopWin11_22H2:
                return new VirtualDesktopWin11_22H2();
            case Loader.VirtualDesktopWin11_21H2:
                return new VirtualDesktopWin11_21H2();
            case Loader.VirtualDesktopWin11_Insider:
                return new VirtualDesktopWin11_Insider();
            case Loader.VirtualDesktopWin11_Insider22631:
                return new VirtualDesktopWin11_Insider22631();
            case Loader.VirtualDesktopWin11_Insider25314:
                return new VirtualDesktopWin11_Insider25314();
            case Loader.VirtualDesktopWin10:
                return new VirtualDesktopWin10();
            default:
                throw new Exception("Unsupported Windows version");
        }
    }

    static void Main(string[] args)
    {
        var desktopManager = GetDesktopManagerForCurrentOS();

        // 获取当前的桌面索引
        var currentIndex = desktopManager.Current();

        // 如果当前是第一个桌面（索引为0），则切换到下一个（即第二个）桌面
        // 如果当前是第二个桌面（索引为1），则切换到前一个（即第一个）桌面
        if (currentIndex == 0)
        {
            desktopManager.SwitchToDesktop(1);
        }
        else if (currentIndex == 1)
        {
            desktopManager.SwitchToDesktop(0);
        }
    }
}
