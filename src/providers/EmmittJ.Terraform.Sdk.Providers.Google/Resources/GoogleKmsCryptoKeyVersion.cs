using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_protection_level_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The path to the external key material on the EKM when using EkmConnection e.g., &amp;quot;v0/my/key&amp;quot;. Set this field instead of externalKeyUri when using an EkmConnection.
    /// </summary>
    [TerraformProperty("ekm_connection_key_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EkmConnectionKeyPath { get; set; }

    /// <summary>
    /// The URI for an external resource that this CryptoKeyVersion represents.
    /// </summary>
    [TerraformProperty("external_key_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExternalKeyUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsCryptoKeyVersionTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_kms_crypto_key_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleKmsCryptoKeyVersion : TerraformResource
{
    public GoogleKmsCryptoKeyVersion(string name) : base("google_kms_crypto_key_version", name)
    {
    }

    /// <summary>
    /// The name of the cryptoKey associated with the CryptoKeyVersions.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyring}}/cryptoKeys/{{cryptoKey}}&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [TerraformProperty("crypto_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CryptoKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The current state of the CryptoKeyVersion. Note: you can only specify this field to manually &#39;ENABLE&#39; or &#39;DISABLE&#39; the CryptoKeyVersion,
    /// otherwise the value of this field is always retrieved automatically. Possible values: [&amp;quot;PENDING_GENERATION&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;DESTROYED&amp;quot;, &amp;quot;DESTROY_SCHEDULED&amp;quot;, &amp;quot;PENDING_IMPORT&amp;quot;, &amp;quot;IMPORT_FAILED&amp;quot;]
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> State { get; set; }

    /// <summary>
    /// Block for external_protection_level_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalProtectionLevelOptions block(s) allowed")]
    [TerraformProperty("external_protection_level_options")]
    public TerraformList<TerraformBlock<GoogleKmsCryptoKeyVersionExternalProtectionLevelOptionsBlock>>? ExternalProtectionLevelOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleKmsCryptoKeyVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.
    /// </summary>
    [TerraformProperty("algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Algorithm { get; }

    /// <summary>
    /// Statement that was generated and signed by the HSM at key creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only provided for key versions with protectionLevel HSM.
    /// </summary>
    [TerraformProperty("attestation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Attestation { get; }

    /// <summary>
    /// The time this CryptoKeyVersion key material was generated
    /// </summary>
    [TerraformProperty("generate_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GenerateTime { get; }

    /// <summary>
    /// The resource name for this CryptoKeyVersion.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
    /// </summary>
    [TerraformProperty("protection_level")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProtectionLevel { get; }

}
