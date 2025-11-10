using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSharedVpcServiceProjectTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("deletion_policy");
        SetOutput("host_project");
        SetOutput("id");
        SetOutput("service_project");
    }

    /// <summary>
    /// The deletion policy for the shared VPC service. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProject is required")]
    public required TerraformProperty<string> HostProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_project");
        set => SetProperty("host_project", value);
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
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProject is required")]
    public required TerraformProperty<string> ServiceProject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_project");
        set => SetProperty("service_project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeSharedVpcServiceProjectTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
