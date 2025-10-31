namespace EmmittJ.Terraform.Sdk.Constructs;

/// <summary>
/// Represents a Terraform check block for continuous validation (Terraform 1.5+).
/// Check blocks allow you to define assertions that Terraform will continuously validate.
/// They can contain data sources for fetching external data and assert blocks for validation.
/// </summary>
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
public class TerraformCheckBlock : TerraformConstruct
{
    private readonly List<TerraformDataSource> _dataSources = new();
    private readonly List<TerraformAssertBlock> _asserts = new();

    /// <summary>
    /// Gets the name of the check block.
    /// </summary>
    public string Name { get; }

    /// <inheritdoc/>
    protected override string BlockType => "check";

    /// <inheritdoc/>
    protected override string[] Labels => [Name];

    /// <summary>
    /// Creates a new Terraform check block.
    /// </summary>
    /// <param name="name">The name of the check block.</param>
    /// <exception cref="ArgumentException">Thrown when name is null or empty.</exception>
    public TerraformCheckBlock(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Check block name cannot be null or empty.", nameof(name));

        Name = name;
    }

    /// <summary>
    /// Adds a data source to the check block.
    /// Data sources in check blocks can be used to fetch external data for validation.
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
    /// Assert blocks define validation conditions that must be true.
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

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Write data sources first
        foreach (var dataSource in _dataSources)
        {
            sb.Append(dataSource.Resolve(context));
            sb.AppendLine();
        }

        // Write assert blocks
        foreach (var assert in _asserts)
        {
            sb.Append(assert.Resolve(context));
            sb.AppendLine();
        }
    }

    /// <inheritdoc/>
    public override void Prepare(ITerraformContext context)
    {
        base.Prepare(context);

        // Prepare nested data sources
        foreach (var dataSource in _dataSources)
        {
            dataSource.Prepare(context);
        }

        // Prepare assert blocks
        foreach (var assert in _asserts)
        {
            assert.Prepare(context);
        }
    }

    /// <inheritdoc/>
    public override TerraformReferenceExpression AsReference()
    {
        throw new NotSupportedException("Check blocks cannot be referenced in expressions.");
    }
}

/// <summary>
/// Represents an assert block within a check block.
/// Assert blocks define validation conditions with custom error messages.
/// </summary>
public class TerraformAssertBlock : TerraformConstruct
{
    /// <summary>
    /// Gets or sets the condition expression that must evaluate to true.
    /// </summary>
    public TerraformProperty? Condition
    {
        get => GetProperty<TerraformProperty>("condition");
        set => WithPropertyInternal("condition", value, priority: 0);
    }

    /// <summary>
    /// Gets or sets the error message to display when the condition is false.
    /// </summary>
    public TerraformLiteralProperty<string>? ErrorMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("error_message");
        set => WithPropertyInternal("error_message", value, priority: 1);
    }

    /// <inheritdoc/>
    protected override string BlockType => "assert";

    /// <inheritdoc/>
    protected override string[] Labels => [];

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
    public override TerraformReferenceExpression AsReference()
    {
        throw new NotSupportedException("Assert blocks cannot be referenced in expressions.");
    }
}
