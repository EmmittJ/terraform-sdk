namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a lazy Terraform value that will be computed during resolution.
/// The producer function must return a TerraformExpression.
/// </summary>
public class TerraformLazyValue : ITerraformResolvable
{
    private readonly Func<ITerraformContext, TerraformExpression> _producer;

    /// <summary>
    /// Creates a new TerraformLazyValue with the specified producer function.
    /// </summary>
    /// <param name="producer">A function that produces a TerraformExpression when called with a resolution context.</param>
    /// <exception cref="ArgumentNullException">Thrown if producer is null.</exception>
    public TerraformLazyValue(Func<ITerraformContext, TerraformExpression> producer)
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }

    /// <summary>
    /// Resolves this lazy value by invoking the producer function.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The TerraformExpression produced by the producer function.</returns>
    public TerraformExpression Resolve(ITerraformContext context)
    {
        return _producer(context);
    }
}
