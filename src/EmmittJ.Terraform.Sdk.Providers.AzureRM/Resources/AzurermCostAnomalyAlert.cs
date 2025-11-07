using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cost_anomaly_alert resource.
/// </summary>
public class AzurermCostAnomalyAlert : TerraformResource
{
    public AzurermCostAnomalyAlert(string name) : base("azurerm_cost_anomaly_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EmailAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        get => GetProperty<TerraformProperty<string>>("email_subject");
        set => this.WithProperty("email_subject", value);
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
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string>? Message
    {
        get => GetProperty<TerraformProperty<string>>("message");
        set => this.WithProperty("message", value);
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
    /// The notification_email attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationEmail
    {
        get => GetProperty<TerraformProperty<string>>("notification_email");
        set => this.WithProperty("notification_email", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
