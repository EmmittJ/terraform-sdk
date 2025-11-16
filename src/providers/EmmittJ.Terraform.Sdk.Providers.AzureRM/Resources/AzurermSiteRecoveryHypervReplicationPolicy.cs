using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_site_recovery_hyperv_replication_policy Terraform resource.
/// Manages a azurerm_site_recovery_hyperv_replication_policy resource.
/// </summary>
public partial class AzurermSiteRecoveryHypervReplicationPolicy(string name) : TerraformResource("azurerm_site_recovery_hyperv_replication_policy", name)
{
    /// <summary>
    /// The application_consistent_snapshot_frequency_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationConsistentSnapshotFrequencyInHours is required")]
    public required TerraformValue<double> ApplicationConsistentSnapshotFrequencyInHours
    {
        get => new TerraformReference<double>(this, "application_consistent_snapshot_frequency_in_hours");
        set => SetArgument("application_consistent_snapshot_frequency_in_hours", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_point_retention_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInHours is required")]
    public required TerraformValue<double> RecoveryPointRetentionInHours
    {
        get => new TerraformReference<double>(this, "recovery_point_retention_in_hours");
        set => SetArgument("recovery_point_retention_in_hours", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => new TerraformReference<string>(this, "recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The replication_interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationIntervalInSeconds is required")]
    public required TerraformValue<double> ReplicationIntervalInSeconds
    {
        get => new TerraformReference<double>(this, "replication_interval_in_seconds");
        set => SetArgument("replication_interval_in_seconds", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryHypervReplicationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
