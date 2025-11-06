using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    /// The recovery_vault_id attribute.
    /// </summary>
    public string? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id")?.Value;
        set => this.WithProperty("recovery_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
