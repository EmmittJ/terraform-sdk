using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destinations in AwsMedialiveInput.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => new TerraformReference<string>(this, "stream_name");
        set => SetArgument("stream_name", value);
    }

}


/// <summary>
/// Block type for input_devices in AwsMedialiveInput.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputInputDevicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_devices";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for media_connect_flows in AwsMedialiveInput.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputMediaConnectFlowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_connect_flows";

    /// <summary>
    /// The flow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowArn is required")]
    public required TerraformValue<string> FlowArn
    {
        get => new TerraformReference<string>(this, "flow_arn");
        set => SetArgument("flow_arn", value);
    }

}


/// <summary>
/// Block type for sources in AwsMedialiveInput.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sources";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordParam is required")]
    public required TerraformValue<string> PasswordParam
    {
        get => new TerraformReference<string>(this, "password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMedialiveInput.
/// Nesting mode: single
/// </summary>
public class AwsMedialiveInputTimeoutsBlock : TerraformBlock
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
/// Block type for vpc in AwsMedialiveInput.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveInputVpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string>? SecurityGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_medialive_input Terraform resource.
/// Manages a aws_medialive_input resource.
/// </summary>
public partial class AwsMedialiveInput(string name) : TerraformResource("aws_medialive_input", name)
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
    /// The input_security_groups attribute.
    /// </summary>
    public TerraformList<string>? InputSecurityGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_security_groups").ResolveNodes(ctx));
        set => SetArgument("input_security_groups", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformList<string> AttachedChannels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "attached_channels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformValue<string> InputClass
    {
        get => new TerraformReference<string>(this, "input_class");
    }

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformList<string> InputPartnerIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_partner_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformValue<string> InputSourceType
    {
        get => new TerraformReference<string>(this, "input_source_type");
    }

    /// <summary>
    /// Destinations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveInputDestinationsBlock>? Destinations
    {
        get => GetArgument<TerraformSet<AwsMedialiveInputDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// InputDevices block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveInputInputDevicesBlock>? InputDevices
    {
        get => GetArgument<TerraformSet<AwsMedialiveInputInputDevicesBlock>>("input_devices");
        set => SetArgument("input_devices", value);
    }

    /// <summary>
    /// MediaConnectFlows block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveInputMediaConnectFlowsBlock>? MediaConnectFlows
    {
        get => GetArgument<TerraformSet<AwsMedialiveInputMediaConnectFlowsBlock>>("media_connect_flows");
        set => SetArgument("media_connect_flows", value);
    }

    /// <summary>
    /// Sources block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveInputSourcesBlock>? Sources
    {
        get => GetArgument<TerraformSet<AwsMedialiveInputSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMedialiveInputTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMedialiveInputTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Vpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public TerraformList<AwsMedialiveInputVpcBlock>? Vpc
    {
        get => GetArgument<TerraformList<AwsMedialiveInputVpcBlock>>("vpc");
        set => SetArgument("vpc", value);
    }

}
