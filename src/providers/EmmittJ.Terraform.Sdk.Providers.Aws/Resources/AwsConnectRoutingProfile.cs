using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for media_concurrencies in AwsConnectRoutingProfile.
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileMediaConcurrenciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_concurrencies";

    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformValue<string> Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    public required TerraformValue<double> Concurrency
    {
        get => new TerraformReference<double>(this, "concurrency");
        set => SetArgument("concurrency", value);
    }

}


/// <summary>
/// Block type for queue_configs in AwsConnectRoutingProfile.
/// Nesting mode: set
/// </summary>
public class AwsConnectRoutingProfileQueueConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "queue_configs";

    /// <summary>
    /// The channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channel is required")]
    public required TerraformValue<string> Channel
    {
        get => new TerraformReference<string>(this, "channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    public required TerraformValue<double> Delay
    {
        get => new TerraformReference<double>(this, "delay");
        set => SetArgument("delay", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    public TerraformValue<string> QueueArn
    {
        get => new TerraformReference<string>(this, "queue_arn");
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformValue<string> QueueId
    {
        get => new TerraformReference<string>(this, "queue_id");
        set => SetArgument("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformValue<string> QueueName
    {
        get => new TerraformReference<string>(this, "queue_name");
    }

}


/// <summary>
/// Represents a aws_connect_routing_profile Terraform resource.
/// Manages a aws_connect_routing_profile resource.
/// </summary>
public partial class AwsConnectRoutingProfile(string name) : TerraformResource("aws_connect_routing_profile", name)
{
    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultOutboundQueueId is required")]
    public required TerraformValue<string> DefaultOutboundQueueId
    {
        get => new TerraformReference<string>(this, "default_outbound_queue_id");
        set => SetArgument("default_outbound_queue_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformValue<string> RoutingProfileId
    {
        get => new TerraformReference<string>(this, "routing_profile_id");
    }

    /// <summary>
    /// MediaConcurrencies block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MediaConcurrencies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MediaConcurrencies block(s) required")]
    public required TerraformSet<AwsConnectRoutingProfileMediaConcurrenciesBlock> MediaConcurrencies
    {
        get => GetRequiredArgument<TerraformSet<AwsConnectRoutingProfileMediaConcurrenciesBlock>>("media_concurrencies");
        set => SetArgument("media_concurrencies", value);
    }

    /// <summary>
    /// QueueConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsConnectRoutingProfileQueueConfigsBlock>? QueueConfigs
    {
        get => GetArgument<TerraformSet<AwsConnectRoutingProfileQueueConfigsBlock>>("queue_configs");
        set => SetArgument("queue_configs", value);
    }

}
