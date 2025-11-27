using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleActiveDirectoryDomainTrust.
/// Nesting mode: single
/// </summary>
public class GoogleActiveDirectoryDomainTrustTimeoutsBlock : TerraformBlock
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
/// Represents a google_active_directory_domain_trust Terraform resource.
/// Manages a google_active_directory_domain_trust resource.
/// </summary>
public partial class GoogleActiveDirectoryDomainTrust(string name) : TerraformResource("google_active_directory_domain_trust", name)
{
    /// <summary>
    /// The fully qualified domain name. e.g. mydomain.myorganization.com, with the restrictions
    /// of https://cloud.google.com/managed-microsoft-ad/reference/rest/v1/projects.locations.global.domains.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Whether the trusted side has forest/domain wide access or selective access to an approved set of resources.
    /// </summary>
    public TerraformValue<bool>? SelectiveAuthentication
    {
        get => new TerraformReference<bool>(this, "selective_authentication");
        set => SetArgument("selective_authentication", value);
    }

    /// <summary>
    /// The target DNS server IP addresses which can resolve the remote domain involved in the trust.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDnsIpAddresses is required")]
    public required TerraformSet<string> TargetDnsIpAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "target_dns_ip_addresses").ResolveNodes(ctx));
        set => SetArgument("target_dns_ip_addresses", value);
    }

    /// <summary>
    /// The fully qualified target domain name which will be in trust with the current domain.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDomainName is required")]
    public required TerraformValue<string> TargetDomainName
    {
        get => new TerraformReference<string>(this, "target_domain_name");
        set => SetArgument("target_domain_name", value);
    }

    /// <summary>
    /// The trust direction, which decides if the current domain is trusted, trusting, or both. Possible values: [&amp;quot;INBOUND&amp;quot;, &amp;quot;OUTBOUND&amp;quot;, &amp;quot;BIDIRECTIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustDirection is required")]
    public required TerraformValue<string> TrustDirection
    {
        get => new TerraformReference<string>(this, "trust_direction");
        set => SetArgument("trust_direction", value);
    }

    /// <summary>
    /// The trust secret used for the handshake with the target domain. This will not be stored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustHandshakeSecret is required")]
    public required TerraformValue<string> TrustHandshakeSecret
    {
        get => new TerraformReference<string>(this, "trust_handshake_secret");
        set => SetArgument("trust_handshake_secret", value);
    }

    /// <summary>
    /// The type of trust represented by the trust resource. Possible values: [&amp;quot;FOREST&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustType is required")]
    public required TerraformValue<string> TrustType
    {
        get => new TerraformReference<string>(this, "trust_type");
        set => SetArgument("trust_type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleActiveDirectoryDomainTrustTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleActiveDirectoryDomainTrustTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
