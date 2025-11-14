namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a condition block (precondition, postcondition, or validation) for lifecycle, output, and variable validation.
/// </summary>
public class TerraformConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type (e.g., "precondition", "postcondition", "validation").
    /// </summary>
    public override string BlockType { get; }

    public TerraformConditionBlock(string blockType, string condition, string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(blockType))
            throw new ArgumentException("Block type cannot be null or empty.", nameof(blockType));
        if (string.IsNullOrWhiteSpace(condition))
            throw new ArgumentException("Condition cannot be null or empty.", nameof(condition));
        if (string.IsNullOrWhiteSpace(errorMessage))
            throw new ArgumentException("Error message cannot be null or empty.", nameof(errorMessage));

        BlockType = blockType;
        this["condition"] = TerraformExpression.Raw(condition);
        this["error_message"] = errorMessage;
    }
}
