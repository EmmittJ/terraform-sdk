using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for outbound_caller_config in AwsConnectQueue.
/// Nesting mode: list
/// </summary>
public class AwsConnectQueueOutboundCallerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outbound_caller_config";

    /// <summary>
    /// The outbound_caller_id_name attribute.
    /// </summary>
    public TerraformValue<string>? OutboundCallerIdName
    {
        get => GetArgument<TerraformValue<string>>("outbound_caller_id_name");
        set => SetArgument("outbound_caller_id_name", value);
    }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundCallerIdNumberId
    {
        get => GetArgument<TerraformValue<string>>("outbound_caller_id_number_id");
        set => SetArgument("outbound_caller_id_number_id", value);
    }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundFlowId
    {
        get => GetArgument<TerraformValue<string>>("outbound_flow_id");
        set => SetArgument("outbound_flow_id", value);
    }

}


/// <summary>
/// Represents a aws_connect_queue Terraform resource.
/// Manages a aws_connect_queue resource.
/// </summary>
public partial class AwsConnectQueue(string name) : TerraformResource("aws_connect_queue", name)
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
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    public required TerraformValue<string> HoursOfOperationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("hours_of_operation_id");
        set => SetArgument("hours_of_operation_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The max_contacts attribute.
    /// </summary>
    public TerraformValue<double>? MaxContacts
    {
        get => GetArgument<TerraformValue<double>>("max_contacts");
        set => SetArgument("max_contacts", value);
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
    /// The quick_connect_ids attribute.
    /// </summary>
    public TerraformSet<string>? QuickConnectIds
    {
        get => GetArgument<TerraformSet<string>>("quick_connect_ids");
        set => SetArgument("quick_connect_ids", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? CreateReference("status");
        set => SetArgument("status", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    public TerraformValue<string> QueueId
        => CreateReference("queue_id");

    /// <summary>
    /// OutboundCallerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    public TerraformList<AwsConnectQueueOutboundCallerConfigBlock>? OutboundCallerConfig
    {
        get => GetArgument<TerraformList<AwsConnectQueueOutboundCallerConfigBlock>>("outbound_caller_config");
        set => SetArgument("outbound_caller_config", value);
    }

}
