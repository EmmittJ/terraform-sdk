using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api_version_set resource.
/// </summary>
public class AzurermApiManagementApiVersionSet : TerraformResource
{
    public AzurermApiManagementApiVersionSet(string name) : base("azurerm_api_management_api_version_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The version_header_name attribute.
    /// </summary>
    public TerraformProperty<string>? VersionHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("version_header_name");
        set => this.WithProperty("version_header_name", value);
    }

    /// <summary>
    /// The version_query_name attribute.
    /// </summary>
    public TerraformProperty<string>? VersionQueryName
    {
        get => GetProperty<TerraformProperty<string>>("version_query_name");
        set => this.WithProperty("version_query_name", value);
    }

    /// <summary>
    /// The versioning_scheme attribute.
    /// </summary>
    public TerraformProperty<string>? VersioningScheme
    {
        get => GetProperty<TerraformProperty<string>>("versioning_scheme");
        set => this.WithProperty("versioning_scheme", value);
    }

}
