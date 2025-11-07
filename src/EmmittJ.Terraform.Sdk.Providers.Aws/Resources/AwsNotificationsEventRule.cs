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
    public TerraformProperty<string>? EventPattern
    {
        get => GetProperty<TerraformProperty<string>>("event_pattern");
        set => this.WithProperty("event_pattern", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    public TerraformProperty<string>? EventType
    {
        get => GetProperty<TerraformProperty<string>>("event_type");
        set => this.WithProperty("event_type", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("notification_configuration_arn");
        set => this.WithProperty("notification_configuration_arn", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Regions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
