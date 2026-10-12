using System.Runtime.CompilerServices;

// Allow internal visibility for testing purposes.
[assembly: InternalsVisibleTo("Unity.TextCore")]
[assembly: InternalsVisibleTo("Unity.TextCore.FontEngine.Tools")]

[assembly: InternalsVisibleTo("Unity.FontEngine.Tests")]
[assembly: InternalsVisibleTo("Unity.TextCore.Editor")]
[assembly: InternalsVisibleTo("Unity.TextMeshPro.Editor")]

// Redux's EditMode suite tests the font compatibility materials. It compiles as Assembly-CSharp-Editor on Redux
// develop and as Ksp2Redux.Editor.Tests once the game has its own assembly definitions.
[assembly: InternalsVisibleTo("Assembly-CSharp-Editor")]
[assembly: InternalsVisibleTo("Ksp2Redux.Editor.Tests")]
