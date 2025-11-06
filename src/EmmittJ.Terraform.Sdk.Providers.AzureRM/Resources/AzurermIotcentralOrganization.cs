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
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    public string? IotcentralApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iotcentral_application_id")?.Value;
        set => this.WithProperty("iotcentral_application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public string? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id")?.Value;
        set => this.WithProperty("organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_organization_id attribute.
    /// </summary>
    public string? ParentOrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_organization_id")?.Value;
        set => this.WithProperty("parent_organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
