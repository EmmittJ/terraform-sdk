using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_application_insights_smart_detection_rule resource.
/// </summary>
public class AzurermApplicationInsightsSmartDetectionRule : TerraformResource
{
    public AzurermApplicationInsightsSmartDetectionRule(string name) : base("azurerm_application_insights_smart_detection_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_email_recipients attribute.
    /// </summary>
    public HashSet<string>? AdditionalEmailRecipients
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("additional_email_recipients")?.Value;
        set => this.WithProperty("additional_email_recipients", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    public string? ApplicationInsightsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_insights_id")?.Value;
        set => this.WithProperty("application_insights_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The send_emails_to_subscription_owners attribute.
    /// </summary>
    public bool? SendEmailsToSubscriptionOwners
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("send_emails_to_subscription_owners")?.Value;
        set => this.WithProperty("send_emails_to_subscription_owners", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
