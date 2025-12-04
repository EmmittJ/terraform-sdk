using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryVmwareReplicationPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_site_recovery_vmware_replication_policy Terraform resource.
/// Manages a azurerm_site_recovery_vmware_replication_policy resource.
/// </summary>
public partial class AzurermSiteRecoveryVmwareReplicationPolicy(string name) : TerraformResource("azurerm_site_recovery_vmware_replication_policy", name)
{
    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationConsistentSnapshotFrequencyInMinutes is required")]
    public required TerraformValue<double> ApplicationConsistentSnapshotFrequencyInMinutes
    {
        get => GetArgument<TerraformValue<double>>("application_consistent_snapshot_frequency_in_minutes");
        set => SetArgument("application_consistent_snapshot_frequency_in_minutes", value);
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
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInMinutes is required")]
    public required TerraformValue<double> RecoveryPointRetentionInMinutes
    {
        get => GetArgument<TerraformValue<double>>("recovery_point_retention_in_minutes");
        set => SetArgument("recovery_point_retention_in_minutes", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryVmwareReplicationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryVmwareReplicationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
