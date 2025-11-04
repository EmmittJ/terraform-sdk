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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the access package catalog
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    public bool? ExternallyVisible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("externally_visible")?.Value;
        set => this.WithProperty("externally_visible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    public bool? Published
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("published")?.Value;
        set => this.WithProperty("published", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
