using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_public_delegated_prefix resource.
/// </summary>
public class GoogleComputePublicDelegatedPrefix : TerraformResource
{
    public GoogleComputePublicDelegatedPrefix(string name) : base("google_compute_public_delegated_prefix", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("public_delegated_sub_prefixs");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The allocatable prefix length supported by this public delegated prefix. This field is optional and cannot be set for prefixes in DELEGATION mode. It cannot be set for IPv4 prefixes either, and it always defaults to 32.
    /// </summary>
    public double? AllocatablePrefixLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocatable_prefix_length")?.Value;
        set => this.WithProperty("allocatable_prefix_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The IP address range, in CIDR format, represented by this public delegated prefix.
    /// </summary>
    public string? IpCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_cidr_range")?.Value;
        set => this.WithProperty("ip_cidr_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, the prefix will be live migrated.
    /// </summary>
    public bool? IsLiveMigration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_live_migration")?.Value;
        set => this.WithProperty("is_live_migration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Specifies the mode of this IPv6 PDP. MODE must be one of: DELEGATION,
    /// EXTERNAL_IPV6_FORWARDING_RULE_CREATION and EXTERNAL_IPV6_SUBNETWORK_CREATION. Possible values: [&amp;quot;DELEGATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_FORWARDING_RULE_CREATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_SUBNETWORK_CREATION&amp;quot;]
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The URL of parent prefix. Either PublicAdvertisedPrefix or PublicDelegatedPrefix.
    /// </summary>
    public string? ParentPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_prefix")?.Value;
        set => this.WithProperty("parent_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A region where the prefix will reside.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of sub public delegated fixes for BYO IP functionality.
    /// Each item in this array represents a sub prefix that can be
    /// used to create addresses or further allocations.
    /// </summary>
    public TerraformExpression PublicDelegatedSubPrefixs => this["public_delegated_sub_prefixs"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
