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
    public TerraformProperty<double>? AllocatablePrefixLength
    {
        get => GetProperty<TerraformProperty<double>>("allocatable_prefix_length");
        set => this.WithProperty("allocatable_prefix_length", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// The IP address range, in CIDR format, represented by this public delegated prefix.
    /// </summary>
    public TerraformProperty<string>? IpCidrRange
    {
        get => GetProperty<TerraformProperty<string>>("ip_cidr_range");
        set => this.WithProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// If true, the prefix will be live migrated.
    /// </summary>
    public TerraformProperty<bool>? IsLiveMigration
    {
        get => GetProperty<TerraformProperty<bool>>("is_live_migration");
        set => this.WithProperty("is_live_migration", value);
    }

    /// <summary>
    /// Specifies the mode of this IPv6 PDP. MODE must be one of: DELEGATION,
    /// EXTERNAL_IPV6_FORWARDING_RULE_CREATION and EXTERNAL_IPV6_SUBNETWORK_CREATION. Possible values: [&amp;quot;DELEGATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_FORWARDING_RULE_CREATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_SUBNETWORK_CREATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of parent prefix. Either PublicAdvertisedPrefix or PublicDelegatedPrefix.
    /// </summary>
    public TerraformProperty<string>? ParentPrefix
    {
        get => GetProperty<TerraformProperty<string>>("parent_prefix");
        set => this.WithProperty("parent_prefix", value);
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
    /// A region where the prefix will reside.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
