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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<string>>("algorithm");
        set => WithProperty("algorithm", value);
    }

    /// <summary>
    /// The protection level to use when creating a version based on this template. Possible values include &amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_VPC&amp;quot;. Defaults to &amp;quot;SOFTWARE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ProtectionLevel
    {
        get => GetProperty<TerraformProperty<string>>("protection_level");
        set => WithProperty("protection_level", value);
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
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("primary");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The resource name of the backend environment associated with all CryptoKeyVersions within this CryptoKey.
    /// The resource name is in the format &amp;quot;projects/*/locations/*/ekmConnections/*&amp;quot; and only applies to &amp;quot;EXTERNAL_VPC&amp;quot; keys.
    /// </summary>
    public TerraformProperty<string>? CryptoKeyBackend
    {
        get => GetProperty<TerraformProperty<string>>("crypto_key_backend");
        set => this.WithProperty("crypto_key_backend", value);
    }

    /// <summary>
    /// The period of time that versions of this key spend in the DESTROY_SCHEDULED state before transitioning to DESTROYED.
    /// If not specified at creation time, the default duration is 30 days.
    /// </summary>
    public TerraformProperty<string>? DestroyScheduledDuration
    {
        get => GetProperty<TerraformProperty<string>>("destroy_scheduled_duration");
        set => this.WithProperty("destroy_scheduled_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Whether this key may contain imported versions only.
    /// </summary>
    public TerraformProperty<bool>? ImportOnly
    {
        get => GetProperty<TerraformProperty<bool>>("import_only");
        set => this.WithProperty("import_only", value);
    }

    /// <summary>
    /// The KeyRing that this key belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    public required TerraformProperty<string> KeyRing
    {
        get => GetProperty<TerraformProperty<string>>("key_ring");
        set => this.WithProperty("key_ring", value);
    }

    /// <summary>
    /// Labels with user-defined metadata to apply to this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name for the CryptoKey.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The immutable purpose of this CryptoKey. See the
    /// [purpose reference](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys#CryptoKeyPurpose)
    /// for possible inputs.
    /// Default value is &amp;quot;ENCRYPT_DECRYPT&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// Every time this period passes, generate a new CryptoKeyVersion and set it as the primary.
    /// The first rotation will take place after the specified period. The rotation period has
    /// the format of a decimal number with up to 9 fractional digits, followed by the
    /// letter &#39;s&#39; (seconds). It must be greater than a day (ie, 86400).
    /// </summary>
    public TerraformProperty<string>? RotationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("rotation_period");
        set => this.WithProperty("rotation_period", value);
    }

    /// <summary>
    /// If set to true, the request will create a CryptoKey without any CryptoKeyVersions.
    /// You must use the &#39;google_kms_crypto_key_version&#39; resource to create a new CryptoKeyVersion
    /// or &#39;google_kms_key_ring_import_job&#39; resource to import the CryptoKeyVersion.
    /// This field is only applicable during initial CryptoKey creation.
    /// </summary>
    public TerraformProperty<bool>? SkipInitialVersionCreation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_initial_version_creation");
        set => this.WithProperty("skip_initial_version_creation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleKmsCryptoKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleKmsCryptoKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for version_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersionTemplate block(s) allowed")]
    public List<GoogleKmsCryptoKeyVersionTemplateBlock>? VersionTemplate
    {
        get => GetProperty<List<GoogleKmsCryptoKeyVersionTemplateBlock>>("version_template");
        set => this.WithProperty("version_template", value);
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
