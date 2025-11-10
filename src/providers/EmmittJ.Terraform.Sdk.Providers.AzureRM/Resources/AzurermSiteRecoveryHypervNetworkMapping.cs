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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_vault_id");
        SetOutput("source_network_name");
        SetOutput("source_system_center_virtual_machine_manager_name");
        SetOutput("target_network_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recovery_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultId is required")]
    public required TerraformProperty<string> RecoveryVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_id");
        set => SetProperty("recovery_vault_id", value);
    }

    /// <summary>
    /// The source_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkName is required")]
    public required TerraformProperty<string> SourceNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_network_name");
        set => SetProperty("source_network_name", value);
    }

    /// <summary>
    /// The source_system_center_virtual_machine_manager_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSystemCenterVirtualMachineManagerName is required")]
    public required TerraformProperty<string> SourceSystemCenterVirtualMachineManagerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_system_center_virtual_machine_manager_name");
        set => SetProperty("source_system_center_virtual_machine_manager_name", value);
    }

    /// <summary>
    /// The target_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetNetworkId is required")]
    public required TerraformProperty<string> TargetNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_network_id");
        set => SetProperty("target_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryHypervNetworkMappingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
