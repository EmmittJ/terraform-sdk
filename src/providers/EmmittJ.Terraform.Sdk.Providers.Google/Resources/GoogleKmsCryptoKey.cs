using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleKmsCryptoKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for version_template in .
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyVersionTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The algorithm to use when creating a version based on this template.
    /// See the [algorithm reference](https://cloud.google.com/kms/docs/reference/rest/v1/CryptoKeyVersionAlgorithm) for possible inputs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformProperty<string> Algorithm
    {
        set => SetProperty("algorithm", value);
    }

    /// <summary>
    /// The protection level to use when creating a version based on this template. Possible values include &amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_VPC&amp;quot;. Defaults to &amp;quot;SOFTWARE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ProtectionLevel
    {
        set => SetProperty("protection_level", value);
    }

}

/// <summary>
/// Manages a google_kms_crypto_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleKmsCryptoKey : TerraformResource
{
    public GoogleKmsCryptoKey(string name) : base("google_kms_crypto_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("primary");
        SetOutput("terraform_labels");
        SetOutput("crypto_key_backend");
        SetOutput("destroy_scheduled_duration");
        SetOutput("id");
        SetOutput("import_only");
        SetOutput("key_ring");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("purpose");
        SetOutput("rotation_period");
        SetOutput("skip_initial_version_creation");
    }

    /// <summary>
    /// The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey.
    /// The resource name is in the format &amp;quot;projects/*/locations/*/ekmConnections/*&amp;quot; and only applies to &amp;quot;EXTERNAL_VPC&amp;quot; keys.
    /// </summary>
    public TerraformProperty<string> CryptoKeyBackend
    {
        get => GetRequiredOutput<TerraformProperty<string>>("crypto_key_backend");
        set => SetProperty("crypto_key_backend", value);
    }

    /// <summary>
    /// The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED.
    /// If not specified at creation time, the default duration is 30 days.
    /// </summary>
    public TerraformProperty<string> DestroyScheduledDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destroy_scheduled_duration");
        set => SetProperty("destroy_scheduled_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Whether this key may contain imported versions only.
    /// </summary>
    public TerraformProperty<bool> ImportOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("import_only");
        set => SetProperty("import_only", value);
    }

    /// <summary>
    /// The KeyRing that this key belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    public required TerraformProperty<string> KeyRing
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_ring");
        set => SetProperty("key_ring", value);
    }

    /// <summary>
    /// Labels with user-defined metadata to apply to this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The resource name for the CryptoKey.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The immutable purpose of this CryptoKey. See the
    /// [purpose reference](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys#CryptoKeyPurpose)
    /// for possible inputs.
    /// Default value is &amp;quot;ENCRYPT_DECRYPT&amp;quot;.
    /// </summary>
    public TerraformProperty<string> Purpose
    {
        get => GetRequiredOutput<TerraformProperty<string>>("purpose");
        set => SetProperty("purpose", value);
    }

    /// <summary>
    /// Every time this period passes, generate a new CryptoKeyVersion and set it as the primary.
    /// The first rotation will take place after the specified period. The rotation period has
    /// the format of a decimal number with up to 9 fractional digits, followed by the
    /// letter &#39;s&#39; (seconds). It must be greater than a day (ie, 86400).
    /// </summary>
    public TerraformProperty<string> RotationPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rotation_period");
        set => SetProperty("rotation_period", value);
    }

    /// <summary>
    /// If set to true, the request will create a CryptoKey without any CryptoKeyVersions.
    /// You must use the &#39;google_kms_crypto_key_version&#39; resource to create a new CryptoKeyVersion
    /// or &#39;google_kms_key_ring_import_job&#39; resource to import the CryptoKeyVersion.
    /// This field is only applicable during initial CryptoKey creation.
    /// </summary>
    public TerraformProperty<bool> SkipInitialVersionCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_initial_version_creation");
        set => SetProperty("skip_initial_version_creation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsCryptoKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for version_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersionTemplate block(s) allowed")]
    public List<GoogleKmsCryptoKeyVersionTemplateBlock>? VersionTemplate
    {
        set => SetProperty("version_template", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A copy of the primary CryptoKeyVersion that will be used by cryptoKeys.encrypt when this CryptoKey is given in EncryptRequest.name.
    /// Keys with purpose ENCRYPT_DECRYPT may have a primary. For other keys, this field will be unset.
    /// </summary>
    public TerraformExpression Primary => this["primary"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
