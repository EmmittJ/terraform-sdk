using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock
{
    /// <summary>
    /// The attachment_arn attribute.
    /// </summary>
    [TerraformPropertyName("attachment_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AttachmentArn { get; set; }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_ip_preservation_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ClientIpPreservationEnabled { get; set; } = default!;

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EndpointId { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for port_override in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupPortOverrideBlock
{
    /// <summary>
    /// The endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointPort is required")]
    [TerraformPropertyName("endpoint_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> EndpointPort { get; set; }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    [TerraformPropertyName("listener_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ListenerPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorEndpointGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndpointGroupRegion { get; set; } = default!;

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    [TerraformPropertyName("health_check_interval_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthCheckIntervalSeconds { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HealthCheckPath { get; set; } = default!;

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    [TerraformPropertyName("health_check_port")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> HealthCheckPort { get; set; } = default!;

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    [TerraformPropertyName("health_check_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HealthCheckProtocol { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    [TerraformPropertyName("listener_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ListenerArn { get; set; }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    [TerraformPropertyName("threshold_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThresholdCount { get; set; }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    [TerraformPropertyName("traffic_dial_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TrafficDialPercentage { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>>? EndpointConfiguration { get; set; }

    /// <summary>
    /// Block for port_override.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    [TerraformPropertyName("port_override")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>>? PortOverride { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGlobalacceleratorEndpointGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
