using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    public TerraformProperty<string>? ExpireAfter
    {
        get => GetProperty<TerraformProperty<string>>("expire_after");
        set => this.WithProperty("expire_after", value);
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
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    public TerraformProperty<string>? TimeAfterCreation
    {
        get => GetProperty<TerraformProperty<string>>("time_after_creation");
        set => this.WithProperty("time_after_creation", value);
    }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    public TerraformProperty<string>? TimeBeforeExpiry
    {
        get => GetProperty<TerraformProperty<string>>("time_before_expiry");
        set => this.WithProperty("time_before_expiry", value);
    }

}
