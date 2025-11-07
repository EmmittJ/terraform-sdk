using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_policy resource.
/// </summary>
public class AzurermApiManagementPolicy : TerraformResource
{
    public AzurermApiManagementPolicy(string name) : base("azurerm_api_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
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
