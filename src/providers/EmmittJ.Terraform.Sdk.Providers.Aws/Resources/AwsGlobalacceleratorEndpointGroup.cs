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
        get => GetProperty<TerraformProperty<string>>("attachment_arn");
        set => WithProperty("attachment_arn", value);
    }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientIpPreservationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_ip_preservation_enabled");
        set => WithProperty("client_ip_preservation_enabled", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_id");
        set => WithProperty("endpoint_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("endpoint_port");
        set => WithProperty("endpoint_port", value);
    }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    public required TerraformProperty<double> ListenerPort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("listener_port");
        set => WithProperty("listener_port", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointGroupRegion
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_group_region");
        set => this.WithProperty("endpoint_group_region", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("health_check_interval_seconds");
        set => this.WithProperty("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        get => GetProperty<TerraformProperty<string>>("health_check_path");
        set => this.WithProperty("health_check_path", value);
    }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    public TerraformProperty<double>? HealthCheckPort
    {
        get => GetProperty<TerraformProperty<double>>("health_check_port");
        set => this.WithProperty("health_check_port", value);
    }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckProtocol
    {
        get => GetProperty<TerraformProperty<string>>("health_check_protocol");
        set => this.WithProperty("health_check_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformProperty<string> ListenerArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("listener_arn");
        set => this.WithProperty("listener_arn", value);
    }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    public TerraformProperty<double>? ThresholdCount
    {
        get => GetProperty<TerraformProperty<double>>("threshold_count");
        set => this.WithProperty("threshold_count", value);
    }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? TrafficDialPercentage
    {
        get => GetProperty<TerraformProperty<double>>("traffic_dial_percentage");
        set => this.WithProperty("traffic_dial_percentage", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>>("endpoint_configuration");
        set => this.WithProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// Block for port_override.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    public HashSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>? PortOverride
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>>("port_override");
        set => this.WithProperty("port_override", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGlobalacceleratorEndpointGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
