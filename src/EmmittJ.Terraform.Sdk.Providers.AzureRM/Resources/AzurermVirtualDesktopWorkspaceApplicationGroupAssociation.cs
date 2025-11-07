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
    public TerraformLiteralProperty<string>? ApplicationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_group_id");
        set => this.WithProperty("application_group_id", value);
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
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
