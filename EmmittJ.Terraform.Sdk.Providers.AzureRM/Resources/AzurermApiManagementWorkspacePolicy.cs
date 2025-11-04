using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_workspace_policy resource.
/// </summary>
public class AzurermApiManagementWorkspacePolicy : TerraformResource
{
    public AzurermApiManagementWorkspacePolicy(string name) : base("azurerm_api_management_workspace_policy", name)
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
