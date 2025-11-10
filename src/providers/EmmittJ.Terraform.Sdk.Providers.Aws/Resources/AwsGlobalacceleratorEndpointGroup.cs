using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("attachment_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AttachmentArn { get; set; }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_ip_preservation_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ClientIpPreservationEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "client_ip_preservation_enabled");

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointId { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Block type for port_override in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupPortOverrideBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointPort is required")]
    [TerraformPropertyName("endpoint_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> EndpointPort { get; set; }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    [TerraformPropertyName("listener_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ListenerPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorEndpointGroupTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorEndpointGroup(string name) : base("aws_globalaccelerator_endpoint_group", name)
    {
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_group_region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndpointGroupRegion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_group_region");

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    [TerraformPropertyName("health_check_interval_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthCheckIntervalSeconds { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HealthCheckPath { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "health_check_path");

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    [TerraformPropertyName("health_check_port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> HealthCheckPort { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "health_check_port");

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    [TerraformPropertyName("health_check_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckProtocol { get; set; }

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
    /// The threshold_count attribute.
    /// </summary>
    [TerraformPropertyName("threshold_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThresholdCount { get; set; }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    [TerraformPropertyName("traffic_dial_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TrafficDialPercentage { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>>? EndpointConfiguration { get; set; } = new();

    /// <summary>
    /// Block for port_override.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    [TerraformPropertyName("port_override")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>>? PortOverride { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGlobalacceleratorEndpointGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
