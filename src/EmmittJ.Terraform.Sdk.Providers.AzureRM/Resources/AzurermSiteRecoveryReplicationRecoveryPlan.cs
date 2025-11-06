using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_replication_recovery_plan resource.
/// </summary>
public class AzurermSiteRecoveryReplicationRecoveryPlan : TerraformResource
{
    public AzurermSiteRecoveryReplicationRecoveryPlan(string name) : base("azurerm_site_recovery_replication_recovery_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The source_recovery_fabric_id attribute.
    /// </summary>
    public string? SourceRecoveryFabricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_fabric_id")?.Value;
        set => this.WithProperty("source_recovery_fabric_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_recovery_fabric_id attribute.
    /// </summary>
    public string? TargetRecoveryFabricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_fabric_id")?.Value;
        set => this.WithProperty("target_recovery_fabric_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
