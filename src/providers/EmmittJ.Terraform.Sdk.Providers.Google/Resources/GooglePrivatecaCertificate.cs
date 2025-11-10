using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateTimeoutsBlock : ITerraformBlock
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
/// Manages a google_privateca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivatecaCertificate : TerraformResource
{
    public GooglePrivatecaCertificate(string name) : base("google_privateca_certificate", name)
    {
    }

    /// <summary>
    /// The Certificate Authority ID that should issue the certificate. For example, to issue a Certificate from
    /// a Certificate Authority with resource name &#39;projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca&#39;,
    /// argument &#39;pool&#39; should be set to &#39;projects/my-project/locations/us-central1/caPools/my-pool&#39;, argument &#39;certificate_authority&#39;
    /// should be set to &#39;my-ca&#39;.
    /// </summary>
    [TerraformPropertyName("certificate_authority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateAuthority { get; set; }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    [TerraformPropertyName("certificate_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateTemplate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Lifetime { get; set; }

    /// <summary>
    /// Location of the Certificate. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name for this Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Immutable. A pem-encoded X.509 certificate signing request (CSR).
    /// </summary>
    [TerraformPropertyName("pem_csr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PemCsr { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    [TerraformPropertyName("pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GooglePrivatecaCertificateConfigBlock>>? Config { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePrivatecaCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
    /// </summary>
    [TerraformPropertyName("certificate_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificateDescription => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_description");

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The resource name of the issuing CertificateAuthority in the format &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    [TerraformPropertyName("issuer_certificate_authority")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IssuerCertificateAuthority => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "issuer_certificate_authority");

    /// <summary>
    /// Output only. The pem-encoded, signed X.509 certificate.
    /// </summary>
    [TerraformPropertyName("pem_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PemCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pem_certificate");

    /// <summary>
    /// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
    /// </summary>
    [TerraformPropertyName("pem_certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PemCertificateChain => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "pem_certificate_chain");

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is
    /// considered revoked if and only if this field is present.
    /// </summary>
    [TerraformPropertyName("revocation_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RevocationDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "revocation_details");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. The time at which this CertificateAuthority was updated.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
