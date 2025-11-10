namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform block - a nested configuration structure.
/// Serializes without the = operator (block syntax).
/// </summary>
/// <typeparam name="TValue">The type of the nested block value.</typeparam>
/// <remarks>
/// Blocks are structural configuration elements in Terraform, distinct from attributes.
/// They use curly brace syntax without the = operator:
///
/// <code>
/// resource "aws_instance" "web" {
///   ebs_block_device {        // ← Block (no =)
///     volume_size = 100       // ← Attributes inside block
///     volume_type = "gp3"
///   }
/// }
/// </code>
///
/// Usage:
/// <code>
/// public class AwsInstanceRootBlockDevice
/// {
///     public TerraformProperty&lt;int&gt; VolumeSize { get; set; }
///     public TerraformProperty&lt;string&gt; VolumeType { get; set; }
/// }
///
/// public class AwsInstance : TerraformResource
/// {
///     public TerraformBlock&lt;AwsInstanceRootBlockDevice&gt;? RootBlockDevice { get; set; }
/// }
///
/// // User code
/// var instance = new AwsInstance("web", "main")
/// {
///     RootBlockDevice = new AwsInstanceRootBlockDevice
///     {
///         VolumeSize = 30,
///         VolumeType = "gp3"
///     }
/// };
/// </code>
/// </remarks>
public class TerraformBlock<TValue> : TerraformProperty<TValue>, ITerraformBlock
    where TValue : class, new()
{
    private TValue? _value;

    /// <summary>
    /// Initializes a new Terraform block property.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the block.</param>
    public TerraformBlock(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Gets or sets the block value.
    /// </summary>
    public TValue? Value
    {
        get => _value;
        internal set => _value = value;
    }

    /// <summary>
    /// Preparation phase - prepares the nested block value if it's preparable.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        if (_value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - resolves to the block's expression.
    /// If the block value implements ITerraformResolvable, use its resolution.
    /// Otherwise, create an object expression from the block's properties (requires code generation).
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing the block.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        if (_value is null)
        {
            // No value set, return empty expression (will be filtered out during serialization)
            return TerraformExpression.Raw("");
        }

        // If value is resolvable, resolve it
        if (_value is ITerraformResolvable<TerraformExpression> resolvable)
        {
            return resolvable.Resolve(context);
        }

        // Otherwise, we need generated Resolve() method on the block class
        // This will be handled by code generation - each block class will implement ITerraformResolvable
        throw new InvalidOperationException(
            $"Block type {typeof(TValue).Name} must implement ITerraformResolvable<TerraformExpression> or provide a Resolve() method via code generation.");
    }

    /// <summary>
    /// Implicit conversion from TValue.
    /// Enables ergonomic block assignment.
    /// </summary>
    /// <param name="value">The block value to wrap.</param>
    public static implicit operator TerraformBlock<TValue>(TValue? value)
    {
        var block = new TerraformBlock<TValue>("", "");
        block._value = value;
        return block;
    }
}
