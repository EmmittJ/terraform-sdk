using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryNetworkMappingTimeoutsBlock : TerraformBlock
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_vault_name");
        SetOutput("resource_group_name");
        SetOutput("source_network_id");
        SetOutput("source_recovery_fabric_name");
        SetOutput("target_network_id");
        SetOutput("target_recovery_fabric_name");
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
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_name");
        set => SetProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceNetworkId is required")]
    public required TerraformProperty<string> SourceNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_network_id");
        set => SetProperty("source_network_id", value);
    }

    /// <summary>
    /// The source_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRecoveryFabricName is required")]
    public required TerraformProperty<string> SourceRecoveryFabricName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_recovery_fabric_name");
        set => SetProperty("source_recovery_fabric_name", value);
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
    /// The target_recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRecoveryFabricName is required")]
    public required TerraformProperty<string> TargetRecoveryFabricName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_recovery_fabric_name");
        set => SetProperty("target_recovery_fabric_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryNetworkMappingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
