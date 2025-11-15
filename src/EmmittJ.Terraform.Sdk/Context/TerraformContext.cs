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

    private int _indentLevel = 0;
    private TerraformBlock? _currentBlock;

    /// <inheritdoc/>
    public TerraformStack Scope { get; } = scope ?? throw new ArgumentNullException(nameof(scope));

    /// <inheritdoc/>
    public int IndentLevel => _indentLevel;

    /// <inheritdoc/>
    public string Indent { get; private set; } = string.Empty;

    /// <inheritdoc/>
    public ITerraformNodeFormatter Formatter { get; } = new TerraformNodeFormatter();



    /// <inheritdoc/>
    public IDisposable SetCurrentBlock(TerraformBlock? block)
    {
        var previousBlock = _currentBlock;
        _currentBlock = block;
        return new BlockScope(this, previousBlock);
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
    /// Disposable helper for managing block scope.
    /// Automatically restores the previous block when disposed.
    /// </summary>
    private class BlockScope : IDisposable
    {
        private readonly TerraformContext _context;
        private readonly TerraformBlock? _previousBlock;

        public BlockScope(TerraformContext context, TerraformBlock? previousBlock)
        {
            _context = context;
            _previousBlock = previousBlock;
        }

        public void Dispose()
        {
            _context._currentBlock = _previousBlock;
        }
    }
}
