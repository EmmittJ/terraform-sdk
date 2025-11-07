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
    public TerraformProperty<bool>? AlertNotifications
    {
        get => GetProperty<TerraformProperty<bool>>("alert_notifications");
        set => this.WithProperty("alert_notifications", value);
    }

    /// <summary>
    /// The alerts_to_admins attribute.
    /// </summary>
    public TerraformProperty<bool>? AlertsToAdmins
    {
        get => GetProperty<TerraformProperty<bool>>("alerts_to_admins");
        set => this.WithProperty("alerts_to_admins", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
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
    /// The phone attribute.
    /// </summary>
    public TerraformProperty<string>? Phone
    {
        get => GetProperty<TerraformProperty<string>>("phone");
        set => this.WithProperty("phone", value);
    }

}
