using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_pool_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_borrow_timeout attribute.
    /// </summary>
    [TerraformProperty("connection_borrow_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ConnectionBorrowTimeout { get; set; }

    /// <summary>
    /// The init_query attribute.
    /// </summary>
    [TerraformProperty("init_query")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InitQuery { get; set; }

    /// <summary>
    /// The max_connections_percent attribute.
    /// </summary>
    [TerraformProperty("max_connections_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConnectionsPercent { get; set; }

    /// <summary>
    /// The max_idle_connections_percent attribute.
    /// </summary>
    [TerraformProperty("max_idle_connections_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxIdleConnectionsPercent { get; set; }

    /// <summary>
    /// The session_pinning_filters attribute.
    /// </summary>
    [TerraformProperty("session_pinning_filters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SessionPinningFilters { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDbProxyDefaultTargetGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_db_proxy_default_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDbProxyDefaultTargetGroup : TerraformResource
{
    public AwsDbProxyDefaultTargetGroup(string name) : base("aws_db_proxy_default_target_group", name)
    {
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    [TerraformProperty("db_proxy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbProxyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for connection_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPoolConfig block(s) allowed")]
    [TerraformProperty("connection_pool_config")]
    public partial TerraformList<TerraformBlock<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>>? ConnectionPoolConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDbProxyDefaultTargetGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
