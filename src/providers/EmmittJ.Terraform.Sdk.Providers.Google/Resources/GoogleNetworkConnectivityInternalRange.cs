using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allocation_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Sets the strategy used to automatically find a free range of a size given by prefixLength. Can be set only when trying to create a reservation that automatically finds the free range to reserve. Possible values: [&amp;quot;RANDOM&amp;quot;, &amp;quot;FIRST_AVAILABLE&amp;quot;, &amp;quot;RANDOM_FIRST_N_AVAILABLE&amp;quot;, &amp;quot;FIRST_SMALLEST_FITTING&amp;quot;]
    /// </summary>
    [TerraformProperty("allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationStrategy { get; set; }

    /// <summary>
    /// Must be set when allocation_strategy is RANDOM_FIRST_N_AVAILABLE, otherwise must remain unset. Defines the size of the set of free ranges from which RANDOM_FIRST_N_AVAILABLE strategy randomy selects one,
    /// in other words it sets the N in the RANDOM_FIRST_N_AVAILABLE.
    /// </summary>
    [TerraformProperty("first_available_ranges_lookup_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FirstAvailableRangesLookupSize { get; set; }

}

/// <summary>
/// Block type for migration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkConnectivityInternalRangeMigrationBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource path as an URI of the source resource, for example a subnet.
    /// The project for the source resource should match the project for the
    /// InternalRange.
    /// An example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// Resource path of the target resource. The target project can be
    /// different, as in the cases when migrating to peer networks. The resource
    /// may not exist yet.
    /// For example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Target { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkConnectivityInternalRangeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_internal_range resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkConnectivityInternalRange : TerraformResource
{
    public GoogleNetworkConnectivityInternalRange(string name) : base("google_network_connectivity_internal_range", name)
    {
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Optional. List of IP CIDR ranges to be excluded. Resulting reserved Internal Range will not overlap with any CIDR blocks mentioned in this list.
    /// Only IPv4 CIDR ranges are supported.
    /// </summary>
    [TerraformProperty("exclude_cidr_ranges")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludeCidrRanges { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Immutable ranges cannot have their fields modified, except for labels and description.
    /// </summary>
    [TerraformProperty("immutable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Immutable { get; set; }

    /// <summary>
    /// The IP range that this internal range defines.
    /// NOTE: IPv6 ranges are limited to usage=EXTERNAL_TO_VPC and peering=FOR_SELF
    /// NOTE: For IPv6 Ranges this field is compulsory, i.e. the address range must be specified explicitly.
    /// </summary>
    [TerraformProperty("ip_cidr_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpCidrRange { get; set; }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Optional. Types of resources that are allowed to overlap with the current internal range. Possible values: [&amp;quot;OVERLAP_ROUTE_RANGE&amp;quot;, &amp;quot;OVERLAP_EXISTING_SUBNET_RANGE&amp;quot;]
    /// </summary>
    [TerraformProperty("overlaps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Overlaps { get; set; }

    /// <summary>
    /// The type of peering set for this internal range. Possible values: [&amp;quot;FOR_SELF&amp;quot;, &amp;quot;FOR_PEER&amp;quot;, &amp;quot;NOT_SHARED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    [TerraformProperty("peering")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Peering { get; set; }

    /// <summary>
    /// An alternate to ipCidrRange. Can be set when trying to create a reservation that automatically finds a free range of the given size.
    /// If both ipCidrRange and prefixLength are set, there is an error if the range sizes do not match. Can also be used during updates to change the range size.
    /// NOTE: For IPv6 this field only works if ip_cidr_range is set as well, and both fields must match. In other words, with IPv6 this field only works as
    /// a redundant parameter.
    /// </summary>
    [TerraformProperty("prefix_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PrefixLength { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. Can be set to narrow down or pick a different address space while searching for a free range.
    /// If not set, defaults to the &amp;quot;10.0.0.0/8&amp;quot; address space. This can be used to search in other rfc-1918 address spaces like &amp;quot;172.16.0.0/12&amp;quot; and &amp;quot;192.168.0.0/16&amp;quot; or non-rfc-1918 address spaces used in the VPC.
    /// </summary>
    [TerraformProperty("target_cidr_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TargetCidrRange { get; set; }

    /// <summary>
    /// The type of usage set for this InternalRange. Possible values: [&amp;quot;FOR_VPC&amp;quot;, &amp;quot;EXTERNAL_TO_VPC&amp;quot;, &amp;quot;FOR_MIGRATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    [TerraformProperty("usage")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Usage { get; set; }

    /// <summary>
    /// Block for allocation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllocationOptions block(s) allowed")]
    [TerraformProperty("allocation_options")]
    public partial TerraformList<TerraformBlock<GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock>>? AllocationOptions { get; set; }

    /// <summary>
    /// Block for migration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Migration block(s) allowed")]
    [TerraformProperty("migration")]
    public partial TerraformList<TerraformBlock<GoogleNetworkConnectivityInternalRangeMigrationBlock>>? Migration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetworkConnectivityInternalRangeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. The list of resources that refer to this internal range.
    /// Resources that use the internal range for their range allocation are referred to as users of the range.
    /// Other resources mark themselves as users while doing so by creating a reference to this internal range. Having a user, based on this reference, prevents deletion of the internal range referred to. Can be empty.
    /// </summary>
    [TerraformProperty("users")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Users { get; }

}
