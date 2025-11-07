using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api_operation_policy resource.
/// </summary>
public class AzurermApiManagementApiOperationPolicy : TerraformResource
{
    public AzurermApiManagementApiOperationPolicy(string name) : base("azurerm_api_management_api_operation_policy", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The xml_content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XmlContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xml_content");
        set => this.WithProperty("xml_content", value);
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XmlLink
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xml_link");
        set => this.WithProperty("xml_link", value);
    }

}
