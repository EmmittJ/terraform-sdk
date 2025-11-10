using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    [TerraformPropertyName("from_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> FromPort { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    [TerraformPropertyName("protocols")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Protocols { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    [TerraformPropertyName("to_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ToPort { get; set; }

}

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorCustomRoutingEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingEndpointGroup(string name) : base("aws_globalaccelerator_custom_routing_endpoint_group", name)
    {
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_group_region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndpointGroupRegion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_group_region");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    [TerraformPropertyName("listener_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ListenerArn { get; set; }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    [TerraformPropertyName("destination_configuration")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>>? DestinationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>>? EndpointConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
