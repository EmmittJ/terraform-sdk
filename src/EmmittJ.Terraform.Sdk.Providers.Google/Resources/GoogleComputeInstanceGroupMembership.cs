using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_instance_group_membership resource.
/// </summary>
public class GoogleComputeInstanceGroupMembership : TerraformResource
{
    public GoogleComputeInstanceGroupMembership(string name) : base("google_compute_instance_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// An instance being added to the InstanceGroup
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// Represents an Instance Group resource name that the instance belongs to.
    /// </summary>
    public TerraformProperty<string>? InstanceGroup
    {
        get => GetProperty<TerraformProperty<string>>("instance_group");
        set => this.WithProperty("instance_group", value);
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
    /// A reference to the zone where the instance group resides.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}
