using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_recovery_plan.
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlanDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSource(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("azure_to_azure_settings");
        this.DeclareOutput("failover_deployment_model");
        this.DeclareOutput("recovery_group");
        this.DeclareOutput("source_recovery_fabric_id");
        this.DeclareOutput("target_recovery_fabric_id");
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
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryReplicationRecoveryPlanDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The azure_to_azure_settings attribute.
    /// </summary>
    public TerraformExpression AzureToAzureSettings => this["azure_to_azure_settings"];

    /// <summary>
    /// The failover_deployment_model attribute.
    /// </summary>
    public TerraformExpression FailoverDeploymentModel => this["failover_deployment_model"];

    /// <summary>
    /// The recovery_group attribute.
    /// </summary>
    public TerraformExpression RecoveryGroup => this["recovery_group"];

    /// <summary>
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    public TerraformExpression SourceRecoveryFabricId => this["source_recovery_fabric_id"];

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    public TerraformExpression TargetRecoveryFabricId => this["target_recovery_fabric_id"];

}
