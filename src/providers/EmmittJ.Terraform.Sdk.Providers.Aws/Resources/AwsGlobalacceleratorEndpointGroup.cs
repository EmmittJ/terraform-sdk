using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in AwsGlobalacceleratorEndpointGroup.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_configuration";

    /// <summary>
    /// The attachment_arn attribute.
    /// </summary>
    public TerraformValue<string>? AttachmentArn
    {
        get => GetArgument<TerraformValue<string>>("attachment_arn");
        set => SetArgument("attachment_arn", value);
    }

    /// <summary>
    /// The client_ip_preservation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientIpPreservationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_ip_preservation_enabled") ?? AsReference("client_ip_preservation_enabled");
        set => SetArgument("client_ip_preservation_enabled", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? EndpointId
    {
        get => GetArgument<TerraformValue<string>>("endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for port_override in AwsGlobalacceleratorEndpointGroup.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorEndpointGroupPortOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_override";

    /// <summary>
    /// The endpoint_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointPort is required")]
    public required TerraformValue<double> EndpointPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("endpoint_port");
        set => SetArgument("endpoint_port", value);
    }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerPort is required")]
    public required TerraformValue<double> ListenerPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("listener_port");
        set => SetArgument("listener_port", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlobalacceleratorEndpointGroup.
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorEndpointGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_globalaccelerator_endpoint_group Terraform resource.
/// Manages a aws_globalaccelerator_endpoint_group resource.
/// </summary>
public partial class AwsGlobalacceleratorEndpointGroup(string name) : TerraformResource("aws_globalaccelerator_endpoint_group", name)
{
    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public TerraformValue<string> EndpointGroupRegion
    {
        get => GetArgument<TerraformValue<string>>("endpoint_group_region") ?? AsReference("endpoint_group_region");
        set => SetArgument("endpoint_group_region", value);
    }

    /// <summary>
    /// The health_check_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? HealthCheckIntervalSeconds
    {
        get => GetArgument<TerraformValue<double>>("health_check_interval_seconds");
        set => SetArgument("health_check_interval_seconds", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformValue<string> HealthCheckPath
    {
        get => GetArgument<TerraformValue<string>>("health_check_path") ?? AsReference("health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The health_check_port attribute.
    /// </summary>
    public TerraformValue<double> HealthCheckPort
    {
        get => GetArgument<TerraformValue<double>>("health_check_port") ?? AsReference("health_check_port");
        set => SetArgument("health_check_port", value);
    }

    /// <summary>
    /// The health_check_protocol attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckProtocol
    {
        get => GetArgument<TerraformValue<string>>("health_check_protocol");
        set => SetArgument("health_check_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformValue<string> ListenerArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("listener_arn");
        set => SetArgument("listener_arn", value);
    }

    /// <summary>
    /// The threshold_count attribute.
    /// </summary>
    public TerraformValue<double>? ThresholdCount
    {
        get => GetArgument<TerraformValue<double>>("threshold_count");
        set => SetArgument("threshold_count", value);
    }

    /// <summary>
    /// The traffic_dial_percentage attribute.
    /// </summary>
    public TerraformValue<double>? TrafficDialPercentage
    {
        get => GetArgument<TerraformValue<double>>("traffic_dial_percentage");
        set => SetArgument("traffic_dial_percentage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// EndpointConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetArgument<TerraformSet<AwsGlobalacceleratorEndpointGroupEndpointConfigurationBlock>>("endpoint_configuration");
        set => SetArgument("endpoint_configuration", value);
    }

    /// <summary>
    /// PortOverride block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortOverride block(s) allowed")]
    public TerraformSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>? PortOverride
    {
        get => GetArgument<TerraformSet<AwsGlobalacceleratorEndpointGroupPortOverrideBlock>>("port_override");
        set => SetArgument("port_override", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlobalacceleratorEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlobalacceleratorEndpointGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
