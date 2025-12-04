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
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// The concurrency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Concurrency is required")]
    public required TerraformValue<double> Concurrency
    {
        get => GetArgument<TerraformValue<double>>("concurrency");
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
        get => GetArgument<TerraformValue<string>>("channel");
        set => SetArgument("channel", value);
    }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delay is required")]
    public required TerraformValue<double> Delay
    {
        get => GetArgument<TerraformValue<double>>("delay");
        set => SetArgument("delay", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The queue_arn attribute.
    /// </summary>
    public TerraformValue<string> QueueArn
        => AsReference("queue_arn");

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueId is required")]
    public required TerraformValue<string> QueueId
    {
        get => GetArgument<TerraformValue<string>>("queue_id");
        set => SetArgument("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformValue<string> QueueName
        => AsReference("queue_name");

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
        get => GetArgument<TerraformValue<string>>("default_outbound_queue_id");
        set => SetArgument("default_outbound_queue_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformValue<string> RoutingProfileId
        => AsReference("routing_profile_id");

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
