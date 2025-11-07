using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replication_policy_association resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicyAssociation : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicationPolicyAssociation(string name) : base("azurerm_site_recovery_vmware_replication_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id");
        set => this.WithProperty("policy_id", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

}
