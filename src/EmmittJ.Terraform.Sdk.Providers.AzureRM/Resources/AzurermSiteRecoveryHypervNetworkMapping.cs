using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_site_recovery_hyperv_network_mapping resource.
/// </summary>
public class AzurermSiteRecoveryHypervNetworkMapping : TerraformResource
{
    public AzurermSiteRecoveryHypervNetworkMapping(string name) : base("azurerm_site_recovery_hyperv_network_mapping", name)
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
    /// The recovery_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_id");
        set => this.WithProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_network_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_network_name");
        set => this.WithProperty("source_network_name", value);
    }

    /// <summary>
    /// The source_system_center_virtual_machine_manager_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceSystemCenterVirtualMachineManagerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_system_center_virtual_machine_manager_name");
        set => this.WithProperty("source_system_center_virtual_machine_manager_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

}
