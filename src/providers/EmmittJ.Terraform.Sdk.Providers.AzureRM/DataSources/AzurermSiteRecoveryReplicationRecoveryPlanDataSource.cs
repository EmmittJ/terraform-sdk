using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_recovery_plan.
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSource(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    [TerraformArgument("recovery_vault_id")]
    public required TerraformValue<string> RecoveryVaultId
    {
        get => new TerraformReference<string>(this, "recovery_vault_id");
        set => SetArgument("recovery_vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_to_azure_settings attribute.
    /// </summary>
    [TerraformArgument("azure_to_azure_settings")]
    public TerraformList<object> AzureToAzureSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azure_to_azure_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The failover_deployment_model attribute.
    /// </summary>
    [TerraformArgument("failover_deployment_model")]
    public TerraformValue<string> FailoverDeploymentModel
    {
        get => new TerraformReference<string>(this, "failover_deployment_model");
    }

    /// <summary>
    /// The recovery_group attribute.
    /// </summary>
    [TerraformArgument("recovery_group")]
    public TerraformSet<object> RecoveryGroup
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "recovery_group").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    [TerraformArgument("source_recovery_fabric_id")]
    public TerraformValue<string> SourceRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "source_recovery_fabric_id");
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    [TerraformArgument("target_recovery_fabric_id")]
    public TerraformValue<string> TargetRecoveryFabricId
    {
        get => new TerraformReference<string>(this, "target_recovery_fabric_id");
    }

}
