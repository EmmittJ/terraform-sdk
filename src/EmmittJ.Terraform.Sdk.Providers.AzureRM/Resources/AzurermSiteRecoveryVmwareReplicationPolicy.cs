using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replication_policy resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicy : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicationPolicy(string name) : base("azurerm_site_recovery_vmware_replication_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? ApplicationConsistentSnapshotFrequencyInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("application_consistent_snapshot_frequency_in_minutes");
        set => this.WithProperty("application_consistent_snapshot_frequency_in_minutes", value);
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
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RecoveryPointRetentionInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("recovery_point_retention_in_minutes");
        set => this.WithProperty("recovery_point_retention_in_minutes", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

}
