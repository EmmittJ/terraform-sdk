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
    private ITerraformConstruct? _currentConstruct;
    private readonly DependencyGraph _dependencyGraph = new();

    /// <inheritdoc/>
    public TerraformConfiguration Scope { get; } = scope ?? throw new ArgumentNullException(nameof(scope));

    /// <inheritdoc/>
    public int IndentLevel => _indentLevel;

    /// <inheritdoc/>
    public string Indent { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the dependency graph being built during the Prepare phase.
    /// </summary>
    public DependencyGraph DependencyGraph => _dependencyGraph;

    /// <summary>
    /// Sets the current construct being prepared/resolved.
    /// Used for automatic dependency tracking.
    /// </summary>
    /// <param name="construct">The current construct.</param>
    // TODO: Add this to the ITerraformContext interface
    // TODO: consider making this IDisposable to auto-reset after scope
    public void SetCurrentConstruct(ITerraformConstruct? construct)
    {
        _currentConstruct = construct;
        if (construct != null)
        {
            _dependencyGraph.AddConstruct(construct);
        }
    }

    /// <summary>
    /// Records a dependency from the current construct to another construct.
    /// Called automatically when resolving references during the Prepare phase.
    /// </summary>
    /// <param name="dependency">The construct being depended upon.</param>
    // TODO: Add this to the ITerraformContext interface
    public void RecordDependency(ITerraformConstruct dependency)
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
}