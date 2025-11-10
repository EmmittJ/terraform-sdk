using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateManagedBlock : TerraformBlock
{
    /// <summary>
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// </summary>
    public List<TerraformProperty<object>>? AuthorizationAttemptInfo
    {
        set => SetProperty("authorization_attempt_info", value);
    }

    /// <summary>
    /// Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public List<TerraformProperty<string>>? DnsAuthorizations
    {
        set => SetProperty("dns_authorizations", value);
    }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    public List<TerraformProperty<string>>? Domains
    {
        set => SetProperty("domains", value);
    }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public TerraformProperty<string>? IssuanceConfig
    {
        set => SetProperty("issuance_config", value);
    }

    /// <summary>
    /// Information about issues with provisioning this Managed Certificate.
    /// </summary>
    public List<TerraformProperty<object>>? ProvisioningIssue
    {
        set => SetProperty("provisioning_issue", value);
    }

    /// <summary>
    /// A state of this Managed Certificate.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for self_managed in .
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateSelfManagedBlock : TerraformBlock
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? CertificatePem
    {
        set => SetProperty("certificate_pem", value);
    }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    public TerraformProperty<string>? PemCertificate
    {
        set => SetProperty("pem_certificate", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    public TerraformProperty<string>? PemPrivateKey
    {
        set => SetProperty("pem_private_key", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? PrivateKeyPem
    {
        set => SetProperty("private_key_pem", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateTimeoutsBlock : TerraformBlock
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
/// Manages a google_certificate_manager_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCertificateManagerCertificate : TerraformResource
{
    public GoogleCertificateManagerCertificate(string name) : base("google_certificate_manager_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("san_dnsnames");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("scope");
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Set of label tags associated with the Certificate resource.
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
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// A user-defined name of the certificate. Certificate names must be unique
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

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
    public TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    public List<GoogleCertificateManagerCertificateManagedBlock>? Managed
    {
        set => SetProperty("managed", value);
    }

    /// <summary>
    /// Block for self_managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManaged block(s) allowed")]
    public List<GoogleCertificateManagerCertificateSelfManagedBlock>? SelfManaged
    {
        set => SetProperty("self_managed", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCertificateManagerCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)
    /// </summary>
    public TerraformExpression SanDnsnames => this["san_dnsnames"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
