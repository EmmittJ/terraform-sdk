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
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    public TerraformLiteralProperty<bool>? SelectiveAuthentication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("selective_authentication");
        set => this.WithProperty("selective_authentication", value);
    }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? TargetDnsIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_dns_ip_addresses");
        set => this.WithProperty("target_dns_ip_addresses", value);
    }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_domain_name");
        set => this.WithProperty("target_domain_name", value);
    }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? TrustDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_direction");
        set => this.WithProperty("trust_direction", value);
    }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    public TerraformLiteralProperty<string>? TrustHandshakeSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_handshake_secret");
        set => this.WithProperty("trust_handshake_secret", value);
    }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? TrustType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_type");
        set => this.WithProperty("trust_type", value);
    }

}
