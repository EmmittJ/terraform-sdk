using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeTemplateAcceleratorsBlock() : TerraformBlock("accelerators")
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this
    /// node template.
    /// </summary>
    [TerraformProperty("accelerator_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AcceleratorCount { get; set; }

    /// <summary>
    /// Full or partial URL of the accelerator type resource to expose
    /// to this node template.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

}

/// <summary>
/// Block type for disks in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeTemplateDisksBlock() : TerraformBlock("disks")
{
    /// <summary>
    /// Specifies the number of such disks.
    /// </summary>
    [TerraformProperty("disk_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DiskCount { get; set; }

    /// <summary>
    /// Specifies the size of the disk in base-2 GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DiskSizeGb { get; set; }

    /// <summary>
    /// Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskType { get; set; }

}

/// <summary>
/// Block type for node_type_flexibility in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeTemplateNodeTypeFlexibilityBlock() : TerraformBlock("node_type_flexibility")
{
    /// <summary>
    /// Number of virtual CPUs to use.
    /// </summary>
    [TerraformProperty("cpus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cpus { get; set; }


    /// <summary>
    /// Physical memory available to the node, defined in MB.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Memory { get; set; }

}

/// <summary>
/// Block type for server_binding in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeNodeTemplateServerBindingBlock() : TerraformBlock("server_binding")
{
    /// <summary>
    /// Type of server binding policy. If &#39;RESTART_NODE_ON_ANY_SERVER&#39;,
    /// nodes using this template will restart on any physical server
    /// following a maintenance event.
    /// 
    /// If &#39;RESTART_NODE_ON_MINIMAL_SERVER&#39;, nodes using this template
    /// will restart on the same physical server following a maintenance
    /// event, instead of being live migrated to or restarted on a new
    /// physical server. This option may be useful if you are using
    /// software licenses tied to the underlying server characteristics
    /// such as physical sockets or cores, to avoid the need for
    /// additional licenses when maintenance occurs. However, VMs on such
    /// nodes will experience outages while maintenance is applied. Possible values: [&amp;quot;RESTART_NODE_ON_ANY_SERVER&amp;quot;, &amp;quot;RESTART_NODE_ON_MINIMAL_SERVERS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNodeTemplateTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_compute_node_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeNodeTemplate : TerraformResource
{
    public GoogleComputeNodeTemplate(string name) : base("google_compute_node_template", name)
    {
    }

    /// <summary>
    /// CPU overcommit. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    [TerraformProperty("cpu_overcommit_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CpuOvercommitType { get; set; }

    /// <summary>
    /// An optional textual description of the resource.
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
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    [TerraformProperty("node_affinity_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? NodeAffinityLabels { get; set; }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("accelerators")]
    public TerraformList<GoogleComputeNodeTemplateAcceleratorsBlock> Accelerators { get; set; } = new();

    /// <summary>
    /// Block for disks.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("disks")]
    public TerraformList<GoogleComputeNodeTemplateDisksBlock> Disks { get; set; } = new();

    /// <summary>
    /// Block for node_type_flexibility.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeTypeFlexibility block(s) allowed")]
    [TerraformProperty("node_type_flexibility")]
    public TerraformList<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock> NodeTypeFlexibility { get; set; } = new();

    /// <summary>
    /// Block for server_binding.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerBinding block(s) allowed")]
    [TerraformProperty("server_binding")]
    public TerraformList<GoogleComputeNodeTemplateServerBindingBlock> ServerBinding { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeNodeTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
