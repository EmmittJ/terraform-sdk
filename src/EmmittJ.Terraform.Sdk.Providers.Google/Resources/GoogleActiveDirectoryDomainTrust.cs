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
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    public bool? SelectiveAuthentication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("selective_authentication")?.Value;
        set => this.WithProperty("selective_authentication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    public HashSet<string>? TargetDnsIpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_dns_ip_addresses")?.Value;
        set => this.WithProperty("target_dns_ip_addresses", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    public string? TargetDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_domain_name")?.Value;
        set => this.WithProperty("target_domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    public string? TrustDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_direction")?.Value;
        set => this.WithProperty("trust_direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    public string? TrustHandshakeSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_handshake_secret")?.Value;
        set => this.WithProperty("trust_handshake_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public string? TrustType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_type")?.Value;
        set => this.WithProperty("trust_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
