using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for intent in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectGroupIntentBlock : TerraformBlock
{
    /// <summary>
    /// The reliability the user intends this group to be capable of, in terms
    /// of the Interconnect product SLAs. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? TopologyCapability
    {
        set => SetProperty("topology_capability", value);
    }

}

/// <summary>
/// Block type for interconnects in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInterconnectGroupInterconnectsBlock : TerraformBlock
{
    /// <summary>
    /// The URL of an Interconnect in this group. All Interconnects in the group are unique.
    /// </summary>
    public TerraformProperty<string>? Interconnect
    {
        set => SetProperty("interconnect", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_interconnect_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInterconnectGroup : TerraformResource
{
    public GoogleComputeInterconnectGroup(string name) : base("google_compute_interconnect_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("configured");
        SetOutput("creation_timestamp");
        SetOutput("physical_structure");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for intent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    public List<GoogleComputeInterconnectGroupIntentBlock>? Intent
    {
        set => SetProperty("intent", value);
    }

    /// <summary>
    /// Block for interconnects.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeInterconnectGroupInterconnectsBlock>? Interconnects
    {
        set => SetProperty("interconnects", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInterconnectGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The status of the group as configured. This has the same
    /// structure as the operational field reported by the OperationalStatus
    /// method, but does not take into account the operational status of each
    /// resource.
    /// </summary>
    public TerraformExpression Configured => this["configured"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An analysis of the physical layout of Interconnects in this
    /// group. Every Interconnect in the group is shown once in this structure.
    /// </summary>
    public TerraformExpression PhysicalStructure => this["physical_structure"];

}
