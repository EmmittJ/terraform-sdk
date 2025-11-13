namespace EmmittJ.Terraform.Sdk;

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
public class TerraformCheckBlock : TerraformBlock
{
    private readonly List<TerraformDataSource> _dataSources = new();
    private readonly List<TerraformAssertBlock> _asserts = new();

    /// <summary>
    /// Gets the name of the check block.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Creates a new Terraform check block.
    /// </summary>
    /// <param name="name">The name of the check block.</param>
    /// <exception cref="ArgumentException">Thrown when name is null or empty.</exception>
    public TerraformCheckBlock(string name) : base("")
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
}

/// <summary>
/// Represents an assert block within a check block.
/// Assert blocks define validation conditions with custom error messages.
/// </summary>
public class TerraformAssertBlock : TerraformBlock
{
    /// <summary>
    /// Gets or sets the condition expression that must evaluate to true.
    /// </summary>
    [TerraformArgument("condition")]
    public TerraformValue<TerraformExpression>? Condition { get; set; }

    /// <summary>
    /// Gets or sets the error message to display when the condition is false.
    /// </summary>
    [TerraformArgument("error_message")]
    public TerraformValue<string>? ErrorMessage { get; set; }

    /// <summary>
    /// Creates a new assert block.
    /// </summary>
    /// <param name="condition">The condition expression that must be true.</param>
    /// <param name="errorMessage">The error message to display on failure.</param>
    /// <exception cref="ArgumentException">Thrown when condition or errorMessage is null or empty.</exception>
    public TerraformAssertBlock(string condition, string errorMessage) : base("")
    {
        if (string.IsNullOrWhiteSpace(condition))
            throw new ArgumentException("Assert condition cannot be null or empty.", nameof(condition));

        if (string.IsNullOrWhiteSpace(errorMessage))
            throw new ArgumentException("Assert error message cannot be null or empty.", nameof(errorMessage));

        Condition = TerraformValue.FromExpression<TerraformExpression>(TerraformExpression.Raw(condition));
        ErrorMessage = errorMessage;
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        throw new NotSupportedException("Assert blocks cannot be referenced in expressions.");
    }
}
