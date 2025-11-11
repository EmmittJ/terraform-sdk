using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for player_latency_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_individual_player_latency_milliseconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumIndividualPlayerLatencyMilliseconds is required")]
    [TerraformProperty("maximum_individual_player_latency_milliseconds")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumIndividualPlayerLatencyMilliseconds { get; set; }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    [TerraformProperty("policy_duration_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PolicyDurationSeconds { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_game_session_queue resource.
/// </summary>
public partial class AwsGameliftGameSessionQueue : TerraformResource
{
    public AwsGameliftGameSessionQueue(string name) : base("aws_gamelift_game_session_queue", name)
    {
    }

    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    [TerraformProperty("custom_event_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomEventData { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformProperty("destinations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Destinations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    [TerraformProperty("notification_target")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTarget { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// Block for player_latency_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("player_latency_policy")]
    public TerraformList<TerraformBlock<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>>? PlayerLatencyPolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
