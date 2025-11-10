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
        set => SetProperty("maximum_individual_player_latency_milliseconds", value);
    }

    /// <summary>
    /// The policy_duration_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? PolicyDurationSeconds
    {
        set => SetProperty("policy_duration_seconds", value);
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
        SetOutput("arn");
        SetOutput("custom_event_data");
        SetOutput("destinations");
        SetOutput("id");
        SetOutput("name");
        SetOutput("notification_target");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("timeout_in_seconds");
    }

    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    public TerraformProperty<string> CustomEventData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_event_data");
        set => SetProperty("custom_event_data", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Destinations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("destinations");
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    public TerraformProperty<string> NotificationTarget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_target");
        set => SetProperty("notification_target", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> TimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout_in_seconds");
        set => SetProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// Block for player_latency_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGameliftGameSessionQueuePlayerLatencyPolicyBlock>? PlayerLatencyPolicy
    {
        set => SetProperty("player_latency_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
