using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_shared_vpc_service_project resource.
/// </summary>
public class GoogleComputeSharedVpcServiceProject : TerraformResource
{
    public GoogleComputeSharedVpcServiceProject(string name) : base("google_compute_shared_vpc_service_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The deletion policy for the shared VPC service. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    public TerraformProperty<string>? HostProject
    {
        get => GetProperty<TerraformProperty<string>>("host_project");
        set => this.WithProperty("host_project", value);
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
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    public TerraformProperty<string>? ServiceProject
    {
        get => GetProperty<TerraformProperty<string>>("service_project");
        set => this.WithProperty("service_project", value);
    }

}
