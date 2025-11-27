using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for intent in GoogleComputeInterconnectGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectGroupIntentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intent";

    /// <summary>
    /// The reliability the user intends this group to be capable of, in terms
    /// of the Interconnect product SLAs. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TopologyCapability
    {
        get => new TerraformReference<string>(this, "topology_capability");
        set => SetArgument("topology_capability", value);
    }

}


/// <summary>
/// Block type for interconnects in GoogleComputeInterconnectGroup.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInterconnectGroupInterconnectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interconnects";

    /// <summary>
    /// The URL of an Interconnect in this group. All Interconnects in the group are unique.
    /// </summary>
    public TerraformValue<string>? Interconnect
    {
        get => new TerraformReference<string>(this, "interconnect");
        set => SetArgument("interconnect", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInterconnectGroup.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_interconnect_group Terraform resource.
/// Manages a google_compute_interconnect_group resource.
/// </summary>
public partial class GoogleComputeInterconnectGroup(string name) : TerraformResource("google_compute_interconnect_group", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
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
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The status of the group as configured. This has the same
    /// structure as the operational field reported by the OperationalStatus
    /// method, but does not take into account the operational status of each
    /// resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configured
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "configured").ResolveNodes(ctx));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// An analysis of the physical layout of Interconnects in this
    /// group. Every Interconnect in the group is shown once in this structure.
    /// </summary>
    public TerraformList<TerraformMap<object>> PhysicalStructure
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "physical_structure").ResolveNodes(ctx));
    }

    /// <summary>
    /// Intent block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    public required TerraformList<GoogleComputeInterconnectGroupIntentBlock> Intent
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInterconnectGroupIntentBlock>>("intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// Interconnects block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInterconnectGroupInterconnectsBlock>? Interconnects
    {
        get => GetArgument<TerraformSet<GoogleComputeInterconnectGroupInterconnectsBlock>>("interconnects");
        set => SetArgument("interconnects", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInterconnectGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInterconnectGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
