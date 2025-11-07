using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_workspace_aad_admin resource.
/// </summary>
public class AzurermSynapseWorkspaceAadAdmin : TerraformResource
{
    public AzurermSynapseWorkspaceAadAdmin(string name) : base("azurerm_synapse_workspace_aad_admin", name)
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
    /// The login attribute.
    /// </summary>
    public TerraformProperty<string>? Login
    {
        get => GetProperty<TerraformProperty<string>>("login");
        set => this.WithProperty("login", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => this.WithProperty("object_id", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

}
