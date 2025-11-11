using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_bus in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventEndpointEventBusBlock : TerraformBlockBase
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    [TerraformProperty("event_bus_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventBusArn { get; set; }

}

/// <summary>
/// Block type for replication_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventEndpointReplicationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? State { get; set; }

}

/// <summary>
/// Block type for routing_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventEndpointRoutingConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchEventEndpoint : TerraformResource
{
    public AwsCloudwatchEventEndpoint(string name) : base("aws_cloudwatch_event_endpoint", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// Block for event_bus.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 EventBus block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 EventBus block(s) allowed")]
    [TerraformProperty("event_bus")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointEventBusBlock>>? EventBus { get; set; }

    /// <summary>
    /// Block for replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfig block(s) allowed")]
    [TerraformProperty("replication_config")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointReplicationConfigBlock>>? ReplicationConfig { get; set; }

    /// <summary>
    /// Block for routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    [TerraformProperty("routing_config")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointRoutingConfigBlock>>? RoutingConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    [TerraformProperty("endpoint_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointUrl { get; }

}
