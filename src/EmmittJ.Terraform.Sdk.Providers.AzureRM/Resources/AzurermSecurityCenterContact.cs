using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_contact resource.
/// </summary>
public class AzurermSecurityCenterContact : TerraformResource
{
    public AzurermSecurityCenterContact(string name) : base("azurerm_security_center_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alert_notifications attribute.
    /// </summary>
    public bool? AlertNotifications
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("alert_notifications")?.Value;
        set => this.WithProperty("alert_notifications", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The alerts_to_admins attribute.
    /// </summary>
    public bool? AlertsToAdmins
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("alerts_to_admins")?.Value;
        set => this.WithProperty("alerts_to_admins", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public string? Phone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone")?.Value;
        set => this.WithProperty("phone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
