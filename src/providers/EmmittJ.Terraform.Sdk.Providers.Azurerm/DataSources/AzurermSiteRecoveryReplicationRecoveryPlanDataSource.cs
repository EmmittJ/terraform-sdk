using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSiteRecoveryReplicationRecoveryPlanDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_site_recovery_replication_recovery_plan Terraform data source.
/// Retrieves information about a azurerm_site_recovery_replication_recovery_plan.
/// </summary>
public partial class AzurermSiteRecoveryReplicationRecoveryPlanDataSource(string name) : TerraformDataSource("azurerm_site_recovery_replication_recovery_plan", name)
{
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
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => GetArgument<TerraformValue<string>>("recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// The azure_to_azure_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureToAzureSettings
        => AsReference("azure_to_azure_settings");

    /// <summary>
    /// The failover_deployment_model attribute.
    /// </summary>
    public TerraformValue<string> FailoverDeploymentModel
        => AsReference("failover_deployment_model");

    /// <summary>
    /// The recovery_group attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> RecoveryGroup
        => AsReference("recovery_group");

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    public TerraformValue<string> SourceRecoveryFabricId
        => AsReference("source_recovery_fabric_id");

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    public TerraformValue<string> TargetRecoveryFabricId
        => AsReference("target_recovery_fabric_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
