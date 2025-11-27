using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allocation_options in GoogleNetworkConnectivityInternalRange.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allocation_options";

    /// <summary>
    /// Optional. Sets the strategy used to automatically find a free range of a size given by prefixLength. Can be set only when trying to create a reservation that automatically finds the free range to reserve. Possible values: [&amp;quot;RANDOM&amp;quot;, &amp;quot;FIRST_AVAILABLE&amp;quot;, &amp;quot;RANDOM_FIRST_N_AVAILABLE&amp;quot;, &amp;quot;FIRST_SMALLEST_FITTING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// Must be set when allocation_strategy is RANDOM_FIRST_N_AVAILABLE, otherwise must remain unset. Defines the size of the set of free ranges from which RANDOM_FIRST_N_AVAILABLE strategy randomy selects one,
    /// in other words it sets the N in the RANDOM_FIRST_N_AVAILABLE.
    /// </summary>
    public TerraformValue<double>? FirstAvailableRangesLookupSize
    {
        get => new TerraformReference<double>(this, "first_available_ranges_lookup_size");
        set => SetArgument("first_available_ranges_lookup_size", value);
    }

}


/// <summary>
/// Block type for migration in GoogleNetworkConnectivityInternalRange.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityInternalRangeMigrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "migration";

    /// <summary>
    /// Resource path as an URI of the source resource, for example a subnet.
    /// The project for the source resource should match the project for the
    /// InternalRange.
    /// An example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Resource path of the target resource. The target project can be
    /// different, as in the cases when migrating to peer networks. The resource
    /// may not exist yet.
    /// For example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivityInternalRange.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityInternalRangeTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_connectivity_internal_range Terraform resource.
/// Manages a google_network_connectivity_internal_range resource.
/// </summary>
public partial class GoogleNetworkConnectivityInternalRange(string name) : TerraformResource("google_network_connectivity_internal_range", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. List of IP CIDR ranges to be excluded. Resulting reserved Internal Range will not overlap with any CIDR blocks mentioned in this list.
    /// Only IPv4 CIDR ranges are supported.
    /// </summary>
    public TerraformList<string>? ExcludeCidrRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exclude_cidr_ranges").ResolveNodes(ctx));
        set => SetArgument("exclude_cidr_ranges", value);
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
    /// Immutable ranges cannot have their fields modified, except for labels and description.
    /// </summary>
    public TerraformValue<bool>? Immutable
    {
        get => new TerraformReference<bool>(this, "immutable");
        set => SetArgument("immutable", value);
    }

    /// <summary>
    /// The IP range that this internal range defines.
    /// NOTE: IPv6 ranges are limited to usage=EXTERNAL_TO_VPC and peering=FOR_SELF
    /// NOTE: For IPv6 Ranges this field is compulsory, i.e. the address range must be specified explicitly.
    /// </summary>
    public TerraformValue<string> IpCidrRange
    {
        get => new TerraformReference<string>(this, "ip_cidr_range");
        set => SetArgument("ip_cidr_range", value);
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Optional. Types of resources that are allowed to overlap with the current internal range. Possible values: [&amp;quot;OVERLAP_ROUTE_RANGE&amp;quot;, &amp;quot;OVERLAP_EXISTING_SUBNET_RANGE&amp;quot;]
    /// </summary>
    public TerraformList<string>? Overlaps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "overlaps").ResolveNodes(ctx));
        set => SetArgument("overlaps", value);
    }

    /// <summary>
    /// The type of peering set for this internal range. Possible values: [&amp;quot;FOR_SELF&amp;quot;, &amp;quot;FOR_PEER&amp;quot;, &amp;quot;NOT_SHARED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformValue<string> Peering
    {
        get => new TerraformReference<string>(this, "peering");
        set => SetArgument("peering", value);
    }

    /// <summary>
    /// An alternate to ipCidrRange. Can be set when trying to create a reservation that automatically finds a free range of the given size.
    /// If both ipCidrRange and prefixLength are set, there is an error if the range sizes do not match. Can also be used during updates to change the range size.
    /// NOTE: For IPv6 this field only works if ip_cidr_range is set as well, and both fields must match. In other words, with IPv6 this field only works as
    /// a redundant parameter.
    /// </summary>
    public TerraformValue<double>? PrefixLength
    {
        get => new TerraformReference<double>(this, "prefix_length");
        set => SetArgument("prefix_length", value);
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
    /// Optional. Can be set to narrow down or pick a different address space while searching for a free range.
    /// If not set, defaults to the &amp;quot;10.0.0.0/8&amp;quot; address space. This can be used to search in other rfc-1918 address spaces like &amp;quot;172.16.0.0/12&amp;quot; and &amp;quot;192.168.0.0/16&amp;quot; or non-rfc-1918 address spaces used in the VPC.
    /// </summary>
    public TerraformList<string>? TargetCidrRange
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_cidr_range").ResolveNodes(ctx));
        set => SetArgument("target_cidr_range", value);
    }

    /// <summary>
    /// The type of usage set for this InternalRange. Possible values: [&amp;quot;FOR_VPC&amp;quot;, &amp;quot;EXTERNAL_TO_VPC&amp;quot;, &amp;quot;FOR_MIGRATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    public required TerraformValue<string> Usage
    {
        get => new TerraformReference<string>(this, "usage");
        set => SetArgument("usage", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The list of resources that refer to this internal range.
    /// Resources that use the internal range for their range allocation are referred to as users of the range.
    /// Other resources mark themselves as users while doing so by creating a reference to this internal range. Having a user, based on this reference, prevents deletion of the internal range referred to. Can be empty.
    /// </summary>
    public TerraformList<string> Users
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "users").ResolveNodes(ctx));
    }

    /// <summary>
    /// AllocationOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllocationOptions block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock>? AllocationOptions
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock>>("allocation_options");
        set => SetArgument("allocation_options", value);
    }

    /// <summary>
    /// Migration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Migration block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivityInternalRangeMigrationBlock>? Migration
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivityInternalRangeMigrationBlock>>("migration");
        set => SetArgument("migration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivityInternalRangeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivityInternalRangeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
