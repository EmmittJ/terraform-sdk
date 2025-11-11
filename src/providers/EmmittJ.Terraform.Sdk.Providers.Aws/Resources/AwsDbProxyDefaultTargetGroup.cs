using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_pool_config in .
/// Nesting mode: list
/// </summary>
public class AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock
{
    /// <summary>
    /// The connection_borrow_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_borrow_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConnectionBorrowTimeout { get; set; }

    /// <summary>
    /// The init_query attribute.
    /// </summary>
    [TerraformPropertyName("init_query")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InitQuery { get; set; }

    /// <summary>
    /// The max_connections_percent attribute.
    /// </summary>
    [TerraformPropertyName("max_connections_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConnectionsPercent { get; set; }

    /// <summary>
    /// The max_idle_connections_percent attribute.
    /// </summary>
    [TerraformPropertyName("max_idle_connections_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxIdleConnectionsPercent { get; set; }

    /// <summary>
    /// The session_pinning_filters attribute.
    /// </summary>
    [TerraformPropertyName("session_pinning_filters")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SessionPinningFilters { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbProxyDefaultTargetGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_db_proxy_default_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDbProxyDefaultTargetGroup : TerraformResource
{
    public AwsDbProxyDefaultTargetGroup(string name) : base("aws_db_proxy_default_target_group", name)
    {
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    [TerraformPropertyName("db_proxy_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DbProxyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for connection_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPoolConfig block(s) allowed")]
    [TerraformPropertyName("connection_pool_config")]
    public TerraformList<TerraformBlock<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>>? ConnectionPoolConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDbProxyDefaultTargetGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
