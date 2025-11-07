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
    public TerraformProperty<HashSet<string>>? AdditionalEmailRecipients
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("additional_email_recipients");
        set => this.WithProperty("additional_email_recipients", value);
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsId
    {
        get => GetProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The send_emails_to_subscription_owners attribute.
    /// </summary>
    public TerraformProperty<bool>? SendEmailsToSubscriptionOwners
    {
        get => GetProperty<TerraformProperty<bool>>("send_emails_to_subscription_owners");
        set => this.WithProperty("send_emails_to_subscription_owners", value);
    }

}
