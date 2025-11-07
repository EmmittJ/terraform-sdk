using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_workspace_policy_fragment resource.
/// </summary>
public class AzurermApiManagementWorkspacePolicyFragment : TerraformResource
{
    public AzurermApiManagementWorkspacePolicyFragment(string name) : base("azurerm_api_management_workspace_policy_fragment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_workspace_id");
        set => this.WithProperty("api_management_workspace_id", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The xml_format attribute.
    /// </summary>
    public TerraformProperty<string>? XmlFormat
    {
        get => GetProperty<TerraformProperty<string>>("xml_format");
        set => this.WithProperty("xml_format", value);
    }

}
