using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in AwsGlobalacceleratorCustomRoutingEndpointGroup.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_configuration";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public required TerraformSet<string> Protocols
    {
        get => GetRequiredArgument<TerraformSet<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for endpoint_configuration in AwsGlobalacceleratorCustomRoutingEndpointGroup.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_configuration";

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? EndpointId
    {
        get => GetArgument<TerraformValue<string>>("endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlobalacceleratorCustomRoutingEndpointGroup.
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_globalaccelerator_custom_routing_endpoint_group Terraform resource.
/// Manages a aws_globalaccelerator_custom_routing_endpoint_group resource.
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingEndpointGroup(string name) : TerraformResource("aws_globalaccelerator_custom_routing_endpoint_group", name)
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DestinationConfiguration block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    public required TerraformSet<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock> DestinationConfiguration
    {
        get => GetRequiredArgument<TerraformSet<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>>("destination_configuration");
        set => SetArgument("destination_configuration", value);
    }

    /// <summary>
    /// EndpointConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetArgument<TerraformSet<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>>("endpoint_configuration");
        set => SetArgument("endpoint_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
