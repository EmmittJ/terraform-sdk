using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationConsistentSnapshotFrequencyInHours is required")]
    public required TerraformProperty<double> ApplicationConsistentSnapshotFrequencyInHours
    {
        get => GetProperty<TerraformProperty<double>>("application_consistent_snapshot_frequency_in_hours");
        set => this.WithProperty("application_consistent_snapshot_frequency_in_hours", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_point_retention_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInHours is required")]
    public required TerraformProperty<double> RecoveryPointRetentionInHours
    {
        get => GetProperty<TerraformProperty<double>>("recovery_point_retention_in_hours");
        set => this.WithProperty("recovery_point_retention_in_hours", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The replication_interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationIntervalInSeconds is required")]
    public required TerraformProperty<double> ReplicationIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("replication_interval_in_seconds");
        set => this.WithProperty("replication_interval_in_seconds", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
