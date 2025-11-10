using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for player_latency_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_individual_player_latency_milliseconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumIndividualPlayerLatencyMilliseconds is required")]
    public required TerraformProperty<double> MaximumIndividualPlayerLatencyMilliseconds
    {
        get => GetRequiredProperty<TerraformProperty<double>>("maximum_individual_player_latency_milliseconds");
        set => WithProperty("maximum_individual_player_latency_milliseconds", value);
    }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? PolicyDurationSeconds
    {
        get => GetProperty<TerraformProperty<double>>("policy_duration_seconds");
        set => WithProperty("policy_duration_seconds", value);
    }

}

/// <summary>
/// Manages a aws_gamelift_game_session_queue resource.
/// </summary>
public class AwsGameliftGameSessionQueue : TerraformResource
{
    public AwsGameliftGameSessionQueue(string name) : base("aws_gamelift_game_session_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomEventData
    {
        get => GetProperty<TerraformProperty<string>>("custom_event_data");
        set => this.WithProperty("custom_event_data", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Destinations
    {
        get => GetProperty<List<TerraformProperty<string>>>("destinations");
        set => this.WithProperty("destinations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationTarget
    {
        get => GetProperty<TerraformProperty<string>>("notification_target");
        set => this.WithProperty("notification_target", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => this.WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// Block for player_latency_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>? PlayerLatencyPolicy
    {
        get => GetProperty<List<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>>("player_latency_policy");
        set => this.WithProperty("player_latency_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
