using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_bus in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointEventBusBlock : ITerraformBlock
{
    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    [TerraformPropertyName("event_bus_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventBusArn { get; set; }

}

/// <summary>
/// Block type for replication_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointReplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Block type for routing_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventEndpoint : TerraformResource
{
    public AwsCloudwatchEventEndpoint(string name) : base("aws_cloudwatch_event_endpoint", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// Block for event_bus.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 EventBus block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 EventBus block(s) allowed")]
    [TerraformPropertyName("event_bus")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointEventBusBlock>>? EventBus { get; set; } = new();

    /// <summary>
    /// Block for replication_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfig block(s) allowed")]
    [TerraformPropertyName("replication_config")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointReplicationConfigBlock>>? ReplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    [TerraformPropertyName("routing_config")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventEndpointRoutingConfigBlock>>? RoutingConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_url");

}
