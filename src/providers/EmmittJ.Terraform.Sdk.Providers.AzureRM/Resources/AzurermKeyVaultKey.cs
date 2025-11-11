using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rotation_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultKeyRotationPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [TerraformProperty("expire_after")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpireAfter { get; set; }

    /// <summary>
    /// The notify_before_expiry attribute.
    /// </summary>
    [TerraformProperty("notify_before_expiry")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotifyBeforeExpiry { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultKeyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKeyVaultKey : TerraformResource
{
    public AzurermKeyVaultKey(string name) : base("azurerm_key_vault_key", name)
    {
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformProperty("curve")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Curve { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpirationDate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyOpts is required")]
    [TerraformProperty("key_opts")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? KeyOpts { get; set; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? KeySize { get; set; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformProperty("key_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyType { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    [TerraformProperty("not_before_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotBeforeDate { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for rotation_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationPolicy block(s) allowed")]
    [TerraformProperty("rotation_policy")]
    public TerraformList<TerraformBlock<AzurermKeyVaultKeyRotationPolicyBlock>>? RotationPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformProperty("e")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> E { get; }

    /// <summary>
    /// The n attribute.
    /// </summary>
    [TerraformProperty("n")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> N { get; }

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    [TerraformProperty("public_key_openssh")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKeyOpenssh { get; }

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformProperty("public_key_pem")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicKeyPem { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    [TerraformProperty("resource_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceVersionlessId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformProperty("versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionlessId { get; }

    /// <summary>
    /// The x attribute.
    /// </summary>
    [TerraformProperty("x")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> X { get; }

    /// <summary>
    /// The y attribute.
    /// </summary>
    [TerraformProperty("y")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Y { get; }

}
