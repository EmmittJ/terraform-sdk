namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform moved block for refactoring resources without destroying them.
/// The moved block allows you to rename or move resources, modules, or module calls while preserving
/// the existing infrastructure state.
/// </summary>
/// <remarks>
/// Requires: Terraform 1.1+
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/moved"/></para>
/// <para>
/// The moved block has two required arguments:
/// - from (required): The previous address of the resource
/// - to (required): The new address for the resource
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Move a resource to a new name
/// var moved = new TerraformMovedBlock
/// {
///     From = "aws_instance.a",
///     To = "aws_instance.b"
/// };
///
/// // Move a resource into a module
/// var moved = new TerraformMovedBlock
/// {
///     From = "aws_instance.example",
///     To = "module.instances.aws_instance.example"
/// };
/// </code>
/// </example>
public class TerraformMovedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type keyword for moved blocks.
    /// </summary>
    public override string BlockType => "moved";

    /// <summary>
    /// Gets the block labels (moved blocks have none).
    /// </summary>
    public override string[] BlockLabels => [];

    /// <summary>
    /// The previous address of the resource, module, or resource instance.
    /// </summary>
    public required TerraformValue<string> From
    {
        get => GetRequiredArgument<TerraformValue<string>>("from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// The new address for the resource, module, or resource instance.
    /// </summary>
    public required TerraformValue<string> To
    {
        get => GetRequiredArgument<TerraformValue<string>>("to");
        set => SetArgument("to", value);
    }

    /// <summary>
    /// Resolves this moved block to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }

    /// <inheritdoc/>
    public override TerraformReferenceExpression AsReference()
    {
        throw new NotSupportedException("Moved blocks cannot be referenced in expressions.");
    }
}
