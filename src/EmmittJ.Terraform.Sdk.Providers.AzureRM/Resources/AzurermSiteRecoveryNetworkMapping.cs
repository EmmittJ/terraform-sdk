using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_network_mapping resource.
/// </summary>
public class AzurermSiteRecoveryNetworkMapping : TerraformResource
{
    public AzurermSiteRecoveryNetworkMapping(string name) : base("azurerm_site_recovery_network_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public TerraformProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("source_network_id");
        set => this.WithProperty("source_network_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceRecoveryFabricName
    {
        get => GetProperty<TerraformProperty<string>>("source_recovery_fabric_name");
        set => this.WithProperty("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetRecoveryFabricName
    {
        get => GetProperty<TerraformProperty<string>>("target_recovery_fabric_name");
        set => this.WithProperty("target_recovery_fabric_name", value);
    }

}
