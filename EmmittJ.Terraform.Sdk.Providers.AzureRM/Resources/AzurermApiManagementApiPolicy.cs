using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api_policy resource.
/// </summary>
public class AzurermApiManagementApiPolicy : TerraformResource
{
    public AzurermApiManagementApiPolicy(string name) : base("azurerm_api_management_api_policy", name)
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The xml_content attribute.
    /// </summary>
    public string? XmlContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xml_content")?.Value;
        set => this.WithProperty("xml_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public string? XmlLink
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xml_link")?.Value;
        set => this.WithProperty("xml_link", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
