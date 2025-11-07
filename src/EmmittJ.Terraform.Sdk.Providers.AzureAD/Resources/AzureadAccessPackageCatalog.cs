using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_access_package_catalog resource.
/// </summary>
public class AzureadAccessPackageCatalog : TerraformResource
{
    public AzureadAccessPackageCatalog(string name) : base("azuread_access_package_catalog", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the access package catalog
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    public TerraformProperty<bool>? ExternallyVisible
    {
        get => GetProperty<TerraformProperty<bool>>("externally_visible");
        set => this.WithProperty("externally_visible", value);
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
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    public TerraformProperty<bool>? Published
    {
        get => GetProperty<TerraformProperty<bool>>("published");
        set => this.WithProperty("published", value);
    }

}
