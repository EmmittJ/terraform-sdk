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
        get => GetProperty<List<TerraformProperty<object>>>("authorization_attempt_info");
        set => WithProperty("authorization_attempt_info", value);
    }

    /// <summary>
    /// Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public List<TerraformProperty<string>>? DnsAuthorizations
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_authorizations");
        set => WithProperty("dns_authorizations", value);
    }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    public List<TerraformProperty<string>>? Domains
    {
        get => GetProperty<List<TerraformProperty<string>>>("domains");
        set => WithProperty("domains", value);
    }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public TerraformProperty<string>? IssuanceConfig
    {
        get => GetProperty<TerraformProperty<string>>("issuance_config");
        set => WithProperty("issuance_config", value);
    }

    /// <summary>
    /// Information about issues with provisioning this Managed Certificate.
    /// </summary>
    public List<TerraformProperty<object>>? ProvisioningIssue
    {
        get => GetProperty<List<TerraformProperty<object>>>("provisioning_issue");
        set => WithProperty("provisioning_issue", value);
    }

    /// <summary>
    /// A state of this Managed Certificate.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
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
        get => GetProperty<TerraformProperty<string>>("certificate_pem");
        set => WithProperty("certificate_pem", value);
    }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    public TerraformProperty<string>? PemCertificate
    {
        get => GetProperty<TerraformProperty<string>>("pem_certificate");
        set => WithProperty("pem_certificate", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    public TerraformProperty<string>? PemPrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("pem_private_key");
        set => WithProperty("pem_private_key", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? PrivateKeyPem
    {
        get => GetProperty<TerraformProperty<string>>("private_key_pem");
        set => WithProperty("private_key_pem", value);
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
/// Manages a google_certificate_manager_certificate resource.
/// </summary>
public class GoogleCertificateManagerCertificate : TerraformResource
{
    public GoogleCertificateManagerCertificate(string name) : base("google_certificate_manager_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("san_dnsnames");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Set of label tags associated with the Certificate resource.
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
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// A user-defined name of the certificate. Certificate names must be unique
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    public List<GoogleCertificateManagerCertificateManagedBlock>? Managed
    {
        get => GetProperty<List<GoogleCertificateManagerCertificateManagedBlock>>("managed");
        set => this.WithProperty("managed", value);
    }

    /// <summary>
    /// Block for self_managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManaged block(s) allowed")]
    public List<GoogleCertificateManagerCertificateSelfManagedBlock>? SelfManaged
    {
        get => GetProperty<List<GoogleCertificateManagerCertificateSelfManagedBlock>>("self_managed");
        set => this.WithProperty("self_managed", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCertificateManagerCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCertificateManagerCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
