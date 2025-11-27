using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in GoogleCertificateManagerCertificate.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateManagedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed";

    /// <summary>
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthorizationAttemptInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "authorization_attempt_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public TerraformList<string>? DnsAuthorizations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_authorizations").ResolveNodes(ctx));
        set => SetArgument("dns_authorizations", value);
    }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    public TerraformList<string>? Domains
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domains").ResolveNodes(ctx));
        set => SetArgument("domains", value);
    }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects/*/locations/*/certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    public TerraformValue<string>? IssuanceConfig
    {
        get => new TerraformReference<string>(this, "issuance_config");
        set => SetArgument("issuance_config", value);
    }

    /// <summary>
    /// Information about issues with provisioning this Managed Certificate.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProvisioningIssue
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "provisioning_issue").ResolveNodes(ctx));
    }

    /// <summary>
    /// A state of this Managed Certificate.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}


/// <summary>
/// Block type for self_managed in GoogleCertificateManagerCertificate.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerCertificateSelfManagedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed";

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? CertificatePem
    {
        get => new TerraformReference<string>(this, "certificate_pem");
        set => SetArgument("certificate_pem", value);
    }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// 
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    public TerraformValue<string>? PemCertificate
    {
        get => new TerraformReference<string>(this, "pem_certificate");
        set => SetArgument("pem_certificate", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    public TerraformValue<string>? PemPrivateKey
    {
        get => new TerraformReference<string>(this, "pem_private_key");
        set => SetArgument("pem_private_key", value);
    }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? PrivateKeyPem
    {
        get => new TerraformReference<string>(this, "private_key_pem");
        set => SetArgument("private_key_pem", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCertificateManagerCertificate.
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_certificate_manager_certificate Terraform resource.
/// Manages a google_certificate_manager_certificate resource.
/// </summary>
public partial class GoogleCertificateManagerCertificate(string name) : TerraformResource("google_certificate_manager_certificate", name)
{
    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A user-defined name of the certificate. Certificate names must be unique
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
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
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)
    /// </summary>
    public TerraformList<string> SanDnsnames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "san_dnsnames").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Managed block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    public TerraformList<GoogleCertificateManagerCertificateManagedBlock>? Managed
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerCertificateManagedBlock>>("managed");
        set => SetArgument("managed", value);
    }

    /// <summary>
    /// SelfManaged block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManaged block(s) allowed")]
    public TerraformList<GoogleCertificateManagerCertificateSelfManagedBlock>? SelfManaged
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerCertificateSelfManagedBlock>>("self_managed");
        set => SetArgument("self_managed", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCertificateManagerCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCertificateManagerCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
