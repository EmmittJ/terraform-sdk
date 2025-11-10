using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsKeyRingImportJobTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_kms_key_ring_import_job resource.
/// </summary>
public class GoogleKmsKeyRingImportJob : TerraformResource
{
    public GoogleKmsKeyRingImportJob(string name) : base("google_kms_key_ring_import_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportJobId is required")]
    [TerraformPropertyName("import_job_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImportJobId { get; set; }

    /// <summary>
    /// The wrapping method to be used for incoming key material. Possible values: [&amp;quot;RSA_OAEP_3072_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMethod is required")]
    [TerraformPropertyName("import_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImportMethod { get; set; }

    /// <summary>
    /// The KeyRing that this import job belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    [TerraformPropertyName("key_ring")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyRing { get; set; }

    /// <summary>
    /// The protection level of the ImportJob. This must match the protectionLevel of the
    /// versionTemplate on the CryptoKey you attempt to import into. Possible values: [&amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionLevel is required")]
    [TerraformPropertyName("protection_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProtectionLevel { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleKmsKeyRingImportJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time.
    /// Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only present if the chosen ImportMethod is one with a protection level of HSM.
    /// </summary>
    [TerraformPropertyName("attestation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Attestation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "attestation");

    /// <summary>
    /// The time at which this resource is scheduled for expiration and can no longer be used.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpireTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expire_time");

    /// <summary>
    /// The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The public key with which to wrap key material prior to import. Only returned if state is &#39;ACTIVE&#39;.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PublicKey => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "public_key");

    /// <summary>
    /// The current state of the ImportJob, indicating if it can be used.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
