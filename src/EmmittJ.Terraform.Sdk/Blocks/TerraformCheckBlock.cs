namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform check block for infrastructure validation (Terraform 1.5+).
/// Check blocks execute as the last step of plan or apply operations to validate infrastructure.
/// Unlike other validations, check failures report warnings but do not block operations.
/// Continuous validation requires enabling health checks in HCP Terraform workspaces.
/// Check blocks can contain scoped data sources and multiple assert blocks.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/check"/></para>
/// </remarks>
/// <example>
/// <code>
/// var check = new TerraformCheckBlock("health_check");
///
/// // Add a data source
/// var httpCheck = new TerraformDataSource("http", "example", new {
///     url = "https://example.com/health"
/// });
/// check.AddDataSource(httpCheck);
///
/// // Add assertions
/// check.AddAssert(new TerraformAssertBlock(
///     condition: "data.http.example.status_code == 200",
///     errorMessage: "Health check failed"
/// ));
/// </code>
/// </example>
public class TerraformCheckBlock : TerraformBlock
{
    private readonly List<TerraformDataSource> _dataSources = new();
    private readonly List<TerraformAssertBlock> _asserts = new();

    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "check";

    /// <summary>
    /// Gets the block labels (just the check name).
    /// </summary>
    public override string[] BlockLabels => [Name];

    /// <summary>
    /// Gets the name of the check block.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Adds a scoped data source to the check block.
    /// Nested data sources are only accessible within their parent check block.
    /// Terraform fetches nested data sources as the final step of plan or apply operations,
    /// after applying the rest of the configuration.
    /// </summary>
    /// <param name="dataSource">The data source to add.</param>
    /// <returns>This check block for fluent chaining.</returns>
    public TerraformCheckBlock AddDataSource(TerraformDataSource dataSource)
    {
        if (dataSource == null)
            throw new ArgumentNullException(nameof(dataSource));

        _dataSources.Add(dataSource);
        return this;
    }

    /// <summary>
    /// Adds an assert block to the check block.
    /// A check block must contain at least one assert block.
    /// For a check to pass, all assert block conditions must evaluate to true.
    /// </summary>
    /// <param name="assert">The assert block to add.</param>
    /// <returns>This check block for fluent chaining.</returns>
    public TerraformCheckBlock AddAssert(TerraformAssertBlock assert)
    {
        if (assert == null)
            throw new ArgumentNullException(nameof(assert));

        _asserts.Add(assert);
        return this;
    }

    /// <summary>
    /// Gets the nested data sources for external access.
    /// </summary>
    public IReadOnlyList<TerraformDataSource> DataSources => _dataSources.AsReadOnly();

    /// <summary>
    /// Gets the nested assert blocks for external access.
    /// </summary>
    public IReadOnlyList<TerraformAssertBlock> Asserts => _asserts.AsReadOnly();

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        throw new NotSupportedException("Check blocks cannot be referenced in expressions.");
    }

    /// <summary>
    /// Resolves this check block to a top-level block node with nested data sources and assert blocks.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = new List<TerraformSyntaxNode>();

        // Add nested data sources first (they're fetched before assertions are evaluated)
        foreach (var dataSource in _dataSources)
        {
            var dataSourceNodes = dataSource.ResolveNodes(context).ToList();
            children.AddRange(dataSourceNodes);
        }

        // Add assert blocks
        foreach (var assert in _asserts)
        {
            var assertNodes = assert.ResolveNodes(context).ToList();
            children.AddRange(assertNodes);
        }

        // Format all children
        var formatted = context.Formatter.Format(children);

        // Wrap in a top-level block node
        yield return new TerraformBlockNode(BlockType, BlockLabels, formatted);
    }
}

/// <summary>
/// Represents an assert block within a check block.
/// Assert blocks define validation conditions that must evaluate to true.
/// When a condition evaluates to false, Terraform displays the error_message as a warning.
/// </summary>
public class TerraformAssertBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assert";

    /// <summary>
    /// Gets or sets the condition expression that must evaluate to true.
    /// The condition can reference nested data sources, variables, resources, data sources,
    /// or module outputs within the current module.
    /// </summary>
    public required TerraformExpression Condition
    {
        get => GetRequiredArgument<TerraformExpression>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Gets or sets the error message to display when the condition evaluates to false.
    /// Terraform displays this message as a warning but continues the operation.
    /// </summary>
    public required TerraformValue<string> ErrorMessage
    {
        get => GetRequiredArgument<TerraformValue<string>>("error_message");
        set => SetArgument("error_message", value);
    }

    /// <summary>
    /// Creates a new assert block.
    /// </summary>
    /// <param name="condition">The condition expression that must be true.</param>
    /// <param name="errorMessage">The error message to display on failure.</param>
    /// <exception cref="ArgumentException">Thrown when condition or errorMessage is null or empty.</exception>
    public TerraformAssertBlock(string condition, string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(condition))
            throw new ArgumentException("Assert condition cannot be null or empty.", nameof(condition));

        if (string.IsNullOrWhiteSpace(errorMessage))
            throw new ArgumentException("Assert error message cannot be null or empty.", nameof(errorMessage));

        Condition = TerraformExpression.Raw(condition);
        ErrorMessage = errorMessage;
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        throw new NotSupportedException("Assert blocks cannot be referenced in expressions.");
    }
}
