// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class TryStatementSyntax
    {
        public TryStatementSyntax Update(SyntaxToken tryKeyword, BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally, FaultedClauseSyntax @faulted)
            => Update(attributeLists: default, tryKeyword, block, catches, @finally, @faulted);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static TryStatementSyntax TryStatement(BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally, FaultedClauseSyntax @faulted)
            => TryStatement(attributeLists: default, block, catches, @finally, @faulted);

        public static TryStatementSyntax TryStatement(SyntaxToken tryKeyword, BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally, FaultedClauseSyntax @faulted)
            => TryStatement(attributeLists: default, tryKeyword, block, catches, @finally, @faulted);
    }
}
