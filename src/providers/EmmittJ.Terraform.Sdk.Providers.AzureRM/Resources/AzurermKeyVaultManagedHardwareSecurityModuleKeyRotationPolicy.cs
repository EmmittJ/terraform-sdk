using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_key_vault_managed_hardware_security_module_key_rotation_policy resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy(string name) : base("azurerm_key_vault_managed_hardware_security_module_key_rotation_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("expire_after");
        SetOutput("id");
        SetOutput("managed_hsm_key_id");
        SetOutput("time_after_creation");
        SetOutput("time_before_expiry");
    }

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpireAfter is required")]
    public required TerraformProperty<string> ExpireAfter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expire_after");
        set => SetProperty("expire_after", value);
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
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmKeyId is required")]
    public required TerraformProperty<string> ManagedHsmKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_key_id");
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    public TerraformProperty<string> TimeAfterCreation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_after_creation");
        set => SetProperty("time_after_creation", value);
    }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    public TerraformProperty<string> TimeBeforeExpiry
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_before_expiry");
        set => SetProperty("time_before_expiry", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
