using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateAcceleratorsBlock : ITerraformBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this
    /// node template.
    /// </summary>
    [TerraformPropertyName("accelerator_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AcceleratorCount { get; set; }

    /// <summary>
    /// Full or partial URL of the accelerator type resource to expose
    /// to this node template.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

}

/// <summary>
/// Block type for disks in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateDisksBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the number of such disks.
    /// </summary>
    [TerraformPropertyName("disk_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DiskCount { get; set; }

    /// <summary>
    /// Specifies the size of the disk in base-2 GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DiskSizeGb { get; set; }

    /// <summary>
    /// Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskType { get; set; }

}

/// <summary>
/// Block type for node_type_flexibility in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateNodeTypeFlexibilityBlock : ITerraformBlock
{
    /// <summary>
    /// Number of virtual CPUs to use.
    /// </summary>
    [TerraformPropertyName("cpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cpus { get; set; }

    /// <summary>
    /// Use local SSD
    /// </summary>
    [TerraformPropertyName("local_ssd")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalSsd => new TerraformReferenceProperty<TerraformProperty<string>>("", "local_ssd");

    /// <summary>
    /// Physical memory available to the node, defined in MB.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Memory { get; set; }

}

/// <summary>
/// Block type for server_binding in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateServerBindingBlock : ITerraformBlock
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
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeTemplateTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_node_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNodeTemplate : TerraformResource
{
    public GoogleComputeNodeTemplate(string name) : base("google_compute_node_template", name)
    {
    }

    /// <summary>
    /// CPU overcommit. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("cpu_overcommit_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuOvercommitType { get; set; }

    /// <summary>
    /// An optional textual description of the resource.
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
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    [TerraformPropertyName("node_affinity_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? NodeAffinityLabels { get; set; }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    [TerraformPropertyName("node_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NodeType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("accelerators")]
    public TerraformList<TerraformBlock<GoogleComputeNodeTemplateAcceleratorsBlock>>? Accelerators { get; set; } = new();

    /// <summary>
    /// Block for disks.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("disks")]
    public TerraformList<TerraformBlock<GoogleComputeNodeTemplateDisksBlock>>? Disks { get; set; } = new();

    /// <summary>
    /// Block for node_type_flexibility.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeTypeFlexibility block(s) allowed")]
    [TerraformPropertyName("node_type_flexibility")]
    public TerraformList<TerraformBlock<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock>>? NodeTypeFlexibility { get; set; } = new();

    /// <summary>
    /// Block for server_binding.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerBinding block(s) allowed")]
    [TerraformPropertyName("server_binding")]
    public TerraformList<TerraformBlock<GoogleComputeNodeTemplateServerBindingBlock>>? ServerBinding { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNodeTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
