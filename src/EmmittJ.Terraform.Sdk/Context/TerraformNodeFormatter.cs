namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Default implementation of node formatting based on HCL conventions.
/// Sorts nodes and inserts blank lines per the HashiCorp style guide.
/// Follows https://developer.hashicorp.com/terraform/language/style
/// </summary>
/// <remarks>
/// Output structure (per HashiCorp style guide):
/// 1. Meta-arguments (count, for_each, depends_on, provider)
/// 2. Blank line
/// 3. Regular arguments (alphabetically)
/// 4. Regular blocks (alphabetically)
/// 5. Blank line
/// 6. Meta-argument blocks (lifecycle)
/// </remarks>
public class TerraformNodeFormatter : ITerraformNodeFormatter
{
    // Meta-argument ordering per HashiCorp style guide
    private static readonly HashSet<string> _metaArguments = new()
    {
        "count",
        "for_each",
        "depends_on",
        "provider",
    };

    private static readonly HashSet<string> _metaArgumentBlocks = new()
    {
        "lifecycle",
    };

    /// <summary>
    /// Formats syntax nodes by sorting and inserting blank lines per HCL conventions.
    /// </summary>
    public IEnumerable<TerraformSyntaxNode> Format(IEnumerable<TerraformSyntaxNode> nodes)
    {
        var nodeList = nodes.ToList();
        var sorted = new List<TerraformSyntaxNode>();

        // 1. Meta-arguments first
        var metaArgs = nodeList
            .OfType<TerraformArgumentNode>()
            .Where(n => _metaArguments.Contains(n.Key))
            .OrderBy(n => n.Key);
        sorted.AddRange(metaArgs);

        // 2. Blank line after meta-arguments (if any)
        if (metaArgs.Any())
        {
            sorted.Add(TerraformEmptyLineNode.Instance);
        }

        // 3. Regular arguments (alphabetically)
        var regularArgs = nodeList
            .OfType<TerraformArgumentNode>()
            .Where(n => !_metaArguments.Contains(n.Key))
            .OrderBy(n => n.Key);
        sorted.AddRange(regularArgs);

        // 4. Regular blocks (alphabetically)
        var regularBlocks = nodeList
            .OfType<TerraformBlockNode>()
            .Where(n => !_metaArgumentBlocks.Contains(n.Label))
            .OrderBy(n => n.Label);
        sorted.AddRange(regularBlocks);

        // 5. Blank line before meta-argument blocks (if any)
        var metaBlocks = nodeList
            .OfType<TerraformBlockNode>()
            .Where(n => _metaArgumentBlocks.Contains(n.Label))
            .OrderBy(n => n.Label)
            .ToList();

        if (metaBlocks.Any())
        {
            sorted.Add(TerraformEmptyLineNode.Instance);
            sorted.AddRange(metaBlocks);
        }

        // 6. Any other nodes not matched above (comments, etc.)
        var otherNodes = nodeList
            .Where(n => n is not TerraformArgumentNode && n is not TerraformBlockNode)
            .ToList();
        sorted.AddRange(otherNodes);

        return sorted;
    }
}
