using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_protection_container_mapping resource.
/// </summary>
public class AzurermSiteRecoveryProtectionContainerMapping : TerraformResource
{
    public AzurermSiteRecoveryProtectionContainerMapping(string name) : base("azurerm_site_recovery_protection_container_mapping", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_fabric_name attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryFabricName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_fabric_name");
        set => this.WithProperty("recovery_fabric_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_replication_policy_id");
        set => this.WithProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_source_protection_container_name attribute.
    /// </summary>
    public TerraformProperty<string>? RecoverySourceProtectionContainerName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_source_protection_container_name");
        set => this.WithProperty("recovery_source_protection_container_name", value);
    }

    /// <summary>
    /// The recovery_target_protection_container_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryTargetProtectionContainerId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_target_protection_container_id");
        set => this.WithProperty("recovery_target_protection_container_id", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
