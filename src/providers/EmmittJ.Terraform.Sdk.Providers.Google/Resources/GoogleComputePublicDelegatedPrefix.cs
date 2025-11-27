using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputePublicDelegatedPrefix.
/// Nesting mode: single
/// </summary>
public class GoogleComputePublicDelegatedPrefixTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_public_delegated_prefix Terraform resource.
/// Manages a google_compute_public_delegated_prefix resource.
/// </summary>
public partial class GoogleComputePublicDelegatedPrefix(string name) : TerraformResource("google_compute_public_delegated_prefix", name)
{
    /// <summary>
    /// The allocatable prefix length supported by this public delegated prefix. This field is optional and cannot be set for prefixes in DELEGATION mode. It cannot be set for IPv4 prefixes either, and it always defaults to 32.
    /// </summary>
    public TerraformValue<double> AllocatablePrefixLength
    {
        get => new TerraformReference<double>(this, "allocatable_prefix_length");
        set => SetArgument("allocatable_prefix_length", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// The IP address range, in CIDR format, represented by this public delegated prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    public required TerraformValue<string> IpCidrRange
    {
        get => new TerraformReference<string>(this, "ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// If true, the prefix will be live migrated.
    /// </summary>
    public TerraformValue<bool>? IsLiveMigration
    {
        get => new TerraformReference<bool>(this, "is_live_migration");
        set => SetArgument("is_live_migration", value);
    }

    /// <summary>
    /// Specifies the mode of this IPv6 PDP. MODE must be one of: DELEGATION,
    /// EXTERNAL_IPV6_FORWARDING_RULE_CREATION and EXTERNAL_IPV6_SUBNETWORK_CREATION. Possible values: [&amp;quot;DELEGATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_FORWARDING_RULE_CREATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_SUBNETWORK_CREATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The URL of parent prefix. Either PublicAdvertisedPrefix or PublicDelegatedPrefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentPrefix is required")]
    public required TerraformValue<string> ParentPrefix
    {
        get => new TerraformReference<string>(this, "parent_prefix");
        set => SetArgument("parent_prefix", value);
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
    /// A region where the prefix will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// List of sub public delegated fixes for BYO IP functionality.
    /// Each item in this array represents a sub prefix that can be
    /// used to create addresses or further allocations.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicDelegatedSubPrefixs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_delegated_sub_prefixs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputePublicDelegatedPrefixTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputePublicDelegatedPrefixTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
