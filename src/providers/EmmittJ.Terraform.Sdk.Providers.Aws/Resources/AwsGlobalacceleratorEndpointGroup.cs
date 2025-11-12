using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock() : TerraformBlock("endpoint_configuration")
{
    /// <summary>
    /// The attachment_arn attribute.
    /// </summary>
    [TerraformProperty("attachment_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AttachmentArn { get; set; }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    [TerraformProperty("client_ip_preservation_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ClientIpPreservationEnabled { get; set; }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointId { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for port_override in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorEndpointGroupPortOverrideBlock() : TerraformBlock("port_override")
{
    /// <summary>
    /// The endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointPort is required")]
    [TerraformProperty("endpoint_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> EndpointPort { get; set; }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    [TerraformProperty("listener_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ListenerPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGlobalacceleratorEndpointGroupTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_globalaccelerator_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlobalacceleratorEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorEndpointGroup(string name) : base("aws_globalaccelerator_endpoint_group", name)
    {
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    [TerraformProperty("endpoint_group_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointGroupRegion { get; set; }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    [TerraformProperty("health_check_interval_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HealthCheckIntervalSeconds { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HealthCheckPath { get; set; }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    [TerraformProperty("health_check_port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> HealthCheckPort { get; set; }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    [TerraformProperty("health_check_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckProtocol { get; set; }

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
    /// The threshold_count attribute.
    /// </summary>
    [TerraformProperty("threshold_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ThresholdCount { get; set; }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    [TerraformProperty("traffic_dial_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TrafficDialPercentage { get; set; }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("endpoint_configuration")]
    public TerraformSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock> EndpointConfiguration { get; set; } = new();

    /// <summary>
    /// Block for port_override.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    [TerraformProperty("port_override")]
    public TerraformSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock> PortOverride { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsGlobalacceleratorEndpointGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
