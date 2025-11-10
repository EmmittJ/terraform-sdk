using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupNamedPortTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_instance_group_named_port resource.
/// </summary>
public class GoogleComputeInstanceGroupNamedPort : TerraformResource
{
    public GoogleComputeInstanceGroupNamedPort(string name) : base("google_compute_instance_group_named_port", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The name of the instance group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformProperty<string> Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// The name for this named port. The name must be 1-63 characters
    /// long, and comply with RFC1035.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port number, which can be a value between 1 and 65535.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
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
    /// The zone of the instance group.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceGroupNamedPortTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceGroupNamedPortTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
