using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module_key resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKey : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKey(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("versioned_id");
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformProperty<string>? Curve
    {
        get => GetProperty<TerraformProperty<string>>("curve");
        set => this.WithProperty("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
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
    /// The key_opts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? KeyOpts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("key_opts");
        set => this.WithProperty("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformProperty<double>? KeySize
    {
        get => GetProperty<TerraformProperty<double>>("key_size");
        set => this.WithProperty("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformProperty<string>? KeyType
    {
        get => GetProperty<TerraformProperty<string>>("key_type");
        set => this.WithProperty("key_type", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_id");
        set => this.WithProperty("managed_hsm_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformProperty<string>? NotBeforeDate
    {
        get => GetProperty<TerraformProperty<string>>("not_before_date");
        set => this.WithProperty("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformExpression VersionedId => this["versioned_id"];

}
