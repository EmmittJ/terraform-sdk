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
    public TerraformLiteralProperty<string>? ApiManagementWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_workspace_id");
        set => this.WithProperty("api_management_workspace_id", value);
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
