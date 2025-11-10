using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for protected_settings_from_key_vault in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionProtectedSettingsFromKeyVaultBlock : TerraformBlock
{
    /// <summary>
    /// The secret_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUrl is required")]
    public required TerraformProperty<string> SecretUrl
    {
        set => SetProperty("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformProperty<string> SourceVaultId
    {
        set => SetProperty("source_vault_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_machine_scale_set_extension resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualMachineScaleSetExtension : TerraformResource
{
    public AzurermVirtualMachineScaleSetExtension(string name) : base("azurerm_virtual_machine_scale_set_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_upgrade_minor_version");
        SetOutput("automatic_upgrade_enabled");
        SetOutput("failure_suppression_enabled");
        SetOutput("force_update_tag");
        SetOutput("id");
        SetOutput("name");
        SetOutput("protected_settings");
        SetOutput("provision_after_extensions");
        SetOutput("publisher");
        SetOutput("settings");
        SetOutput("type");
        SetOutput("type_handler_version");
        SetOutput("virtual_machine_scale_set_id");
    }

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformProperty<bool> AutoUpgradeMinorVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_upgrade_minor_version");
        set => SetProperty("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticUpgradeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_upgrade_enabled");
        set => SetProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FailureSuppressionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("failure_suppression_enabled");
        set => SetProperty("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string> ForceUpdateTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("force_update_tag");
        set => SetProperty("force_update_tag", value);
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
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string> ProtectedSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protected_settings");
        set => SetProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public List<TerraformProperty<string>> ProvisionAfterExtensions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("provision_after_extensions");
        set => SetProperty("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredOutput<TerraformProperty<string>>("publisher");
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string> Settings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("settings");
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_handler_version");
        set => SetProperty("type_handler_version", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineScaleSetId is required")]
    public required TerraformProperty<string> VirtualMachineScaleSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => SetProperty("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// Block for protected_settings_from_key_vault.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtectedSettingsFromKeyVault block(s) allowed")]
    public List<AzurermVirtualMachineScaleSetExtensionProtectedSettingsFromKeyVaultBlock>? ProtectedSettingsFromKeyVault
    {
        set => SetProperty("protected_settings_from_key_vault", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineScaleSetExtensionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
