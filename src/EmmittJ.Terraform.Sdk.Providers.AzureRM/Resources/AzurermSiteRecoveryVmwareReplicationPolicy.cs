using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_vmware_replication_policy resource.
/// </summary>
public class AzurermSiteRecoveryVmwareReplicationPolicy : TerraformResource
{
    public AzurermSiteRecoveryVmwareReplicationPolicy(string name) : base("azurerm_site_recovery_vmware_replication_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_consistent_snapshot_frequency_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ApplicationConsistentSnapshotFrequencyInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("application_consistent_snapshot_frequency_in_minutes");
        set => this.WithProperty("application_consistent_snapshot_frequency_in_minutes", value);
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
    /// The recovery_point_retention_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RecoveryPointRetentionInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("recovery_point_retention_in_minutes");
        set => this.WithProperty("recovery_point_retention_in_minutes", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

}
