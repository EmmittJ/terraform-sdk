using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsKeyRingImportJobTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_kms_key_ring_import_job resource.
/// </summary>
public partial class GoogleKmsKeyRingImportJob : TerraformResource
{
    public GoogleKmsKeyRingImportJob(string name) : base("google_kms_key_ring_import_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportJobId is required")]
    [TerraformProperty("import_job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImportJobId { get; set; }

    /// <summary>
    /// The wrapping method to be used for incoming key material. Possible values: [&amp;quot;RSA_OAEP_3072_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMethod is required")]
    [TerraformProperty("import_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImportMethod { get; set; }

    /// <summary>
    /// The KeyRing that this import job belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    [TerraformProperty("key_ring")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyRing { get; set; }

    /// <summary>
    /// The protection level of the ImportJob. This must match the protectionLevel of the
    /// versionTemplate on the CryptoKey you attempt to import into. Possible values: [&amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionLevel is required")]
    [TerraformProperty("protection_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtectionLevel { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleKmsKeyRingImportJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time.
    /// Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only present if the chosen ImportMethod is one with a protection level of HSM.
    /// </summary>
    [TerraformProperty("attestation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Attestation { get; }

    /// <summary>
    /// The time at which this resource is scheduled for expiration and can no longer be used.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The public key with which to wrap key material prior to import. Only returned if state is &#39;ACTIVE&#39;.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PublicKey { get; }

    /// <summary>
    /// The current state of the ImportJob, indicating if it can be used.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
