using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allocation_options in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Sets the strategy used to automatically find a free range of a size given by prefixLength. Can be set only when trying to create a reservation that automatically finds the free range to reserve. Possible values: [&amp;quot;RANDOM&amp;quot;, &amp;quot;FIRST_AVAILABLE&amp;quot;, &amp;quot;RANDOM_FIRST_N_AVAILABLE&amp;quot;, &amp;quot;FIRST_SMALLEST_FITTING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        set => SetProperty("allocation_strategy", value);
    }

    /// <summary>
    /// Must be set when allocation_strategy is RANDOM_FIRST_N_AVAILABLE, otherwise must remain unset. Defines the size of the set of free ranges from which RANDOM_FIRST_N_AVAILABLE strategy randomy selects one,
    /// in other words it sets the N in the RANDOM_FIRST_N_AVAILABLE.
    /// </summary>
    public TerraformProperty<double>? FirstAvailableRangesLookupSize
    {
        set => SetProperty("first_available_ranges_lookup_size", value);
    }

}

/// <summary>
/// Block type for migration in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityInternalRangeMigrationBlock : TerraformBlock
{
    /// <summary>
    /// Resource path as an URI of the source resource, for example a subnet.
    /// The project for the source resource should match the project for the
    /// InternalRange.
    /// An example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Resource path of the target resource. The target project can be
    /// different, as in the cases when migrating to peer networks. The resource
    /// may not exist yet.
    /// For example /projects/{project}/regions/{region}/subnetworks/{subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        set => SetProperty("target", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityInternalRangeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_connectivity_internal_range resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivityInternalRange : TerraformResource
{
    public GoogleNetworkConnectivityInternalRange(string name) : base("google_network_connectivity_internal_range", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("users");
        SetOutput("description");
        SetOutput("exclude_cidr_ranges");
        SetOutput("id");
        SetOutput("immutable");
        SetOutput("ip_cidr_range");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("network");
        SetOutput("overlaps");
        SetOutput("peering");
        SetOutput("prefix_length");
        SetOutput("project");
        SetOutput("target_cidr_range");
        SetOutput("usage");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Optional. List of IP CIDR ranges to be excluded. Resulting reserved Internal Range will not overlap with any CIDR blocks mentioned in this list.
    /// Only IPv4 CIDR ranges are supported.
    /// </summary>
    public List<TerraformProperty<string>> ExcludeCidrRanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("exclude_cidr_ranges");
        set => SetProperty("exclude_cidr_ranges", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Immutable ranges cannot have their fields modified, except for labels and description.
    /// </summary>
    public TerraformProperty<bool> Immutable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("immutable");
        set => SetProperty("immutable", value);
    }

    /// <summary>
    /// The IP range that this internal range defines.
    /// NOTE: IPv6 ranges are limited to usage=EXTERNAL_TO_VPC and peering=FOR_SELF
    /// NOTE: For IPv6 Ranges this field is compulsory, i.e. the address range must be specified explicitly.
    /// </summary>
    public TerraformProperty<string> IpCidrRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_cidr_range");
        set => SetProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name of the policy based route.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Fully-qualified URL of the network that this route applies to, for example: projects/my-project/global/networks/my-network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Optional. Types of resources that are allowed to overlap with the current internal range. Possible values: [&amp;quot;OVERLAP_ROUTE_RANGE&amp;quot;, &amp;quot;OVERLAP_EXISTING_SUBNET_RANGE&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>> Overlaps
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("overlaps");
        set => SetProperty("overlaps", value);
    }

    /// <summary>
    /// The type of peering set for this internal range. Possible values: [&amp;quot;FOR_SELF&amp;quot;, &amp;quot;FOR_PEER&amp;quot;, &amp;quot;NOT_SHARED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Peering is required")]
    public required TerraformProperty<string> Peering
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering");
        set => SetProperty("peering", value);
    }

    /// <summary>
    /// An alternate to ipCidrRange. Can be set when trying to create a reservation that automatically finds a free range of the given size.
    /// If both ipCidrRange and prefixLength are set, there is an error if the range sizes do not match. Can also be used during updates to change the range size.
    /// NOTE: For IPv6 this field only works if ip_cidr_range is set as well, and both fields must match. In other words, with IPv6 this field only works as
    /// a redundant parameter.
    /// </summary>
    public TerraformProperty<double> PrefixLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("prefix_length");
        set => SetProperty("prefix_length", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Optional. Can be set to narrow down or pick a different address space while searching for a free range.
    /// If not set, defaults to the &amp;quot;10.0.0.0/8&amp;quot; address space. This can be used to search in other rfc-1918 address spaces like &amp;quot;172.16.0.0/12&amp;quot; and &amp;quot;192.168.0.0/16&amp;quot; or non-rfc-1918 address spaces used in the VPC.
    /// </summary>
    public List<TerraformProperty<string>> TargetCidrRange
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("target_cidr_range");
        set => SetProperty("target_cidr_range", value);
    }

    /// <summary>
    /// The type of usage set for this InternalRange. Possible values: [&amp;quot;FOR_VPC&amp;quot;, &amp;quot;EXTERNAL_TO_VPC&amp;quot;, &amp;quot;FOR_MIGRATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    public required TerraformProperty<string> Usage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage");
        set => SetProperty("usage", value);
    }

    /// <summary>
    /// Block for allocation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllocationOptions block(s) allowed")]
    public List<GoogleNetworkConnectivityInternalRangeAllocationOptionsBlock>? AllocationOptions
    {
        set => SetProperty("allocation_options", value);
    }

    /// <summary>
    /// Block for migration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Migration block(s) allowed")]
    public List<GoogleNetworkConnectivityInternalRangeMigrationBlock>? Migration
    {
        set => SetProperty("migration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivityInternalRangeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The list of resources that refer to this internal range.
    /// Resources that use the internal range for their range allocation are referred to as users of the range.
    /// Other resources mark themselves as users while doing so by creating a reference to this internal range. Having a user, based on this reference, prevents deletion of the internal range referred to. Can be empty.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
