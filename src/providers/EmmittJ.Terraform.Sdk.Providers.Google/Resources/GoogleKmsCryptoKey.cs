using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsCryptoKeyTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for version_template in .
/// Nesting mode: list
/// </summary>
public partial class GoogleKmsCryptoKeyVersionTemplateBlock() : TerraformBlock("version_template")
{
    /// <summary>
    /// The algorithm to use when creating a version based on this template.
    /// See the [algorithm reference](https://cloud.google.com/kms/docs/reference/rest/v1/CryptoKeyVersionAlgorithm) for possible inputs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformProperty("algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Algorithm { get; set; }

    /// <summary>
    /// The protection level to use when creating a version based on this template. Possible values include &amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_VPC&amp;quot;. Defaults to &amp;quot;SOFTWARE&amp;quot;.
    /// </summary>
    [TerraformProperty("protection_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProtectionLevel { get; set; }

}

/// <summary>
/// Manages a google_kms_crypto_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleKmsCryptoKey : TerraformResource
{
    public GoogleKmsCryptoKey(string name) : base("google_kms_crypto_key", name)
    {
    }

    /// <summary>
    /// The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey.
    /// The resource name is in the format &amp;quot;projects/*/locations/*/ekmConnections/*&amp;quot; and only applies to &amp;quot;EXTERNAL_VPC&amp;quot; keys.
    /// </summary>
    [TerraformProperty("crypto_key_backend")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CryptoKeyBackend { get; set; }

    /// <summary>
    /// The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED.
    /// If not specified at creation time, the default duration is 30 days.
    /// </summary>
    [TerraformProperty("destroy_scheduled_duration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DestroyScheduledDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether this key may contain imported versions only.
    /// </summary>
    [TerraformProperty("import_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ImportOnly { get; set; }

    /// <summary>
    /// The KeyRing that this key belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    [TerraformProperty("key_ring")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyRing { get; set; }

    /// <summary>
    /// Labels with user-defined metadata to apply to this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The resource name for the CryptoKey.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The immutable purpose of this CryptoKey. See the
    /// [purpose reference](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys#CryptoKeyPurpose)
    /// for possible inputs.
    /// Default value is &amp;quot;ENCRYPT_DECRYPT&amp;quot;.
    /// </summary>
    [TerraformProperty("purpose")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Purpose { get; set; }

    /// <summary>
    /// Every time this period passes, generate a new CryptoKeyVersion and set it as the primary.
    /// The first rotation will take place after the specified period. The rotation period has
    /// the format of a decimal number with up to 9 fractional digits, followed by the
    /// letter &#39;s&#39; (seconds). It must be greater than a day (ie, 86400).
    /// </summary>
    [TerraformProperty("rotation_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RotationPeriod { get; set; }

    /// <summary>
    /// If set to true, the request will create a CryptoKey without any CryptoKeyVersions.
    /// You must use the &#39;google_kms_crypto_key_version&#39; resource to create a new CryptoKeyVersion
    /// or &#39;google_kms_key_ring_import_job&#39; resource to import the CryptoKeyVersion.
    /// This field is only applicable during initial CryptoKey creation.
    /// </summary>
    [TerraformProperty("skip_initial_version_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipInitialVersionCreation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleKmsCryptoKeyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for version_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersionTemplate block(s) allowed")]
    [TerraformProperty("version_template")]
    public TerraformList<GoogleKmsCryptoKeyVersionTemplateBlock> VersionTemplate { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// A copy of the primary CryptoKeyVersion that will be used by cryptoKeys.encrypt when this CryptoKey is given in EncryptRequest.name.
    /// Keys with purpose ENCRYPT_DECRYPT may have a primary. For other keys, this field will be unset.
    /// </summary>
    [TerraformProperty("primary")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Primary { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
