using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in GoogleComputeNodeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the guest accelerator cards exposed to this
    /// node template.
    /// </summary>
    public TerraformValue<double>? AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// Full or partial URL of the accelerator type resource to expose
    /// to this node template.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}


/// <summary>
/// Block type for disks in GoogleComputeNodeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disks";

    /// <summary>
    /// Specifies the number of such disks.
    /// </summary>
    public TerraformValue<double>? DiskCount
    {
        get => GetArgument<TerraformValue<double>>("disk_count");
        set => SetArgument("disk_count", value);
    }

    /// <summary>
    /// Specifies the size of the disk in base-2 GB.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Specifies the desired disk type on the node. This disk type must be a local storage type (e.g.: local-ssd). Note that for nodeTemplates, this should be the name of the disk type and not its URL.
    /// </summary>
    public TerraformValue<string>? DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type");
        set => SetArgument("disk_type", value);
    }

}


/// <summary>
/// Block type for node_type_flexibility in GoogleComputeNodeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateNodeTypeFlexibilityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_type_flexibility";

    /// <summary>
    /// Number of virtual CPUs to use.
    /// </summary>
    public TerraformValue<string>? Cpus
    {
        get => GetArgument<TerraformValue<string>>("cpus");
        set => SetArgument("cpus", value);
    }

    /// <summary>
    /// Use local SSD
    /// </summary>
    public TerraformValue<string> LocalSsd
        => AsReference("local_ssd");

    /// <summary>
    /// Physical memory available to the node, defined in MB.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for server_binding in GoogleComputeNodeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeNodeTemplateServerBindingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_binding";

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
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeNodeTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNodeTemplateTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_node_template Terraform resource.
/// Manages a google_compute_node_template resource.
/// </summary>
public partial class GoogleComputeNodeTemplate(string name) : TerraformResource("google_compute_node_template", name)
{
    /// <summary>
    /// CPU overcommit. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;NONE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CpuOvercommitType
    {
        get => GetArgument<TerraformValue<string>>("cpu_overcommit_type");
        set => SetArgument("cpu_overcommit_type", value);
    }

    /// <summary>
    /// An optional textual description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Labels to use for node affinity, which will be used in
    /// instance scheduling.
    /// </summary>
    public TerraformMap<string>? NodeAffinityLabels
    {
        get => GetArgument<TerraformMap<string>>("node_affinity_labels");
        set => SetArgument("node_affinity_labels", value);
    }

    /// <summary>
    /// Node type to use for nodes group that are created from this template.
    /// Only one of nodeTypeFlexibility and nodeType can be specified.
    /// </summary>
    public TerraformValue<string>? NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Region where nodes using the node template will be created.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Accelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeNodeTemplateAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformList<GoogleComputeNodeTemplateAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// Disks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeNodeTemplateDisksBlock>? Disks
    {
        get => GetArgument<TerraformList<GoogleComputeNodeTemplateDisksBlock>>("disks");
        set => SetArgument("disks", value);
    }

    /// <summary>
    /// NodeTypeFlexibility block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeTypeFlexibility block(s) allowed")]
    public TerraformList<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock>? NodeTypeFlexibility
    {
        get => GetArgument<TerraformList<GoogleComputeNodeTemplateNodeTypeFlexibilityBlock>>("node_type_flexibility");
        set => SetArgument("node_type_flexibility", value);
    }

    /// <summary>
    /// ServerBinding block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerBinding block(s) allowed")]
    public TerraformList<GoogleComputeNodeTemplateServerBindingBlock>? ServerBinding
    {
        get => GetArgument<TerraformList<GoogleComputeNodeTemplateServerBindingBlock>>("server_binding");
        set => SetArgument("server_binding", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeNodeTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNodeTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
