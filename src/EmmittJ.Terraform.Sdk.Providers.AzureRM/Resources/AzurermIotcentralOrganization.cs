using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iotcentral_organization resource.
/// </summary>
public class AzurermIotcentralOrganization : TerraformResource
{
    public AzurermIotcentralOrganization(string name) : base("azurerm_iotcentral_organization", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The iotcentral_application_id attribute.
    /// </summary>
    public TerraformProperty<string>? IotcentralApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("iotcentral_application_id");
        set => this.WithProperty("iotcentral_application_id", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
    }

    /// <summary>
    /// The parent_organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentOrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("parent_organization_id");
        set => this.WithProperty("parent_organization_id", value);
    }

}
