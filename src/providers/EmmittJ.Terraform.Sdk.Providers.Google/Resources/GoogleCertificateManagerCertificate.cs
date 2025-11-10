using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateManagedBlock : ITerraformBlock
{
    /// <summary>
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// </summary>
    [TerraformPropertyName("authorization_attempt_info")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthorizationAttemptInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "authorization_attempt_info");

    /// <summary>
    /// Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [TerraformPropertyName("dns_authorizations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsAuthorizations { get; set; }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    [TerraformPropertyName("domains")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Domains { get; set; }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [TerraformPropertyName("issuance_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IssuanceConfig { get; set; }

    /// <summary>
    /// Information about issues with provisioning this Managed Certificate.
    /// </summary>
    [TerraformPropertyName("provisioning_issue")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProvisioningIssue => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "provisioning_issue");

    /// <summary>
    /// A state of this Managed Certificate.
    /// </summary>
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

}

/// <summary>
/// Block type for self_managed in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateSelfManagedBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("certificate_pem")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificatePem { get; set; }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [TerraformPropertyName("pem_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PemCertificate { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [TerraformPropertyName("pem_private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PemPrivateKey { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("private_key_pem")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKeyPem { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateTimeoutsBlock : ITerraformBlock
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
/// Manages a google_certificate_manager_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCertificateManagerCertificate : TerraformResource
{
    public GoogleCertificateManagerCertificate(string name) : base("google_certificate_manager_certificate", name)
    {
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// A user-defined name of the certificate. Certificate names must be unique
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

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
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    [TerraformPropertyName("managed")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerCertificateManagedBlock>>? Managed { get; set; } = new();

    /// <summary>
    /// Block for self_managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManaged block(s) allowed")]
    [TerraformPropertyName("self_managed")]
    public TerraformList<TerraformBlock<GoogleCertificateManagerCertificateSelfManagedBlock>>? SelfManaged { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCertificateManagerCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)
    /// </summary>
    [TerraformPropertyName("san_dnsnames")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SanDnsnames => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "san_dnsnames");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
