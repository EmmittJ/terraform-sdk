namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context implementation for terraform preparation and resolution.
/// Maintains state for indentation and circular dependency detection.
/// </summary>
/// <remarks>
/// Creates a new context for the given scope.
/// </remarks>
/// <param name="scope">The configuration scope.</param>
public class TerraformContext(TerraformConfiguration scope) : ITerraformContext
{
    /// <summary>
    /// Creates a temporary context for testing or one-off resolution.
    /// </summary>
    /// <returns>A temporary context.</returns>
    public static TerraformContext Temporary() => new(new("temp"));

    /// <summary>
    /// Creates a temporary context for testing or one-off resolution.
    /// </summary>
    /// <typeparam name="T">The type of the resolvable.</typeparam>
    /// <param name="resolvable">Optional resolvable to prepare immediately.</param>
    /// <returns>A temporary context with the resolvable prepared (if provided).</returns>
    public static TerraformContext Temporary<T>(ITerraformResolvable<T>? resolvable = null)
    {
        var context = new TerraformContext(new("temp"));
        if (resolvable != null)
        {
            resolvable.Prepare(context);
        }
        return context;
    }

    private int _indentLevel = 0;

    /// <inheritdoc/>
    public TerraformConfiguration Scope { get; } = scope ?? throw new ArgumentNullException(nameof(scope));

    /// <inheritdoc/>
    public int IndentLevel => _indentLevel;

    /// <inheritdoc/>
    public string Indent { get; private set; } = string.Empty;

    /// <inheritdoc/>
    public IDisposable PushIndent()
    {
        _indentLevel++;
        Indent = new string(' ', _indentLevel * 2);
        return new IndentScope(this);
    }

    private void PopIndent()
    {
        if (_indentLevel > 0)
        {
            _indentLevel--;
            Indent = new string(' ', _indentLevel * 2);
        }
    }

    /// <summary>
    /// Disposable helper for managing indent scope.
    /// </summary>
    private class IndentScope(TerraformContext context) : IDisposable
    {
        private readonly TerraformContext _context = context;

        public void Dispose()
        {
            _context.PopIndent();
        }
    }
}