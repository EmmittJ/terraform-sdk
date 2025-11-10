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
        this.WithOutput("arn");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformProperty<string> EventType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("event_type");
        set => this.WithProperty("event_type", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    public required TerraformProperty<string> NotificationConfigurationArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("notification_configuration_arn");
        set => this.WithProperty("notification_configuration_arn", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public HashSet<TerraformProperty<string>>? Regions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
