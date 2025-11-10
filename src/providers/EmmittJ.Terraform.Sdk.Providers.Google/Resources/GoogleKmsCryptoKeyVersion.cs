using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_protection_level_options in .
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The path to the external key material on the EKM when using EkmConnection e.g., &amp;quot;v0/my/key&amp;quot;. Set this field instead of externalKeyUri when using an EkmConnection.
    /// </summary>
    [TerraformPropertyName("ekm_connection_key_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EkmConnectionKeyPath { get; set; }

    /// <summary>
    /// The URI for an external resource that this CryptoKeyVersion represents.
    /// </summary>
    [TerraformPropertyName("external_key_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExternalKeyUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsCryptoKeyVersionTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_kms_crypto_key_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleKmsCryptoKeyVersion : TerraformResource
{
    public GoogleKmsCryptoKeyVersion(string name) : base("google_kms_crypto_key_version", name)
    {
    }

    /// <summary>
    /// The name of the cryptoKey associated with the CryptoKeyVersions.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformPropertyName("crypto_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The current state of the CryptoKeyVersion. Note: you can only specify this field to manually &#39;ENABLE&#39; or &#39;DISABLE&#39; the CryptoKeyVersion,
    /// otherwise the value of this field is always retrieved automatically. Possible values: [&amp;quot;PENDING_GENERATION&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DESTROYED&amp;quot;, &amp;quot;DESTROY_SCHEDULED&amp;quot;, &amp;quot;PENDING_IMPORT&amp;quot;, &amp;quot;IMPORT_FAILED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Block for external_protection_level_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalProtectionLevelOptions block(s) allowed")]
    [TerraformPropertyName("external_protection_level_options")]
    public TerraformList<TerraformBlock<GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock>>? ExternalProtectionLevelOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleKmsCryptoKeyVersionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.
    /// </summary>
    [TerraformPropertyName("algorithm")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Algorithm => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "algorithm");

    /// <summary>
    /// Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only provided for key versions with protectionLevel HSM.
    /// </summary>
    [TerraformPropertyName("attestation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Attestation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "attestation");

    /// <summary>
    /// The time this CryptoKeyVersion key material was generated
    /// </summary>
    [TerraformPropertyName("generate_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GenerateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generate_time");

    /// <summary>
    /// The resource name for this CryptoKeyVersion.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
    /// </summary>
    [TerraformPropertyName("protection_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtectionLevel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protection_level");

}
