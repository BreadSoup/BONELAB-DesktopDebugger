using System.Reflection;
using DesktopDebugger;
using MelonLoader;

[assembly: AssemblyTitle(DesktopDebugger.Main.Description)]
[assembly: AssemblyDescription(DesktopDebugger.Main.Description)]
[assembly: AssemblyCompany(DesktopDebugger.Main.Company)]
[assembly: AssemblyProduct(DesktopDebugger.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + DesktopDebugger.Main.Author)]
[assembly: AssemblyTrademark(DesktopDebugger.Main.Company)]
[assembly: AssemblyVersion(DesktopDebugger.Main.Version)]
[assembly: AssemblyFileVersion(DesktopDebugger.Main.Version)]
[assembly: MelonInfo(typeof(DesktopDebugger.Main), DesktopDebugger.Main.Name, DesktopDebugger.Main.Version, DesktopDebugger.Main.Author, DesktopDebugger.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]