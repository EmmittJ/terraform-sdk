using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryReplicationPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_site_recovery_replication_policy Terraform resource.
/// Manages a azurerm_site_recovery_replication_policy resource.
/// </summary>
public partial class AzurermSiteRecoveryReplicationPolicy(string name) : TerraformResource("azurerm_site_recovery_replication_policy", name)
{
    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationConsistentSnapshotFrequencyInMinutes is required")]
    public required TerraformValue<double> ApplicationConsistentSnapshotFrequencyInMinutes
    {
        get => new TerraformReference<double>(this, "application_consistent_snapshot_frequency_in_minutes");
        set => SetArgument("application_consistent_snapshot_frequency_in_minutes", value);
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
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryPointRetentionInMinutes is required")]
    public required TerraformValue<double> RecoveryPointRetentionInMinutes
    {
        get => new TerraformReference<double>(this, "recovery_point_retention_in_minutes");
        set => SetArgument("recovery_point_retention_in_minutes", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryReplicationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryReplicationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
