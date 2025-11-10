using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
