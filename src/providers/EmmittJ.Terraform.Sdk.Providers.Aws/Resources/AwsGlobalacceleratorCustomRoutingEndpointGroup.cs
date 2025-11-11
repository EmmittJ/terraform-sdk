using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformProperty("from_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> FromPort { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    [TerraformProperty("protocols")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Protocols { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformProperty("to_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ToPort { get; set; }

}

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlobalacceleratorCustomRoutingEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingEndpointGroup(string name) : base("aws_globalaccelerator_custom_routing_endpoint_group", name)
    {
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    [TerraformProperty("endpoint_group_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointGroupRegion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    [TerraformProperty("listener_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ListenerArn { get; set; }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    [TerraformProperty("destination_configuration")]
    public partial TerraformSet<TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>>? DestinationConfiguration { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("endpoint_configuration")]
    public partial TerraformSet<TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>>? EndpointConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
