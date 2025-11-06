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
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_header_name attribute.
    /// </summary>
    public string? VersionHeaderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_header_name")?.Value;
        set => this.WithProperty("version_header_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_query_name attribute.
    /// </summary>
    public string? VersionQueryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_query_name")?.Value;
        set => this.WithProperty("version_query_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The versioning_scheme attribute.
    /// </summary>
    public string? VersioningScheme
    {
        get => GetProperty<TerraformLiteralProperty<string>>("versioning_scheme")?.Value;
        set => this.WithProperty("versioning_scheme", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
