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
        get => new TerraformReference<double>(this, "status_code");
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
        get => new TerraformReference<string>(this, "target_group_identifier");
        set => SetArgument("target_group_identifier", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceArn
    {
        get => new TerraformReference<string>(this, "service_arn");
        set => SetArgument("service_arn", value);
    }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    public TerraformValue<string> ServiceIdentifier
    {
        get => new TerraformReference<string>(this, "service_identifier");
        set => SetArgument("service_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedAt
    {
        get => new TerraformReference<string>(this, "last_updated_at");
    }

    /// <summary>
    /// The listener_id attribute.
    /// </summary>
    public TerraformValue<string> ListenerId
    {
        get => new TerraformReference<string>(this, "listener_id");
    }

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
