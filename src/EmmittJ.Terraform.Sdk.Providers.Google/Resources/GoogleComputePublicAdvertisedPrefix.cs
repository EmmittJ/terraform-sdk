using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_public_advertised_prefix resource.
/// </summary>
public class GoogleComputePublicAdvertisedPrefix : TerraformResource
{
    public GoogleComputePublicAdvertisedPrefix(string name) : base("google_compute_public_advertised_prefix", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("self_link");
        this.DeclareOutput("shared_secret");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IPv4 address to be used for reverse DNS verification.
    /// </summary>
    public string? DnsVerificationIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_verification_ip")?.Value;
        set => this.WithProperty("dns_verification_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The address range, in CIDR format, represented by this public advertised prefix.
    /// </summary>
    public string? IpCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_cidr_range")?.Value;
        set => this.WithProperty("ip_cidr_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies how child public delegated prefix will be scoped. pdpScope
    /// must be one of: GLOBAL, REGIONAL
    /// * REGIONAL: The public delegated prefix is regional only. The
    /// provisioning will take a few minutes.
    /// * GLOBAL: The public delegated prefix is global only. The provisioning
    /// will take ~4 weeks. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    public string? PdpScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pdp_scope")?.Value;
        set => this.WithProperty("pdp_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Output Only. The shared secret to be used for reverse DNS verification.
    /// </summary>
    public TerraformExpression SharedSecret => this["shared_secret"];

}
