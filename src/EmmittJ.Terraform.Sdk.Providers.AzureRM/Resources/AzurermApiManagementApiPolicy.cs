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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The xml_content attribute.
    /// </summary>
    public TerraformProperty<string>? XmlContent
    {
        get => GetProperty<TerraformProperty<string>>("xml_content");
        set => this.WithProperty("xml_content", value);
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public TerraformProperty<string>? XmlLink
    {
        get => GetProperty<TerraformProperty<string>>("xml_link");
        set => this.WithProperty("xml_link", value);
    }

}
