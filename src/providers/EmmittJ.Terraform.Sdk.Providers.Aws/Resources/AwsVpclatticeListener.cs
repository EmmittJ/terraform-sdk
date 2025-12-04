using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in AwsVpclatticeListener.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_action";

    /// <summary>
    /// FixedResponse block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedResponse block(s) allowed")]
    public TerraformList<AwsVpclatticeListenerDefaultActionBlockFixedResponseBlock>? FixedResponse
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerDefaultActionBlockFixedResponseBlock>>("fixed_response");
        set => SetArgument("fixed_response", value);
    }

    /// <summary>
    /// Forward block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeListenerDefaultActionBlockForwardBlock>? Forward
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerDefaultActionBlockForwardBlock>>("forward");
        set => SetArgument("forward", value);
    }

}

/// <summary>
/// Block type for fixed_response in AwsVpclatticeListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerDefaultActionBlockFixedResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_response";

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<double> StatusCode
    {
        get => GetRequiredArgument<TerraformValue<double>>("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for forward in AwsVpclatticeListenerDefaultActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerDefaultActionBlockForwardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward";

    /// <summary>
    /// TargetGroups block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVpclatticeListenerDefaultActionBlockForwardBlockTargetGroupsBlock>? TargetGroups
    {
        get => GetArgument<TerraformList<AwsVpclatticeListenerDefaultActionBlockForwardBlockTargetGroupsBlock>>("target_groups");
        set => SetArgument("target_groups", value);
    }

}

/// <summary>
/// Block type for target_groups in AwsVpclatticeListenerDefaultActionBlockForwardBlock.
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeListenerDefaultActionBlockForwardBlockTargetGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_groups";

    /// <summary>
    /// The target_group_identifier attribute.
    /// </summary>
    public TerraformValue<string>? TargetGroupIdentifier
    {
        get => GetArgument<TerraformValue<string>>("target_group_identifier");
        set => SetArgument("target_group_identifier", value);
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
/// Block type for timeouts in AwsVpclatticeListener.
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeListenerTimeoutsBlock : TerraformBlock
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
/// Represents a aws_vpclattice_listener Terraform resource.
/// Manages a aws_vpclattice_listener resource.
/// </summary>
public partial class AwsVpclatticeListener(string name) : TerraformResource("aws_vpclattice_listener", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceArn
    {
        get => GetArgument<TerraformValue<string>>("service_arn") ?? AsReference("service_arn");
        set => SetArgument("service_arn", value);
    }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    public TerraformValue<string> ServiceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("service_identifier") ?? AsReference("service_identifier");
        set => SetArgument("service_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedAt
        => AsReference("last_updated_at");

    /// <summary>
    /// The listener_id attribute.
    /// </summary>
    public TerraformValue<string> ListenerId
        => AsReference("listener_id");

    /// <summary>
    /// DefaultAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    public required TerraformList<AwsVpclatticeListenerDefaultActionBlock> DefaultAction
    {
        get => GetRequiredArgument<TerraformList<AwsVpclatticeListenerDefaultActionBlock>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpclatticeListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpclatticeListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
