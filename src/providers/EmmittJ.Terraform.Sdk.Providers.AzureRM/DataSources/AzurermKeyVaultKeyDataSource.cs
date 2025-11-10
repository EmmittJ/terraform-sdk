using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public class AzurermKeyVaultKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultKeyDataSource(string name) : base("azurerm_key_vault_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultKeyDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Curve => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "curve");

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformPropertyName("e")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> E => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "e");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformPropertyName("key_opts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> KeyOpts => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> KeySize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_type");

    /// <summary>
    /// The n attribute.
    /// </summary>
    [TerraformPropertyName("n")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> N => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "n");

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    [TerraformPropertyName("public_key_openssh")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKeyOpenssh => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key_openssh");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformPropertyName("public_key_pem")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicKeyPem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key_pem");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceVersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_versionless_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versionless_id");

    /// <summary>
    /// The x attribute.
    /// </summary>
    [TerraformPropertyName("x")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> X => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "x");

    /// <summary>
    /// The y attribute.
    /// </summary>
    [TerraformPropertyName("y")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Y => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "y");

}
