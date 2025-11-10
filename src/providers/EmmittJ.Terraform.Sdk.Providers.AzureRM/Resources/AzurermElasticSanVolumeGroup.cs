using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The current_versioned_key_expiration_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("current_versioned_key_expiration_timestamp")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentVersionedKeyExpirationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>("", "current_versioned_key_expiration_timestamp");

    /// <summary>
    /// The current_versioned_key_id attribute.
    /// </summary>
    [TerraformPropertyName("current_versioned_key_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentVersionedKeyId => new TerraformReferenceProperty<TerraformProperty<string>>("", "current_versioned_key_id");

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformPropertyName("key_vault_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The last_key_rotation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("last_key_rotation_timestamp")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastKeyRotationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_key_rotation_timestamp");

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for network_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeGroupNetworkRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Action { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_elastic_san_volume_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSanVolumeGroup : TerraformResource
{
    public AzurermElasticSanVolumeGroup(string name) : base("azurerm_elastic_san_volume_group", name)
    {
    }

    /// <summary>
    /// The elastic_san_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticSanId is required")]
    [TerraformPropertyName("elastic_san_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ElasticSanId { get; set; }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformPropertyName("protocol_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProtocolType { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformPropertyName("encryption")]
    public TerraformList<TerraformBlock<AzurermElasticSanVolumeGroupEncryptionBlock>>? Encryption { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermElasticSanVolumeGroupIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for network_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_rule")]
    public TerraformList<TerraformBlock<AzurermElasticSanVolumeGroupNetworkRuleBlock>>? NetworkRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticSanVolumeGroupTimeoutsBlock>? Timeouts { get; set; } = new();

}
