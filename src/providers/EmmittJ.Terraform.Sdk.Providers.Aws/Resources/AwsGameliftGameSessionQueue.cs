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
        get => GetRequiredArgument<TerraformValue<double>>("maximum_individual_player_latency_milliseconds");
        set => SetArgument("maximum_individual_player_latency_milliseconds", value);
    }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? PolicyDurationSeconds
    {
        get => GetArgument<TerraformValue<double>>("policy_duration_seconds");
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
        get => GetArgument<TerraformValue<string>>("custom_event_data");
        set => SetArgument("custom_event_data", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<string>? Destinations
    {
        get => GetArgument<TerraformList<string>>("destinations");
        set => SetArgument("destinations", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTarget
    {
        get => GetArgument<TerraformValue<string>>("notification_target");
        set => SetArgument("notification_target", value);
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
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_seconds");
        set => SetArgument("timeout_in_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// PlayerLatencyPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>? PlayerLatencyPolicy
    {
        get => GetArgument<TerraformList<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>>("player_latency_policy");
        set => SetArgument("player_latency_policy", value);
    }

}
