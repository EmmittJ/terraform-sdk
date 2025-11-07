using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_hyperv_replication_policy resource.
/// </summary>
public class AzurermSiteRecoveryHypervReplicationPolicy : TerraformResource
{
    public AzurermSiteRecoveryHypervReplicationPolicy(string name) : base("azurerm_site_recovery_hyperv_replication_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_hours attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ApplicationConsistentSnapshotFrequencyInHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_consistent_snapshot_frequency_in_hours");
        set => this.WithProperty("application_consistent_snapshot_frequency_in_hours", value);
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
    /// The recovery_point_retention_in_hours attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RecoveryPointRetentionInHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("recovery_point_retention_in_hours");
        set => this.WithProperty("recovery_point_retention_in_hours", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The replication_interval_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReplicationIntervalInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_interval_in_seconds");
        set => this.WithProperty("replication_interval_in_seconds", value);
    }

}
