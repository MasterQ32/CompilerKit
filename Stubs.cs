using System;
using System.Collections.Generic;
using System.Text;

namespace System.CodeDom.Compiler
{
    public sealed class CompilerErrorCollection : List<CompilerError>
    {
        internal CompilerErrorCollection() => throw new NotSupportedException("CompilerErrorCollection is just stubbed.");
    }

    public sealed class CompilerError
    {
        internal CompilerError() => throw new NotSupportedException("CompilerErrorCollection is just stubbed.");

        public string ErrorText { get; set; }

        public bool IsWarning { get; set; }
    }
}
