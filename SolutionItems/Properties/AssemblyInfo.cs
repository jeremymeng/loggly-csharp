using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: AssemblyCompany("Karl Seguin")]
[assembly: AssemblyCopyright("Copyright � Karl Seguin 2010")]
[assembly: AssemblyVersion("3.5.0.0")]
[assembly: AssemblyInformationalVersion("3.5.0-alpha-v2")]
[assembly: AllowPartiallyTrustedCallers]
[assembly: AssemblyProduct("loggly-csharp")]
[assembly: InternalsVisibleTo("Loggly.Tests")]
#if DEBUG
    [assembly: AssemblyConfiguration("Debug")]
#else
    [assembly: AssemblyConfiguration("Release")]
#endif
