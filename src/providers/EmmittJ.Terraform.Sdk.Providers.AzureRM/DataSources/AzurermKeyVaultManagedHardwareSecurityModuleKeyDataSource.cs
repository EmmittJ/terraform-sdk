using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module_key.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("curve");
        SetOutput("expiration_date");
        SetOutput("key_opts");
        SetOutput("key_size");
        SetOutput("key_type");
        SetOutput("not_before_date");
        SetOutput("tags");
        SetOutput("version");
        SetOutput("versioned_id");
        SetOutput("id");
        SetOutput("managed_hsm_id");
        SetOutput("name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformExpression Curve => this["curve"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformExpression KeyOpts => this["key_opts"];

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformExpression KeySize => this["key_size"];

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformExpression KeyType => this["key_type"];

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformExpression NotBeforeDate => this["not_before_date"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformExpression VersionedId => this["versioned_id"];

}
