using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("curve");
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("key_opts");
        this.DeclareOutput("key_size");
        this.DeclareOutput("key_type");
        this.DeclareOutput("not_before_date");
        this.DeclareOutput("tags");
        this.DeclareOutput("version");
        this.DeclareOutput("versioned_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_hsm_id attribute.
    /// </summary>
    public string? ManagedHsmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_id")?.Value;
        set => this.WithProperty("managed_hsm_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
