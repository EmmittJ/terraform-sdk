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
    public double? ApplicationConsistentSnapshotFrequencyInHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_consistent_snapshot_frequency_in_hours")?.Value;
        set => this.WithProperty("application_consistent_snapshot_frequency_in_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The recovery_point_retention_in_hours attribute.
    /// </summary>
    public double? RecoveryPointRetentionInHours
    {
        get => GetProperty<TerraformLiteralProperty<double>>("recovery_point_retention_in_hours")?.Value;
        set => this.WithProperty("recovery_point_retention_in_hours", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public string? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id")?.Value;
        set => this.WithProperty("recovery_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replication_interval_in_seconds attribute.
    /// </summary>
    public double? ReplicationIntervalInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("replication_interval_in_seconds")?.Value;
        set => this.WithProperty("replication_interval_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
