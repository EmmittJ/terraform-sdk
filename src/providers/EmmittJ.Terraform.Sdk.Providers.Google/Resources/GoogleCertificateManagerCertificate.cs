using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCertificateManagerCertificateManagedBlock() : TerraformBlock("managed")
{

    /// <summary>
    /// Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [TerraformProperty("dns_authorizations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DnsAuthorizations { get; set; }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    [TerraformProperty("domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Domains { get; set; }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [TerraformProperty("issuance_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IssuanceConfig { get; set; }



}

/// <summary>
/// Block type for self_managed in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCertificateManagerCertificateSelfManagedBlock() : TerraformBlock("self_managed")
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("certificate_pem")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePem { get; set; }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [TerraformProperty("pem_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PemCertificate { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [TerraformProperty("pem_private_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PemPrivateKey { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("private_key_pem")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKeyPem { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCertificateManagerCertificateTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_certificate_manager_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCertificateManagerCertificate : TerraformResource
{
    public GoogleCertificateManagerCertificate(string name) : base("google_certificate_manager_certificate", name)
    {
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// A user-defined name of the certificate. Certificate names must be unique
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The scope of the certificate.
    /// 
    /// DEFAULT: Certificates with default scope are served from core Google data centers.
    /// If unsure, choose this option.
    /// 
    /// EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence.
    /// See https://cloud.google.com/vpc/docs/edge-locations.
    /// 
    /// ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs).
    /// See https://cloud.google.com/compute/docs/regions-zones.
    /// 
    /// CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured.
    /// See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    [TerraformProperty("managed")]
    public TerraformList<GoogleCertificateManagerCertificateManagedBlock> Managed { get; set; } = new();

    /// <summary>
    /// Block for self_managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManaged block(s) allowed")]
    [TerraformProperty("self_managed")]
    public TerraformList<GoogleCertificateManagerCertificateSelfManagedBlock> SelfManaged { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleCertificateManagerCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)
    /// </summary>
    [TerraformProperty("san_dnsnames")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SanDnsnames { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
