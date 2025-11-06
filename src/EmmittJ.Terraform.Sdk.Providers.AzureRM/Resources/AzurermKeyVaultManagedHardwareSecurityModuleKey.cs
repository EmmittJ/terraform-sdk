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
    public string? Curve
    {
        get => GetProperty<TerraformLiteralProperty<string>>("curve")?.Value;
        set => this.WithProperty("curve", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public string? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date")?.Value;
        set => this.WithProperty("expiration_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_opts attribute.
    /// </summary>
    public HashSet<string>? KeyOpts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("key_opts")?.Value;
        set => this.WithProperty("key_opts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public double? KeySize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("key_size")?.Value;
        set => this.WithProperty("key_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public string? KeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_type")?.Value;
        set => this.WithProperty("key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The not_before_date attribute.
    /// </summary>
    public string? NotBeforeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("not_before_date")?.Value;
        set => this.WithProperty("not_before_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The versioned_id attribute.
    /// </summary>
    public TerraformExpression VersionedId => this["versioned_id"];

}
