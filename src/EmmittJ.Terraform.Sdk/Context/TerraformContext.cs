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

    /// <summary>
    /// Creates a temporary context for testing or one-off resolution with a serializable item.
    /// </summary>
    /// <param name="serializable">Optional serializable to prepare immediately.</param>
    /// <returns>A temporary context with the serializable prepared (if provided).</returns>
    public static TerraformContext Temporary(ITerraformSerializable? serializable = null)
    {
        var context = new TerraformContext(new() { Name = "temp" });
        if (serializable != null)
        {
            serializable.Prepare(context);
        }
        return context;
    }

    private int _indentLevel = 0;
    private TerraformBlock? _currentConstruct;
    private readonly DependencyGraph _dependencyGraph = new();

    /// <inheritdoc/>
    public TerraformStack Scope { get; } = scope ?? throw new ArgumentNullException(nameof(scope));

    /// <inheritdoc/>
    public int IndentLevel => _indentLevel;

    /// <inheritdoc/>
    public string Indent { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the dependency graph being built during the Prepare phase.
    /// </summary>
    public DependencyGraph DependencyGraph => _dependencyGraph;

    /// <inheritdoc/>
    public IDisposable SetCurrentConstruct(TerraformBlock? construct)
    {
        var previousConstruct = _currentConstruct;
        _currentConstruct = construct;
        if (construct != null)
        {
            _dependencyGraph.AddConstruct(construct);
        }
        return new ConstructScope(this, previousConstruct);
    }

    /// <inheritdoc/>
    public void RecordDependency(TerraformBlock dependency)
    {
        if (_currentConstruct != null && dependency != _currentConstruct)
        {
            _dependencyGraph.AddDependency(_currentConstruct, dependency);
        }
    }

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

    /// <summary>
    /// Disposable helper for managing construct scope.
    /// Automatically restores the previous construct when disposed.
    /// </summary>
    private class ConstructScope : IDisposable
    {
        private readonly TerraformContext _context;
        private readonly TerraformBlock? _previousConstruct;

        public ConstructScope(TerraformContext context, TerraformBlock? previousConstruct)
        {
            _context = context;
            _previousConstruct = previousConstruct;
        }

        public void Dispose()
        {
            _context._currentConstruct = _previousConstruct;
        }
    }
}
