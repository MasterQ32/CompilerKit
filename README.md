# CompilerKit
A tokenizer generator which is used in the psilang compiler

**Usage example:**
```cs
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ assembly name="System.Core" #>
<#@ assembly name="$(SolutionDir)/bin/$(Config)/CompilerKit.dll" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Text.RegularExpressions" #>
<#@ import namespace="System.IO" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ output extension=".gen.cs" #>
using System;
using System.IO;
using System.Text.RegularExpressions;
using CompilerKit;

namespace Psi.Compiler.Grammar
{
	<#
	var prefix = "Psi";
	var tokens = CompilerKit.TokenDefinitionFile.Load(Host.ResolvePath("Psi.tok"));
	#>
	<#= CompilerKit.Generator.Tokenizer(prefix, tokens) #>
}

```
