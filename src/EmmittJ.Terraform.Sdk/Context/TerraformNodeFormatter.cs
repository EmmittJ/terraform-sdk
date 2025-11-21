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
    /// Applies equals sign alignment to consecutive single-line arguments.
    /// </summary>
    public List<TerraformSyntaxNode> Format(List<TerraformSyntaxNode> nodes)
    {
        var sorted = new List<TerraformSyntaxNode>();

        // 1. Meta-arguments first (with alignment)
        var metaArgs = nodes
            .OfType<TerraformArgumentNode>()
            .Where(n => _metaArguments.Contains(n.Key))
            .OrderBy(n => n.Key)
            .ToList();
        sorted.AddRange(ApplyAlignment(metaArgs));

        // 2. Blank line after meta-arguments (only if regular content follows)
        var regularArgs = nodes
            .OfType<TerraformArgumentNode>()
            .Where(n => !_metaArguments.Contains(n.Key))
            .OrderBy(n => n.Key)
            .ToList();

        var regularBlocks = nodes
            .OfType<TerraformBlockNode>()
            .Where(n => !_metaArgumentBlocks.Contains(n.BlockType))
            .OrderBy(n => n.BlockType)
            .ToList();

        if (metaArgs.Count > 0 && (regularArgs.Count > 0 || regularBlocks.Count > 0))
        {
            sorted.Add(TerraformEmptyLineNode.Instance);
        }

        // 3. Regular arguments (alphabetically, with alignment)
        sorted.AddRange(ApplyAlignment(regularArgs));

        // 4. Regular blocks (alphabetically)
        sorted.AddRange(regularBlocks);

        // 5. Blank line before meta-argument blocks (only if regular content precedes)
        var metaBlocks = nodes
            .OfType<TerraformBlockNode>()
            .Where(n => _metaArgumentBlocks.Contains(n.BlockType))
            .OrderBy(n => n.BlockType)
            .ToList();

        if (metaBlocks.Count > 0 && (metaArgs.Count > 0 || regularArgs.Count > 0 || regularBlocks.Count > 0))
        {
            sorted.Add(TerraformEmptyLineNode.Instance);
        }
        sorted.AddRange(metaBlocks);

        // 6. Any other nodes not matched above (comments, etc.)
        var otherNodes = nodes
            .Where(n => n is not TerraformArgumentNode && n is not TerraformBlockNode)
            .ToList();
        sorted.AddRange(otherNodes);

        return sorted;
    }

    /// <summary>
    /// Applies equals sign alignment to argument nodes per Terraform style guide.
    /// Only single-line values participate in alignment; multi-line values (maps) are excluded.
    /// Alignment column is calculated as the longest key length + 1 space.
    /// </summary>
    private static IEnumerable<TerraformArgumentNode> ApplyAlignment(IEnumerable<TerraformArgumentNode> args)
    {
        var argsList = args.ToList();
        if (argsList.Count == 0)
        {
            return argsList;
        }

        // Only align single-line values
        var singleLineArgs = argsList
            .Where(arg => !IsMultiLineValue(arg.Value))
            .ToList();

        if (singleLineArgs.Count == 0)
        {
            return argsList;
        }

        // Calculate alignment column: max key length + 1 space
        var alignmentColumn = singleLineArgs.Max(arg => arg.Key.Length) + 1;

        // Create aligned nodes
        return argsList.Select(arg =>
            IsMultiLineValue(arg.Value)
                ? arg  // No alignment for multi-line values
                : new TerraformArgumentNode(arg.Key, arg.Value, alignmentColumn)
        );
    }

    /// <summary>
    /// Determines if a value expression will render as multi-line HCL.
    /// Currently only TerraformMapExpression produces multi-line output (except empty maps).
    /// </summary>
    private static bool IsMultiLineValue(TerraformSyntaxNode node)
    {
        return node is TerraformMapExpression map && !IsEmptyMap(map);
    }

    /// <summary>
    /// Checks if a TerraformMapExpression is empty (will render as {}).
    /// </summary>
    private static bool IsEmptyMap(TerraformMapExpression map)
    {
        return map.Count == 0;
    }
}
