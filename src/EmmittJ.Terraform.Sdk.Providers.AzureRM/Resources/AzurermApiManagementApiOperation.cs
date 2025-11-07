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
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_name");
        set => this.WithProperty("api_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OperationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operation_id");
        set => this.WithProperty("operation_id", value);
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
    /// The url_template attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UrlTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url_template");
        set => this.WithProperty("url_template", value);
    }

}
