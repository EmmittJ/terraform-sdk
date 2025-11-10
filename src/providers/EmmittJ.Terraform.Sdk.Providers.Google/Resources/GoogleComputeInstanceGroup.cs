using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for named_port in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupNamedPortBlock : TerraformBlock
{
    /// <summary>
    /// The name which the port will be mapped to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The port number to map the name to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_instance_group resource.
/// </summary>
public class GoogleComputeInstanceGroup : TerraformResource
{
    public GoogleComputeInstanceGroup(string name) : base("google_compute_instance_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("self_link");
        this.WithOutput("size");
    }

    /// <summary>
    /// An optional textual description of the instance group.
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
    /// The list of instances in the group, in self_link format. When adding instances they must all be in the same network and zone as the instance group.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Instances
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The name of the instance group. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The URL of the network the instance group is in. If this is different from the network where the instances are in, the creation fails. Defaults to the network where the instances are in (if neither network nor instances is specified, this field will be blank).
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The zone that this instance group should be created in.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for named_port.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceGroupNamedPortBlock>? NamedPort
    {
        get => GetProperty<List<GoogleComputeInstanceGroupNamedPortBlock>>("named_port");
        set => this.WithProperty("named_port", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The number of instances in the group.
    /// </summary>
    public TerraformExpression Size => this["size"];

}
