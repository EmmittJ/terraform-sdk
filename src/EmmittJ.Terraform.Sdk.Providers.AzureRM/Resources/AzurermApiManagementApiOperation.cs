using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api_operation resource.
/// </summary>
public class AzurermApiManagementApiOperation : TerraformResource
{
    public AzurermApiManagementApiOperation(string name) : base("azurerm_api_management_api_operation", name)
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
    /// The api_name attribute.
    /// </summary>
    public TerraformProperty<string>? ApiName
    {
        get => GetProperty<TerraformProperty<string>>("api_name");
        set => this.WithProperty("api_name", value);
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
    /// The method attribute.
    /// </summary>
    public TerraformProperty<string>? Method
    {
        get => GetProperty<TerraformProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    public TerraformProperty<string>? OperationId
    {
        get => GetProperty<TerraformProperty<string>>("operation_id");
        set => this.WithProperty("operation_id", value);
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
    /// The url_template attribute.
    /// </summary>
    public TerraformProperty<string>? UrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("url_template");
        set => this.WithProperty("url_template", value);
    }

}
