using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for player_latency_policy in AwsGameliftGameSessionQueue.
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "player_latency_policy";

    /// <summary>
    /// The maximum_individual_player_latency_milliseconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumIndividualPlayerLatencyMilliseconds is required")]
    public required TerraformValue<double> MaximumIndividualPlayerLatencyMilliseconds
    {
        get => new TerraformReference<double>(this, "maximum_individual_player_latency_milliseconds");
        set => SetArgument("maximum_individual_player_latency_milliseconds", value);
    }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PolicyDurationSeconds
    {
        get => new TerraformReference<double>(this, "policy_duration_seconds");
        set => SetArgument("policy_duration_seconds", value);
    }

}


/// <summary>
/// Represents a aws_gamelift_game_session_queue Terraform resource.
/// Manages a aws_gamelift_game_session_queue resource.
/// </summary>
public partial class AwsGameliftGameSessionQueue(string name) : TerraformResource("aws_gamelift_game_session_queue", name)
{
    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    public TerraformValue<string>? CustomEventData
    {
        get => new TerraformReference<string>(this, "custom_event_data");
        set => SetArgument("custom_event_data", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<string>? Destinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destinations").ResolveNodes(ctx));
        set => SetArgument("destinations", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTarget
    {
        get => new TerraformReference<string>(this, "notification_target");
        set => SetArgument("notification_target", value);
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
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// PlayerLatencyPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>? PlayerLatencyPolicy
    {
        get => GetArgument<TerraformList<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>>("player_latency_policy");
        set => SetArgument("player_latency_policy", value);
    }

}
