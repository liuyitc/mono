// cs1616.cs: Option 'keyfile' overrides 'System.Reflection.AssemblyKeyFileAttribute' given in source
// Line: 0
// Compiler options: -keyfile:CS1616.snk -warnaserror

using System.Reflection;

[assembly: AssemblyKeyFile("mono.snk")]

class C
{
    public static void Main () {}
}