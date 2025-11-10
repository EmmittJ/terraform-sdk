using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for automatic_update in .
/// Nesting mode: list
/// </summary>
public class AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AutomationAccountId
    {
        set => SetProperty("automation_account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_site_recovery_protection_container_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSiteRecoveryProtectionContainerMapping : TerraformResource
{
    public AzurermSiteRecoveryProtectionContainerMapping(string name) : base("azurerm_site_recovery_protection_container_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("name");
        SetOutput("recovery_fabric_name");
        SetOutput("recovery_replication_policy_id");
        SetOutput("recovery_source_protection_container_name");
        SetOutput("recovery_target_protection_container_id");
        SetOutput("recovery_vault_name");
        SetOutput("resource_group_name");
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
    /// The recovery_fabric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryFabricName is required")]
    public required TerraformProperty<string> RecoveryFabricName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_fabric_name");
        set => SetProperty("recovery_fabric_name", value);
    }

    /// <summary>
    /// The recovery_replication_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryReplicationPolicyId is required")]
    public required TerraformProperty<string> RecoveryReplicationPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_replication_policy_id");
        set => SetProperty("recovery_replication_policy_id", value);
    }

    /// <summary>
    /// The recovery_source_protection_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoverySourceProtectionContainerName is required")]
    public required TerraformProperty<string> RecoverySourceProtectionContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_source_protection_container_name");
        set => SetProperty("recovery_source_protection_container_name", value);
    }

    /// <summary>
    /// The recovery_target_protection_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryTargetProtectionContainerId is required")]
    public required TerraformProperty<string> RecoveryTargetProtectionContainerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_target_protection_container_id");
        set => SetProperty("recovery_target_protection_container_id", value);
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
    /// Block for automatic_update.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticUpdate block(s) allowed")]
    public List<AzurermSiteRecoveryProtectionContainerMappingAutomaticUpdateBlock>? AutomaticUpdate
    {
        set => SetProperty("automatic_update", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSiteRecoveryProtectionContainerMappingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
