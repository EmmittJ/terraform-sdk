namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Context implementation for terraform preparation and resolution.
/// Maintains state for indentation and circular dependency detection.
/// </summary>
/// <remarks>
/// Creates a new context for the given scope.
/// </remarks>
/// <param name="scope">The configuration scope.</param>
public class TerraformContext(TerraformStack scope) : ITerraformContext
{
    /// <summary>
    /// Creates a temporary context for testing or one-off resolution.
    /// </summary>
    /// <returns>A temporary context.</returns>
    public static TerraformContext Temporary() => new(new() { Name = "temp" });

    private ITerraformValue? _currentValue;

    /// <inheritdoc/>
    public int IndentLevel { get; private set; } = 0;

    /// <inheritdoc/>
    public string Indent { get; private set; } = string.Empty;

    /// <inheritdoc/>
    public TerraformStack Scope { get; } = scope ?? throw new ArgumentNullException(nameof(scope));

    /// <inheritdoc/>
    public ITerraformNodeFormatter Formatter { get; } = new TerraformNodeFormatter();

    /// <inheritdoc/>
    public IDisposable PushCurrentValue(ITerraformValue? value)
    {
        var previousValue = _currentValue;
        _currentValue = value;
        return new ValueScope(this, previousValue);
    }

    /// <inheritdoc/>
    public IDisposable PushIndent()
    {
        IndentLevel++;
        Indent = new string(' ', IndentLevel * 2);
        return new IndentScope(this);
    }

    private void PopIndent()
    {
        if (IndentLevel > 0)
        {
            IndentLevel--;
            Indent = new string(' ', IndentLevel * 2);
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

    /// <summary>
    /// Disposable helper for managing block scope.
    /// Automatically restores the previous block when disposed.
    /// </summary>
    private class ValueScope : IDisposable
    {
        private readonly TerraformContext _context;
        private readonly ITerraformValue? _previousValue;

        public ValueScope(TerraformContext context, ITerraformValue? previousValue)
        {
            _context = context;
            _previousValue = previousValue;
        }

        public void Dispose()
        {
            _context._currentValue = _previousValue;
        }
    }
}
