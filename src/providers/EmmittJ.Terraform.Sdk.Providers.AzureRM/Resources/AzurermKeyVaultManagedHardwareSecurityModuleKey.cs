using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock : TerraformBlock
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
        SetOutput("versioned_id");
        SetOutput("curve");
        SetOutput("expiration_date");
        SetOutput("id");
        SetOutput("key_opts");
        SetOutput("key_size");
        SetOutput("key_type");
        SetOutput("managed_hsm_id");
        SetOutput("name");
        SetOutput("not_before_date");
        SetOutput("tags");
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformProperty<string> Curve
    {
        get => GetRequiredOutput<TerraformProperty<string>>("curve");
        set => SetProperty("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string> ExpirationDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_date");
        set => SetProperty("expiration_date", value);
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
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    public HashSet<TerraformProperty<string>> KeyOpts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("key_opts");
        set => SetProperty("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformProperty<double> KeySize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("key_size");
        set => SetProperty("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformProperty<string> KeyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_type");
        set => SetProperty("key_type", value);
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmId is required")]
    public required TerraformProperty<string> ManagedHsmId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_id");
        set => SetProperty("managed_hsm_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformProperty<string> NotBeforeDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("not_before_date");
        set => SetProperty("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformExpression VersionedId => this["versioned_id"];

}
