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
    public TerraformLiteralProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email");
        set => this.WithProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_type");
        set => this.WithProperty("notification_type", value);
    }

}
