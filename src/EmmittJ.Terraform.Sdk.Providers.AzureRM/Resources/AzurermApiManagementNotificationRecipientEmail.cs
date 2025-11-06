using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_notification_recipient_email resource.
/// </summary>
public class AzurermApiManagementNotificationRecipientEmail : TerraformResource
{
    public AzurermApiManagementNotificationRecipientEmail(string name) : base("azurerm_api_management_notification_recipient_email", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public string? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id")?.Value;
        set => this.WithProperty("api_management_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The notification_type attribute.
    /// </summary>
    public string? NotificationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_type")?.Value;
        set => this.WithProperty("notification_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
