using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivatecaCertificateConfigBlock() : TerraformBlock("config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePrivatecaCertificateTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_privateca_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePrivatecaCertificate : TerraformResource
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
    [TerraformProperty("certificate_authority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateAuthority { get; set; }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    [TerraformProperty("certificate_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateTemplate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("lifetime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Lifetime { get; set; }

    /// <summary>
    /// Location of the Certificate. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name for this Certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Immutable. A pem-encoded X.509 certificate signing request (CSR).
    /// </summary>
    [TerraformProperty("pem_csr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PemCsr { get; set; }

    /// <summary>
    /// The name of the CaPool this Certificate belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    [TerraformProperty("pool")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Pool { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public TerraformList<GooglePrivatecaCertificateConfigBlock> Config { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GooglePrivatecaCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
    /// </summary>
    [TerraformProperty("certificate_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertificateDescription { get; }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource name of the issuing CertificateAuthority in the format &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    [TerraformProperty("issuer_certificate_authority")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IssuerCertificateAuthority { get; }

    /// <summary>
    /// Output only. The pem-encoded, signed X.509 certificate.
    /// </summary>
    [TerraformProperty("pem_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PemCertificate { get; }

    /// <summary>
    /// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
    /// </summary>
    [TerraformProperty("pem_certificate_chain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PemCertificateChain { get; }

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is
    /// considered revoked if and only if this field is present.
    /// </summary>
    [TerraformProperty("revocation_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RevocationDetails { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The time at which this CertificateAuthority was updated.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
