using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_api_management_api_version_set.
/// </summary>
public class AzurermApiManagementApiVersionSetDataSource : TerraformDataSource
{
    public AzurermApiManagementApiVersionSetDataSource(string name) : base("azurerm_api_management_api_version_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("version_header_name");
        this.DeclareOutput("version_query_name");
        this.DeclareOutput("versioning_scheme");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The version_header_name attribute.
    /// </summary>
    public TerraformExpression VersionHeaderName => this["version_header_name"];

    /// <summary>
    /// The version_query_name attribute.
    /// </summary>
    public TerraformExpression VersionQueryName => this["version_query_name"];

    /// <summary>
    /// The versioning_scheme attribute.
    /// </summary>
    public TerraformExpression VersioningScheme => this["versioning_scheme"];

}
