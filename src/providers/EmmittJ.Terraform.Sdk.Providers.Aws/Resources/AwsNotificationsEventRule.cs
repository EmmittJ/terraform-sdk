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
        SetOutput("arn");
        SetOutput("event_pattern");
        SetOutput("event_type");
        SetOutput("notification_configuration_arn");
        SetOutput("regions");
        SetOutput("source");
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    public TerraformProperty<string> EventPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_pattern");
        set => SetProperty("event_pattern", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformProperty<string> EventType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_type");
        set => SetProperty("event_type", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    public required TerraformProperty<string> NotificationConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_configuration_arn");
        set => SetProperty("notification_configuration_arn", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public HashSet<TerraformProperty<string>> Regions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("regions");
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
