namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Utility class for creating type-safe resolvable tokens and lazy values.
/// Provides helpers for common token operations and type conversions.
/// </summary>
public static class Token
{
    /// <summary>
    /// Wraps a resolvable as a string token.
    /// </summary>
    public static ITerraformResolvable<string> AsString(ITerraformResolvable<string> value) => value;

    /// <summary>
    /// Wraps a resolvable as an integer token.
    /// </summary>
    public static ITerraformResolvable<int> AsNumber(ITerraformResolvable<int> value) => value;

    /// <summary>
    /// Wraps a resolvable as a boolean token.
    /// </summary>
    public static ITerraformResolvable<bool> AsBoolean(ITerraformResolvable<bool> value) => value;

    /// <summary>
    /// Wraps a resolvable as a list token.
    /// </summary>
    public static ITerraformResolvable<List<T>> AsList<T>(ITerraformResolvable<List<T>> value) => value;

    /// <summary>
    /// Wraps a resolvable as a TerraformExpression token.
    /// </summary>
    public static ITerraformResolvable<TerraformExpression> AsExpression(ITerraformResolvable<TerraformExpression> value) => value;

    /// <summary>
    /// Creates a lazy value that will be computed at resolution time.
    /// </summary>
    /// <typeparam name="T">The type of value to produce.</typeparam>
    /// <param name="producer">Function that produces the value at resolution time.</param>
    /// <returns>A lazy resolvable value.</returns>
    public static ITerraformResolvable<T> Lazy<T>(Func<ITerraformContext, T> producer)
        => new LazyValue<T>(producer);

    /// <summary>
    /// Creates a lazy value that will be computed at resolution time (without needing context).
    /// </summary>
    /// <typeparam name="T">The type of value to produce.</typeparam>
    /// <param name="producer">Function that produces the value at resolution time.</param>
    /// <returns>A lazy resolvable value.</returns>
    public static ITerraformResolvable<T> Lazy<T>(Func<T> producer)
        => new LazyValue<T>(_ => producer());
}

/// <summary>
/// Internal implementation of a lazy value that defers computation until resolution.
/// </summary>
internal class LazyValue<T>(Func<ITerraformContext, T> producer) : ITerraformResolvable<T>
{
    private readonly Func<ITerraformContext, T> _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    private T? _cachedValue;
    private bool _isCached;

    public void Prepare(ITerraformContext context)
    {
        // Lazy values don't need preparation - they're computed at resolution time
    }

    public T Resolve(ITerraformContext? context = null)
    {
        if (context is null)
        {
            throw new InvalidOperationException("LazyValue requires a resolution context.");
        }

        if (!_isCached || _cachedValue is null)
        {
            _cachedValue = _producer(context);
            _isCached = true;
        }

        return _cachedValue;
    }
}
