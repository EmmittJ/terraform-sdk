using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_notifications_event_rule resource.
/// </summary>
public class AwsNotificationsEventRule : TerraformResource
{
    public AwsNotificationsEventRule(string name) : base("aws_notifications_event_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    public string? EventPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_pattern")?.Value;
        set => this.WithProperty("event_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public string? EventType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_type")?.Value;
        set => this.WithProperty("event_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    public string? NotificationConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_configuration_arn")?.Value;
        set => this.WithProperty("notification_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<string>? Regions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("regions")?.Value;
        set => this.WithProperty("regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
