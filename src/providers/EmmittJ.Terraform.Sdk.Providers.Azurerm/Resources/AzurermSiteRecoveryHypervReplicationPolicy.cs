using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryHypervReplicationPolicy.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<double>>("application_consistent_snapshot_frequency_in_hours");
        set => SetArgument("application_consistent_snapshot_frequency_in_hours", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_point_retention_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInHours is required")]
    public required TerraformValue<double> RecoveryPointRetentionInHours
    {
        get => GetArgument<TerraformValue<double>>("recovery_point_retention_in_hours");
        set => SetArgument("recovery_point_retention_in_hours", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => GetArgument<TerraformValue<string>>("recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The replication_interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationIntervalInSeconds is required")]
    public required TerraformValue<double> ReplicationIntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("replication_interval_in_seconds");
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
