using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    }

    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    public TerraformProperty<bool>? SelectiveAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("selective_authentication");
        set => this.WithProperty("selective_authentication", value);
    }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TargetDnsIpAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("target_dns_ip_addresses");
        set => this.WithProperty("target_dns_ip_addresses", value);
    }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    public TerraformProperty<string>? TargetDomainName
    {
        get => GetProperty<TerraformProperty<string>>("target_domain_name");
        set => this.WithProperty("target_domain_name", value);
    }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TrustDirection
    {
        get => GetProperty<TerraformProperty<string>>("trust_direction");
        set => this.WithProperty("trust_direction", value);
    }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    public TerraformProperty<string>? TrustHandshakeSecret
    {
        get => GetProperty<TerraformProperty<string>>("trust_handshake_secret");
        set => this.WithProperty("trust_handshake_secret", value);
    }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TrustType
    {
        get => GetProperty<TerraformProperty<string>>("trust_type");
        set => this.WithProperty("trust_type", value);
    }

}
