using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

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
    /// The source_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkName is required")]
    public required TerraformProperty<string> SourceNetworkName
    {
        get => GetProperty<TerraformProperty<string>>("source_network_name");
        set => this.WithProperty("source_network_name", value);
    }

    /// <summary>
    /// The source_system_center_virtual_machine_manager_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSystemCenterVirtualMachineManagerName is required")]
    public required TerraformProperty<string> SourceSystemCenterVirtualMachineManagerName
    {
        get => GetProperty<TerraformProperty<string>>("source_system_center_virtual_machine_manager_name");
        set => this.WithProperty("source_system_center_virtual_machine_manager_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    public required TerraformProperty<string> TargetNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("target_network_id");
        set => this.WithProperty("target_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
