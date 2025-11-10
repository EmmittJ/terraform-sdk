using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleActiveDirectoryDomainTrustTimeoutsBlock : TerraformBlock
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
/// Manages a google_active_directory_domain_trust resource.
/// </summary>
public class GoogleActiveDirectoryDomainTrust : TerraformResource
{
    public GoogleActiveDirectoryDomainTrust(string name) : base("google_active_directory_domain_trust", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("domain");
        SetOutput("id");
        SetOutput("project");
        SetOutput("selective_authentication");
        SetOutput("target_dns_ip_addresses");
        SetOutput("target_domain_name");
        SetOutput("trust_direction");
        SetOutput("trust_handshake_secret");
        SetOutput("trust_type");
    }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    public TerraformProperty<bool> SelectiveAuthentication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("selective_authentication");
        set => SetProperty("selective_authentication", value);
    }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDnsIpAddresses is required")]
    public HashSet<TerraformProperty<string>> TargetDnsIpAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("target_dns_ip_addresses");
        set => SetProperty("target_dns_ip_addresses", value);
    }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDomainName is required")]
    public required TerraformProperty<string> TargetDomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_domain_name");
        set => SetProperty("target_domain_name", value);
    }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    public required TerraformProperty<string> TrustDirection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trust_direction");
        set => SetProperty("trust_direction", value);
    }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustHandshakeSecret is required")]
    public required TerraformProperty<string> TrustHandshakeSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trust_handshake_secret");
        set => SetProperty("trust_handshake_secret", value);
    }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustType is required")]
    public required TerraformProperty<string> TrustType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trust_type");
        set => SetProperty("trust_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleActiveDirectoryDomainTrustTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
