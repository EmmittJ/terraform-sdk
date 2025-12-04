using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_range in AwsGlobalacceleratorCustomRoutingListener.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingListenerPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => GetArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlobalacceleratorCustomRoutingListener.
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingListenerTimeoutsBlock : TerraformBlock
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
/// Represents a aws_globalaccelerator_custom_routing_listener Terraform resource.
/// Manages a aws_globalaccelerator_custom_routing_listener resource.
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingListener(string name) : TerraformResource("aws_globalaccelerator_custom_routing_listener", name)
{
    /// <summary>
    /// The accelerator_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorArn is required")]
    public required TerraformValue<string> AcceleratorArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("accelerator_arn");
        set => SetArgument("accelerator_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortRange is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortRange block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortRange block(s) allowed")]
    public required TerraformSet<AwsGlobalacceleratorCustomRoutingListenerPortRangeBlock> PortRange
    {
        get => GetRequiredArgument<TerraformSet<AwsGlobalacceleratorCustomRoutingListenerPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlobalacceleratorCustomRoutingListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
