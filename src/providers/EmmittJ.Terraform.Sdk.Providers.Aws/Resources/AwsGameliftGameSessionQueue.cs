using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for player_latency_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_individual_player_latency_milliseconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumIndividualPlayerLatencyMilliseconds is required")]
    [TerraformPropertyName("maximum_individual_player_latency_milliseconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaximumIndividualPlayerLatencyMilliseconds { get; set; }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    [TerraformPropertyName("policy_duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PolicyDurationSeconds { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_game_session_queue resource.
/// </summary>
public class AwsGameliftGameSessionQueue : TerraformResource
{
    public AwsGameliftGameSessionQueue(string name) : base("aws_gamelift_game_session_queue", name)
    {
    }

    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_event_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomEventData { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Destinations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    [TerraformPropertyName("notification_target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationTarget { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// Block for player_latency_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("player_latency_policy")]
    public TerraformList<TerraformBlock<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>>? PlayerLatencyPolicy { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
