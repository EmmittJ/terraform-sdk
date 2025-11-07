using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_workspace_key resource.
/// </summary>
public class AzurermSynapseWorkspaceKey : TerraformResource
{
    public AzurermSynapseWorkspaceKey(string name) : base("azurerm_synapse_workspace_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        get => GetProperty<TerraformProperty<bool>>("active");
        set => this.WithProperty("active", value);
    }

    /// <summary>
    /// The customer_managed_key_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKeyName
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_name");
        set => this.WithProperty("customer_managed_key_name", value);
    }

    /// <summary>
    /// The customer_managed_key_versionless_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKeyVersionlessId
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_versionless_id");
        set => this.WithProperty("customer_managed_key_versionless_id", value);
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
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

}
