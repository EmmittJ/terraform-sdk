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
        get => new TerraformReference<string>(this, "outbound_caller_id_name");
        set => SetArgument("outbound_caller_id_name", value);
    }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundCallerIdNumberId
    {
        get => new TerraformReference<string>(this, "outbound_caller_id_number_id");
        set => SetArgument("outbound_caller_id_number_id", value);
    }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundFlowId
    {
        get => new TerraformReference<string>(this, "outbound_flow_id");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    public required TerraformValue<string> HoursOfOperationId
    {
        get => new TerraformReference<string>(this, "hours_of_operation_id");
        set => SetArgument("hours_of_operation_id", value);
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    public TerraformValue<double>? MaxContacts
    {
        get => new TerraformReference<double>(this, "max_contacts");
        set => SetArgument("max_contacts", value);
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
    /// The quick_connect_ids attribute.
    /// </summary>
    public TerraformSet<string>? QuickConnectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "quick_connect_ids").ResolveNodes(ctx));
        set => SetArgument("quick_connect_ids", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
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
    /// The queue_id attribute.
    /// </summary>
    public TerraformValue<string> QueueId
    {
        get => new TerraformReference<string>(this, "queue_id");
    }

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
