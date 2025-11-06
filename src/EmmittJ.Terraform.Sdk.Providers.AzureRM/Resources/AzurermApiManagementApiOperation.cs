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
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    public string? ApiName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_name")?.Value;
        set => this.WithProperty("api_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The method attribute.
    /// </summary>
    public string? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method")?.Value;
        set => this.WithProperty("method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    public string? OperationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operation_id")?.Value;
        set => this.WithProperty("operation_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The url_template attribute.
    /// </summary>
    public string? UrlTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url_template")?.Value;
        set => this.WithProperty("url_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
