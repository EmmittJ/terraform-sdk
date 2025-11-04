using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_desktop_workspace_application_group_association resource.
/// </summary>
public class AzurermVirtualDesktopWorkspaceApplicationGroupAssociation : TerraformResource
{
    public AzurermVirtualDesktopWorkspaceApplicationGroupAssociation(string name) : base("azurerm_virtual_desktop_workspace_application_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_group_id attribute.
    /// </summary>
    public string? ApplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_group_id")?.Value;
        set => this.WithProperty("application_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
