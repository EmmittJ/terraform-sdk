namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for ITerraformTopLevelBlock.
/// Provides helper methods for working with top-level Terraform blocks.
/// </summary>
public static class TerraformTopLevelBlockExtensions
{
    /// <summary>
    /// Gets a user-friendly display name for the block.
    /// Combines the block type with its labels for easy identification.
    /// Examples: "resource.aws_s3_bucket.my_bucket", "data.aws_ami.ubuntu", "variable.region"
    /// </summary>
    /// <param name="block">The block to get the display name for.</param>
    /// <returns>A string in the format "blockType.label1.label2..." or just "blockType" if no labels.</returns>
    public static string GetDisplayName(this ITerraformTopLevelBlock block)
    {
        if (block == null)
            throw new ArgumentNullException(nameof(block));

        var labels = block.BlockLabels;
        if (labels == null || labels.Length == 0)
        {
            return block.BlockType;
        }

        return $"{block.BlockType}.{string.Join(".", labels)}";
    }

    /// <summary>
    /// Gets the fully qualified name for the block, which is the display name.
    /// This is an alias for GetDisplayName for clarity in certain contexts.
    /// </summary>
    /// <param name="block">The block to get the qualified name for.</param>
    /// <returns>The fully qualified name.</returns>
    public static string GetQualifiedName(this ITerraformTopLevelBlock block)
    {
        return GetDisplayName(block);
    }

    /// <summary>
    /// Gets the primary label for the block (typically the name/identifier).
    /// For resources and data sources, this is usually the second label (the resource name).
    /// For variables, outputs, and locals, this is the first label.
    /// </summary>
    /// <param name="block">The block to get the primary label for.</param>
    /// <returns>The primary label, or null if no labels exist.</returns>
    public static string? GetPrimaryLabel(this ITerraformTopLevelBlock block)
    {
        if (block == null)
            throw new ArgumentNullException(nameof(block));

        var labels = block.BlockLabels;
        if (labels == null || labels.Length == 0)
        {
            return null;
        }

        // For resources and data sources, the second label is the name
        // For other blocks (variable, output, local), the first label is the name
        if ((block.BlockType == "resource" || block.BlockType == "data") && labels.Length >= 2)
        {
            return labels[1];
        }

        return labels[0];
    }

    /// <summary>
    /// Checks if this block is a resource block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a resource block, false otherwise.</returns>
    public static bool IsResource(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "resource";
    }

    /// <summary>
    /// Checks if this block is a data source block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a data source block, false otherwise.</returns>
    public static bool IsDataSource(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "data";
    }

    /// <summary>
    /// Checks if this block is a variable block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a variable block, false otherwise.</returns>
    public static bool IsVariable(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "variable";
    }

    /// <summary>
    /// Checks if this block is an output block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is an output block, false otherwise.</returns>
    public static bool IsOutput(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "output";
    }

    /// <summary>
    /// Checks if this block is a module block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a module block, false otherwise.</returns>
    public static bool IsModule(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "module";
    }

    /// <summary>
    /// Checks if this block is a provider block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a provider block, false otherwise.</returns>
    public static bool IsProvider(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "provider";
    }

    /// <summary>
    /// Checks if this block is a locals block.
    /// </summary>
    /// <param name="block">The block to check.</param>
    /// <returns>True if this is a locals block, false otherwise.</returns>
    public static bool IsLocals(this ITerraformTopLevelBlock block)
    {
        return block?.BlockType == "locals";
    }
}
