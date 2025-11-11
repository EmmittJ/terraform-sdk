using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for intent in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeInterconnectGroupIntentBlock : TerraformBlockBase
{
    /// <summary>
    /// The reliability the user intends this group to be capable of, in terms
    /// of the Interconnect product SLAs. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    [TerraformProperty("topology_capability")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TopologyCapability { get; set; }

}

/// <summary>
/// Block type for interconnects in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeInterconnectGroupInterconnectsBlock : TerraformBlockBase
{
    /// <summary>
    /// The URL of an Interconnect in this group. All Interconnects in the group are unique.
    /// </summary>
    [TerraformProperty("interconnect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Interconnect { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeInterconnectGroupTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_interconnect_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeInterconnectGroup : TerraformResource
{
    public GoogleComputeInterconnectGroup(string name) : base("google_compute_interconnect_group", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    [TerraformProperty("intent")]
    public partial TerraformList<TerraformBlock<GoogleComputeInterconnectGroupIntentBlock>>? Intent { get; set; }

    /// <summary>
    /// Block for interconnects.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("interconnects")]
    public partial TerraformSet<TerraformBlock<GoogleComputeInterconnectGroupInterconnectsBlock>>? Interconnects { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeInterconnectGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The status of the group as configured. This has the same
    /// structure as the operational field reported by the OperationalStatus
    /// method, but does not take into account the operational status of each
    /// resource.
    /// </summary>
    [TerraformProperty("configured")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Configured { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// An analysis of the physical layout of Interconnects in this
    /// group. Every Interconnect in the group is shown once in this structure.
    /// </summary>
    [TerraformProperty("physical_structure")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PhysicalStructure { get; }

}
