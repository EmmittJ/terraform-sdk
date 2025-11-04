using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The custom_event_data attribute.
    /// </summary>
    public string? CustomEventData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_event_data")?.Value;
        set => this.WithProperty("custom_event_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public List<string>? Destinations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("destinations")?.Value;
        set => this.WithProperty("destinations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_target attribute.
    /// </summary>
    public string? NotificationTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_target")?.Value;
        set => this.WithProperty("notification_target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public double? TimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_in_seconds")?.Value;
        set => this.WithProperty("timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
