using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rotation_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultKeyRotationPolicyBlock
{
    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [TerraformPropertyName("expire_after")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpireAfter { get; set; }

    /// <summary>
    /// The notify_before_expiry attribute.
    /// </summary>
    [TerraformPropertyName("notify_before_expiry")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotifyBeforeExpiry { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultKeyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVaultKey : TerraformResource
{
    public AzurermKeyVaultKey(string name) : base("azurerm_key_vault_key", name)
    {
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformPropertyName("curve")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Curve { get; set; } = default!;

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpirationDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    [TerraformPropertyName("key_opts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? KeyOpts { get; set; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? KeySize { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformPropertyName("key_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyType { get; set; }

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
    /// The not_before_date attribute.
    /// </summary>
    [TerraformPropertyName("not_before_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotBeforeDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for rotation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationPolicy block(s) allowed")]
    [TerraformPropertyName("rotation_policy")]
    public TerraformList<TerraformBlock<AzurermKeyVaultKeyRotationPolicyBlock>>? RotationPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformPropertyName("e")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> E => new TerraformReference(this, "e");

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
