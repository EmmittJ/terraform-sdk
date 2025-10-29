namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Single context implementation for both prepare and resolve phases.
/// Maintains state throughout the two-pass resolution process.
/// </summary>
public class TerraformContext : ITerraformPrepareContext, ITerraformResolveContext
{
    private readonly HashSet<ITerraformConstruct> _preparingConstructs = new();
    private readonly HashSet<ITerraformConstruct> _resolvingConstructs = new();

    /// <inheritdoc/>
    public TerraformConfiguration Scope { get; }

    /// <summary>
    /// Creates a new context for the given scope.
    /// </summary>
    /// <param name="scope">The configuration scope.</param>
    public TerraformContext(TerraformConfiguration scope)
    {
        Scope = scope ?? throw new ArgumentNullException(nameof(scope));
    }

    /// <inheritdoc/>
    public void Prepare<T>(ITerraformResolvable<T> resolvable)
    {
        if (resolvable == null)
        {
            return;
        }

        // Detect circular preparation
        if (resolvable is ITerraformConstruct construct)
        {
            if (_preparingConstructs.Contains(construct))
            {
                throw new InvalidOperationException(
                    $"Circular dependency detected during preparation of construct: {construct}");
            }

            _preparingConstructs.Add(construct);
            try
            {
                resolvable.Prepare(this);
            }
            finally
            {
                _preparingConstructs.Remove(construct);
            }
        }
        else
        {
            resolvable.Prepare(this);
        }
    }

    /// <inheritdoc/>
    public T Resolve<T>(ITerraformResolvable<T> resolvable)
    {
        if (resolvable == null)
        {
            throw new ArgumentNullException(nameof(resolvable));
        }

        // Detect circular resolution
        if (resolvable is ITerraformConstruct construct)
        {
            if (_resolvingConstructs.Contains(construct))
            {
                throw new InvalidOperationException(
                    $"Circular dependency detected during resolution of construct: {construct}");
            }

            _resolvingConstructs.Add(construct);
            try
            {
                return resolvable.Resolve(this);
            }
            finally
            {
                _resolvingConstructs.Remove(construct);
            }
        }

        return resolvable.Resolve(this);
    }
}
