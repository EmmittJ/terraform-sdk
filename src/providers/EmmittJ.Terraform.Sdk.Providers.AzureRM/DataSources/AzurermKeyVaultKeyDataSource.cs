using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultKeyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Curve => new TerraformReference(this, "curve");

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformPropertyName("e")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> E => new TerraformReference(this, "e");

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformPropertyName("key_opts")]
    // Output-only attribute - read-only reference
    public TerraformList<string> KeyOpts => new TerraformReference(this, "key_opts");

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> KeySize => new TerraformReference(this, "key_size");

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformPropertyName("key_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyType => new TerraformReference(this, "key_type");

    /// <summary>
    /// The n attribute.
    /// </summary>
    [TerraformPropertyName("n")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> N => new TerraformReference(this, "n");

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    [TerraformPropertyName("public_key_openssh")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKeyOpenssh => new TerraformReference(this, "public_key_openssh");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformPropertyName("public_key_pem")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKeyPem => new TerraformReference(this, "public_key_pem");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceVersionlessId => new TerraformReference(this, "resource_versionless_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionlessId => new TerraformReference(this, "versionless_id");

    /// <summary>
    /// The x attribute.
    /// </summary>
    [TerraformPropertyName("x")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> X => new TerraformReference(this, "x");

    /// <summary>
    /// The y attribute.
    /// </summary>
    [TerraformPropertyName("y")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Y => new TerraformReference(this, "y");

}
