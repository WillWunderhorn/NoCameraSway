using MelonLoader;
using NoCameraSway;
using System.Reflection;

[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCompany("Created by " + BuildInfo.ModAuthor)]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]

[assembly: MelonInfo(typeof(NoCameraSway.NoCameraSway), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor, BuildInfo.OriginalAuthor)]
[assembly: MelonGame("Hinterland", "TheLongDark")]


internal static class BuildInfo
{
    internal const string ModName = "NoCameraSway";
    internal const string ModAuthor = "LittleWolfStorm";
    internal const string OriginalAuthor = "WulfMarius";
    internal const string ModVersion = "2.5.0";
}



