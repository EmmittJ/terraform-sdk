using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputePublicDelegatedPrefixTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_public_delegated_prefix resource.
/// </summary>
public class GoogleComputePublicDelegatedPrefix : TerraformResource
{
    public GoogleComputePublicDelegatedPrefix(string name) : base("google_compute_public_delegated_prefix", name)
    {
    }

    /// <summary>
    /// The allocatable prefix length supported by this public delegated prefix. This field is optional and cannot be set for prefixes in DELEGATION mode. It cannot be set for IPv4 prefixes either, and it always defaults to 32.
    /// </summary>
    [TerraformPropertyName("allocatable_prefix_length")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AllocatablePrefixLength { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocatable_prefix_length");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The IP address range, in CIDR format, represented by this public delegated prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpCidrRange is required")]
    [TerraformPropertyName("ip_cidr_range")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpCidrRange { get; set; }

    /// <summary>
    /// If true, the prefix will be live migrated.
    /// </summary>
    [TerraformPropertyName("is_live_migration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsLiveMigration { get; set; }

    /// <summary>
    /// Specifies the mode of this IPv6 PDP. MODE must be one of: DELEGATION,
    /// EXTERNAL_IPV6_FORWARDING_RULE_CREATION and EXTERNAL_IPV6_SUBNETWORK_CREATION. Possible values: [&amp;quot;DELEGATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_FORWARDING_RULE_CREATION&amp;quot;, &amp;quot;EXTERNAL_IPV6_SUBNETWORK_CREATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The URL of parent prefix. Either PublicAdvertisedPrefix or PublicDelegatedPrefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentPrefix is required")]
    [TerraformPropertyName("parent_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParentPrefix { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// A region where the prefix will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputePublicDelegatedPrefixTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// List of sub public delegated fixes for BYO IP functionality.
    /// Each item in this array represents a sub prefix that can be
    /// used to create addresses or further allocations.
    /// </summary>
    [TerraformPropertyName("public_delegated_sub_prefixs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PublicDelegatedSubPrefixs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "public_delegated_sub_prefixs");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
