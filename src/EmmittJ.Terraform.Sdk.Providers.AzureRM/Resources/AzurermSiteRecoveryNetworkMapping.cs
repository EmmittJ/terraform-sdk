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
    /// The source_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_network_id");
        set => this.WithProperty("source_network_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceRecoveryFabricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_recovery_fabric_name");
        set => this.WithProperty("source_recovery_fabric_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

    /// <summary>
    /// The target_recovery_fabric_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetRecoveryFabricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_recovery_fabric_name");
        set => this.WithProperty("target_recovery_fabric_name", value);
    }

}
