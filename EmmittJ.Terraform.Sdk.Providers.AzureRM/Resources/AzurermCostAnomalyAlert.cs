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
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<string>? EmailAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("email_addresses")?.Value;
        set => this.WithProperty("email_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public string? EmailSubject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_subject")?.Value;
        set => this.WithProperty("email_subject", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The message attribute.
    /// </summary>
    public string? Message
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message")?.Value;
        set => this.WithProperty("message", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The notification_email attribute.
    /// </summary>
    public string? NotificationEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_email")?.Value;
        set => this.WithProperty("notification_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
