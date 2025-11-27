using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_range in AwsGlobalacceleratorListener.
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorListenerPortRangeBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGlobalacceleratorListener.
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorListenerTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_globalaccelerator_listener Terraform resource.
/// Manages a aws_globalaccelerator_listener resource.
/// </summary>
public partial class AwsGlobalacceleratorListener(string name) : TerraformResource("aws_globalaccelerator_listener", name)
{
    /// <summary>
    /// The accelerator_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorArn is required")]
    public required TerraformValue<string> AcceleratorArn
    {
        get => new TerraformReference<string>(this, "accelerator_arn");
        set => SetArgument("accelerator_arn", value);
    }

    /// <summary>
    /// The client_affinity attribute.
    /// </summary>
    public TerraformValue<string>? ClientAffinity
    {
        get => new TerraformReference<string>(this, "client_affinity");
        set => SetArgument("client_affinity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortRange is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortRange block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortRange block(s) allowed")]
    public required TerraformSet<AwsGlobalacceleratorListenerPortRangeBlock> PortRange
    {
        get => GetRequiredArgument<TerraformSet<AwsGlobalacceleratorListenerPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGlobalacceleratorListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGlobalacceleratorListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
