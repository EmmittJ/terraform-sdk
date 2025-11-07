using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_portal_tenant_configuration resource.
/// </summary>
public class AzurermPortalTenantConfiguration : TerraformResource
{
    public AzurermPortalTenantConfiguration(string name) : base("azurerm_portal_tenant_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The private_markdown_storage_enforced attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateMarkdownStorageEnforced
    {
        get => GetProperty<TerraformProperty<bool>>("private_markdown_storage_enforced");
        set => this.WithProperty("private_markdown_storage_enforced", value);
    }

}
