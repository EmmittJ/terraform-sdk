using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// The number of the guest accelerator cards exposed to this
    /// node template.
    /// </summary>
    public TerraformProperty<double>? AcceleratorCount
    {
        get => GetProperty<TerraformProperty<double>>("accelerator_count");
        set => WithProperty("accelerator_count", value);
    }

    /// <summary>
    /// Full or partial URL of the accelerator type resource to expose
    /// to this node template.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disks in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateDisksBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the number of such disks.
    /// </summary>
    public TerraformProperty<double>? DiskCount
    {
        get => GetProperty<TerraformProperty<double>>("disk_count");
        set => WithProperty("disk_count", value);
    }

    /// <summary>
    /// Specifies the size of the disk in base-2 GB.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        get => GetProperty<TerraformProperty<string>>("disk_type");
        set => WithProperty("disk_type", value);
    }

}

/// <summary>
/// Block type for node_type_flexibility in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateNodeTypeFlexibilityBlock : TerraformBlock
{
    /// <summary>
    /// Number of virtual CPUs to use.
    /// </summary>
    public TerraformProperty<string>? Cpus
    {
        get => GetProperty<TerraformProperty<string>>("cpus");
        set => WithProperty("cpus", value);
    }

    /// <summary>
    /// Use local SSD
    /// </summary>
    public TerraformProperty<string>? LocalSsd
    {
        get => GetProperty<TerraformProperty<string>>("local_ssd");
        set => WithProperty("local_ssd", value);
    }

    /// <summary>
    /// Physical memory available to the node, defined in MB.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
    }

}

/// <summary>
/// Block type for server_binding in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateServerBindingBlock : TerraformBlock
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
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_node_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeNodeTemplate : TerraformResource
{
    public GoogleComputeNodeTemplate(string name) : base("google_compute_node_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_timestamp");
        this.WithOutput("self_link");
    }

    /// <summary>
    /// CPU overcommit. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CpuOvercommitType
    {
        get => GetProperty<TerraformProperty<string>>("cpu_overcommit_type");
        set => this.WithProperty("cpu_overcommit_type", value);
    }

    /// <summary>
    /// An optional textual description of the resource.
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
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? NodeAffinityLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("node_affinity_labels");
        set => this.WithProperty("node_affinity_labels", value);
    }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
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
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeNodeTemplateAcceleratorsBlock>? Accelerators
    {
        get => GetProperty<List<GoogleComputeNodeTemplateAcceleratorsBlock>>("accelerators");
        set => this.WithProperty("accelerators", value);
    }

    /// <summary>
    /// Block for disks.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeNodeTemplateDisksBlock>? Disks
    {
        get => GetProperty<List<GoogleComputeNodeTemplateDisksBlock>>("disks");
        set => this.WithProperty("disks", value);
    }

    /// <summary>
    /// Block for node_type_flexibility.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeTypeFlexibility block(s) allowed")]
    public List<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock>? NodeTypeFlexibility
    {
        get => GetProperty<List<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock>>("node_type_flexibility");
        set => this.WithProperty("node_type_flexibility", value);
    }

    /// <summary>
    /// Block for server_binding.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerBinding block(s) allowed")]
    public List<GoogleComputeNodeTemplateServerBindingBlock>? ServerBinding
    {
        get => GetProperty<List<GoogleComputeNodeTemplateServerBindingBlock>>("server_binding");
        set => this.WithProperty("server_binding", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeNodeTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeNodeTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
