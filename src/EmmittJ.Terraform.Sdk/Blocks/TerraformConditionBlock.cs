namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a condition block (precondition, postcondition, or validation) for lifecycle, output, and variable validation.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/validate"/></para>
/// </remarks>
public class TerraformConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type (e.g., "precondition", "postcondition", "validation").
    /// </summary>
    public override string BlockType { get; }

    /// <summary>
    /// Initializes a new instance of TerraformConditionBlock.
    /// </summary>
    /// <param name="blockType">The block type ("precondition", "postcondition", or "validation").</param>
    public TerraformConditionBlock(string blockType)
    {
        if (string.IsNullOrWhiteSpace(blockType))
            throw new ArgumentException("Block type cannot be null or empty.", nameof(blockType));

        BlockType = blockType;
    }

    /// <summary>
    /// Gets or sets the condition expression that must evaluate to true.
    /// </summary>
    public required TerraformValue<string> Condition
    {
        get => GetRequiredArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Gets or sets the error message to display when the condition is false.
    /// </summary>
    public required TerraformValue<string> ErrorMessage
    {
        get => GetRequiredArgument<TerraformValue<string>>("error_message");
        set => SetArgument("error_message", value);
    }
}
