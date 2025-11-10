using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsCryptoKeyTimeoutsBlock : ITerraformBlock
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
/// Block type for version_template in .
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyVersionTemplateBlock : ITerraformBlock
{
    /// <summary>
    /// The algorithm to use when creating a version based on this template.
    /// See the [algorithm reference](https://cloud.google.com/kms/docs/reference/rest/v1/CryptoKeyVersionAlgorithm) for possible inputs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformPropertyName("algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Algorithm { get; set; }

    /// <summary>
    /// The protection level to use when creating a version based on this template. Possible values include &amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_VPC&amp;quot;. Defaults to &amp;quot;SOFTWARE&amp;quot;.
    /// </summary>
    [TerraformPropertyName("protection_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProtectionLevel { get; set; }

}

/// <summary>
/// Manages a google_kms_crypto_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleKmsCryptoKey : TerraformResource
{
    public GoogleKmsCryptoKey(string name) : base("google_kms_crypto_key", name)
    {
    }

    /// <summary>
    /// The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey.
    /// The resource name is in the format &amp;quot;projects/*/locations/*/ekmConnections/*&amp;quot; and only applies to &amp;quot;EXTERNAL_VPC&amp;quot; keys.
    /// </summary>
    [TerraformPropertyName("crypto_key_backend")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CryptoKeyBackend { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "crypto_key_backend");

    /// <summary>
    /// The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED.
    /// If not specified at creation time, the default duration is 30 days.
    /// </summary>
    [TerraformPropertyName("destroy_scheduled_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DestroyScheduledDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destroy_scheduled_duration");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Whether this key may contain imported versions only.
    /// </summary>
    [TerraformPropertyName("import_only")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ImportOnly { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "import_only");

    /// <summary>
    /// The KeyRing that this key belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    [TerraformPropertyName("key_ring")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyRing { get; set; }

    /// <summary>
    /// Labels with user-defined metadata to apply to this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The resource name for the CryptoKey.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The immutable purpose of this CryptoKey. See the
    /// [purpose reference](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys#CryptoKeyPurpose)
    /// for possible inputs.
    /// Default value is &amp;quot;ENCRYPT_DECRYPT&amp;quot;.
    /// </summary>
    [TerraformPropertyName("purpose")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Purpose { get; set; }

    /// <summary>
    /// Every time this period passes, generate a new CryptoKeyVersion and set it as the primary.
    /// The first rotation will take place after the specified period. The rotation period has
    /// the format of a decimal number with up to 9 fractional digits, followed by the
    /// letter &#39;s&#39; (seconds). It must be greater than a day (ie, 86400).
    /// </summary>
    [TerraformPropertyName("rotation_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RotationPeriod { get; set; }

    /// <summary>
    /// If set to true, the request will create a CryptoKey without any CryptoKeyVersions.
    /// You must use the &#39;google_kms_crypto_key_version&#39; resource to create a new CryptoKeyVersion
    /// or &#39;google_kms_key_ring_import_job&#39; resource to import the CryptoKeyVersion.
    /// This field is only applicable during initial CryptoKey creation.
    /// </summary>
    [TerraformPropertyName("skip_initial_version_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipInitialVersionCreation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleKmsCryptoKeyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for version_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersionTemplate block(s) allowed")]
    [TerraformPropertyName("version_template")]
    public TerraformList<TerraformBlock<GoogleKmsCryptoKeyVersionTemplateBlock>>? VersionTemplate { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// A copy of the primary CryptoKeyVersion that will be used by cryptoKeys.encrypt when this CryptoKey is given in EncryptRequest.name.
    /// Keys with purpose ENCRYPT_DECRYPT may have a primary. For other keys, this field will be unset.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Primary => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "primary");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
