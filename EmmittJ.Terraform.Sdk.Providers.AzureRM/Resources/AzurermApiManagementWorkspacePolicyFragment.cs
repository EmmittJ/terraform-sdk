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
    public string? ApiManagementWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_workspace_id")?.Value;
        set => this.WithProperty("api_management_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The xml_format attribute.
    /// </summary>
    public string? XmlFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xml_format")?.Value;
        set => this.WithProperty("xml_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
