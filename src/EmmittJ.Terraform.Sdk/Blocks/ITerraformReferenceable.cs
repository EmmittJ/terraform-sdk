namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for Terraform blocks that can be referenced in expressions.
/// </summary>
/// <remarks>
/// <para>
/// This interface provides compile-time safety by restricting which blocks can be used in reference expressions.
/// Only blocks that can be meaningfully referenced in Terraform HCL should implement this interface.
/// </para>
/// <para>
/// Examples of referenceable blocks:
/// <list type="bullet">
/// <item><description>Resources: <c>aws_instance.web</c></description></item>
/// <item><description>Data sources: <c>data.aws_ami.ubuntu</c></description></item>
/// <item><description>Variables: <c>var.region</c></description></item>
/// <item><description>Locals: <c>local.instance_count</c></description></item>
/// <item><description>Modules: <c>module.vpc</c></description></item>
/// </list>
/// </para>
/// <para>
/// Blocks that cannot be referenced (and should NOT implement this interface):
/// <list type="bullet">
/// <item><description>Backend blocks</description></item>
/// <item><description>Provider blocks</description></item>
/// <item><description>Terraform settings blocks</description></item>
/// <item><description>Check/Assert blocks</description></item>
/// <item><description>Import/Moved blocks</description></item>
/// </list>
/// </para>
/// </remarks>
public interface ITerraformReferenceable
{
    /// <summary>
    /// Creates a reference expression to this block.
    /// </summary>
    /// <returns>
    /// A <see cref="TerraformExpression"/> that represents a reference to this block
    /// in Terraform HCL syntax.
    /// </returns>
    /// <example>
    /// <code>
    /// var resource = new TerraformResource("aws_instance", "web");
    /// var reference = resource.AsReference(); // Returns: aws_instance.web
    /// </code>
    /// </example>
    TerraformExpression AsReference();

}

/// <summary>
/// Interface for Terraform blocks that contain named values which can be individually referenced.
/// </summary>
/// <remarks>
/// <para>
/// This interface extends <see cref="ITerraformReferenceable"/> for blocks that act as containers
/// for multiple named values, where each value can be referenced independently.
/// </para>
/// <para>
/// Examples:
/// <list type="bullet">
/// <item><description>Locals block referencing individual locals: <c>local.instance_count</c></description></item>
/// <item><description>Module referencing outputs: <c>module.vpc.vpc_id</c></description></item>
/// </list>
/// </para>
/// </remarks>
public interface ITerraformNamedReferenceable : ITerraformReferenceable
{
    /// <summary>
    /// Creates a reference to an attribute of this block.
    /// </summary>
    /// <param name="name">The name of the attribute to reference.</param>
    /// <returns>
    /// A <see cref="TerraformExpression"/> that represents a reference to the specified attribute.
    /// </returns>
    /// <example>
    /// <code>
    /// var locals = new TerraformLocals();
    /// TerraformValue&lt;string&gt; region = locals.AsReference("region");
    /// </code>
    /// </example>
    TerraformExpression AsReference(string name);
}
