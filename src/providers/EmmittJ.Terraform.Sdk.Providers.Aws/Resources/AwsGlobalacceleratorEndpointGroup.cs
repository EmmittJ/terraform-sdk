using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The attachment_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AttachmentArn
    {
        set => SetProperty("attachment_arn", value);
    }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientIpPreservationEnabled
    {
        set => SetProperty("client_ip_preservation_enabled", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointId
    {
        set => SetProperty("endpoint_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        set => SetProperty("weight", value);
    }

}

/// <summary>
/// Block type for port_override in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupPortOverrideBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointPort is required")]
    public required TerraformProperty<double> EndpointPort
    {
        set => SetProperty("endpoint_port", value);
    }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    public required TerraformProperty<double> ListenerPort
    {
        set => SetProperty("listener_port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorEndpointGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorEndpointGroup(string name) : base("aws_globalaccelerator_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint_group_region");
        SetOutput("health_check_interval_seconds");
        SetOutput("health_check_path");
        SetOutput("health_check_port");
        SetOutput("health_check_protocol");
        SetOutput("id");
        SetOutput("listener_arn");
        SetOutput("threshold_count");
        SetOutput("traffic_dial_percentage");
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public TerraformProperty<string> EndpointGroupRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_group_region");
        set => SetProperty("endpoint_group_region", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double> HealthCheckIntervalSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("health_check_interval_seconds");
        set => SetProperty("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string> HealthCheckPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_check_path");
        set => SetProperty("health_check_path", value);
    }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    public TerraformProperty<double> HealthCheckPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("health_check_port");
        set => SetProperty("health_check_port", value);
    }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    public TerraformProperty<string> HealthCheckProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_check_protocol");
        set => SetProperty("health_check_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformProperty<string> ListenerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("listener_arn");
        set => SetProperty("listener_arn", value);
    }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    public TerraformProperty<double> ThresholdCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("threshold_count");
        set => SetProperty("threshold_count", value);
    }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    public TerraformProperty<double> TrafficDialPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("traffic_dial_percentage");
        set => SetProperty("traffic_dial_percentage", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        set => SetProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// Block for port_override.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    public HashSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>? PortOverride
    {
        set => SetProperty("port_override", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorEndpointGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
