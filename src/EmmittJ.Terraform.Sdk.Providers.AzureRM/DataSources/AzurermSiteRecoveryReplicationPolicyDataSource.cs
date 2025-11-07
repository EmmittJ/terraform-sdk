using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_site_recovery_replication_policy.
/// </summary>
public class AzurermSiteRecoveryReplicationPolicyDataSource : TerraformDataSource
{
    public AzurermSiteRecoveryReplicationPolicyDataSource(string name) : base("azurerm_site_recovery_replication_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_consistent_snapshot_frequency_in_minutes");
        this.DeclareOutput("recovery_point_retention_in_minutes");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    public TerraformExpression ApplicationConsistentSnapshotFrequencyInMinutes => this["application_consistent_snapshot_frequency_in_minutes"];

    /// <summary>
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    public TerraformExpression RecoveryPointRetentionInMinutes => this["recovery_point_retention_in_minutes"];

}
