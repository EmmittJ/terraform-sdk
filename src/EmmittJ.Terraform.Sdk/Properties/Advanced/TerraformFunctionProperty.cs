namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform function call property.
/// Resolves to a function call expression: function_name(arg1, arg2, ...)
/// </summary>
/// <typeparam name="TValue">The expected type of the value when resolved.</typeparam>
/// <remarks>
/// This property type provides a type-safe way to create function call expressions in Terraform.
/// Supports Terraform's built-in functions like merge(), element(), cidrsubnet(), etc.
///
/// Usage:
/// <code>
/// // Merge maps using merge() function
/// instance.Tags = new TerraformFunctionProperty&lt;Dictionary&lt;string, string&gt;&gt;(
///     "merge",
///     TerraformExpression.Identifier("var.common_tags"),
///     new TerraformMap&lt;string&gt; { ["Name"] = "my-instance" }
/// );
/// // Generates: tags = merge(var.common_tags, { Name = "my-instance" })
///
/// // Get element from list using element() function
/// instance.SubnetId = new TerraformFunctionProperty&lt;string&gt;(
///     "element",
///     subnet.Ids,  // Reference to list property
///     0
/// );
/// // Generates: subnet_id = element(aws_subnet.main.ids, 0)
///
/// // Calculate CIDR subnet
/// subnet.CidrBlock = new TerraformFunctionProperty&lt;string&gt;(
///     "cidrsubnet",
///     vpc.CidrBlock,
///     8,
///     1
/// );
/// // Generates: cidr_block = cidrsubnet(aws_vpc.main.cidr_block, 8, 1)
/// </code>
/// </remarks>
public class TerraformFunctionProperty<TValue> : TerraformProperty<TValue>
{
    private readonly string _functionName;
    private readonly TerraformProperty<object>[] _arguments;

    /// <summary>
    /// Initializes a new function call property.
    /// </summary>
    /// <param name="functionName">The name of the Terraform function to call.</param>
    /// <param name="arguments">The arguments to pass to the function.</param>
    public TerraformFunctionProperty(string functionName, params TerraformProperty<object>[] arguments)
        : base("", "")
    {
        _functionName = functionName ?? throw new ArgumentNullException(nameof(functionName));
        _arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));
    }

    /// <summary>
    /// Initializes a new function call property with mixed argument types.
    /// Automatically wraps non-property arguments in appropriate property types.
    /// </summary>
    /// <param name="functionName">The name of the Terraform function to call.</param>
    /// <param name="arguments">The arguments to pass to the function (can be values, properties, or expressions).</param>
    public TerraformFunctionProperty(string functionName, params object[] arguments)
        : base("", "")
    {
        _functionName = functionName ?? throw new ArgumentNullException(nameof(functionName));
        _arguments = arguments?.Select(WrapArgument).ToArray() ?? throw new ArgumentNullException(nameof(arguments));
    }

    private static TerraformProperty<object> WrapArgument(object arg)
    {
        return arg switch
        {
            TerraformProperty<object> prop => prop,
            TerraformExpression expr => new TerraformExpressionProperty<object>("", "", expr),
            _ => new TerraformLiteralProperty<object>("", "") { Value = arg }
        };
    }

    /// <summary>
    /// Preparation phase - prepares all argument values.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        foreach (var arg in _arguments)
        {
            if (arg is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - resolves to a function call expression.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform function call expression.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        var resolvedArgs = _arguments
            .Select(arg => arg.Resolve(context))
            .ToArray();

        return new FunctionCallExpression(_functionName, resolvedArgs);
    }
}
