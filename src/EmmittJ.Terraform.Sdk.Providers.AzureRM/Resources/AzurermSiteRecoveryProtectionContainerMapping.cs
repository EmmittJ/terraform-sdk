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
    /// The recovery_fabric_name attribute.
    /// </summary>
    public string? RecoveryFabricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_fabric_name")?.Value;
        set => this.WithProperty("recovery_fabric_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    public string? RecoveryReplicationPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_replication_policy_id")?.Value;
        set => this.WithProperty("recovery_replication_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_source_protection_container_name attribute.
    /// </summary>
    public string? RecoverySourceProtectionContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_source_protection_container_name")?.Value;
        set => this.WithProperty("recovery_source_protection_container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_target_protection_container_id attribute.
    /// </summary>
    public string? RecoveryTargetProtectionContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_target_protection_container_id")?.Value;
        set => this.WithProperty("recovery_target_protection_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public string? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name")?.Value;
        set => this.WithProperty("recovery_vault_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
