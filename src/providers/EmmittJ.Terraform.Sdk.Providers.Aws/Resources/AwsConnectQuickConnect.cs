using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for quick_connect_config in AwsConnectQuickConnect.
/// Nesting mode: list
/// </summary>
public class AwsConnectQuickConnectQuickConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quick_connect_config";

    /// <summary>
    /// The quick_connect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuickConnectType is required")]
    public required TerraformValue<string> QuickConnectType
    {
        get => GetRequiredArgument<TerraformValue<string>>("quick_connect_type");
        set => SetArgument("quick_connect_type", value);
    }

    /// <summary>
    /// PhoneConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockPhoneConfigBlock>? PhoneConfig
    {
        get => GetArgument<TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockPhoneConfigBlock>>("phone_config");
        set => SetArgument("phone_config", value);
    }

    /// <summary>
    /// QueueConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockQueueConfigBlock>? QueueConfig
    {
        get => GetArgument<TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockQueueConfigBlock>>("queue_config");
        set => SetArgument("queue_config", value);
    }

    /// <summary>
    /// UserConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockUserConfigBlock>? UserConfig
    {
        get => GetArgument<TerraformList<AwsConnectQuickConnectQuickConnectConfigBlockUserConfigBlock>>("user_config");
        set => SetArgument("user_config", value);
    }

}

/// <summary>
/// Block type for phone_config in AwsConnectQuickConnectQuickConnectConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectQuickConnectQuickConnectConfigBlockPhoneConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phone_config";

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformValue<string> PhoneNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for queue_config in AwsConnectQuickConnectQuickConnectConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectQuickConnectQuickConnectConfigBlockQueueConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queue_config";

    /// <summary>
    /// The contact_flow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactFlowId is required")]
    public required TerraformValue<string> ContactFlowId
    {
        get => GetRequiredArgument<TerraformValue<string>>("contact_flow_id");
        set => SetArgument("contact_flow_id", value);
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformValue<string> QueueId
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_id");
        set => SetArgument("queue_id", value);
    }

}

/// <summary>
/// Block type for user_config in AwsConnectQuickConnectQuickConnectConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectQuickConnectQuickConnectConfigBlockUserConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_config";

    /// <summary>
    /// The contact_flow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactFlowId is required")]
    public required TerraformValue<string> ContactFlowId
    {
        get => GetRequiredArgument<TerraformValue<string>>("contact_flow_id");
        set => SetArgument("contact_flow_id", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_id");
        set => SetArgument("user_id", value);
    }

}


/// <summary>
/// Represents a aws_connect_quick_connect Terraform resource.
/// Manages a aws_connect_quick_connect resource.
/// </summary>
public partial class AwsConnectQuickConnect(string name) : TerraformResource("aws_connect_quick_connect", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    /// The quick_connect_id attribute.
    /// </summary>
    public TerraformValue<string> QuickConnectId
        => AsReference("quick_connect_id");

    /// <summary>
    /// QuickConnectConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuickConnectConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QuickConnectConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuickConnectConfig block(s) allowed")]
    public required TerraformList<AwsConnectQuickConnectQuickConnectConfigBlock> QuickConnectConfig
    {
        get => GetRequiredArgument<TerraformList<AwsConnectQuickConnectQuickConnectConfigBlock>>("quick_connect_config");
        set => SetArgument("quick_connect_config", value);
    }

}
