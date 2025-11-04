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
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    public string? HostProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_project")?.Value;
        set => this.WithProperty("host_project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    public string? ServiceProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_project")?.Value;
        set => this.WithProperty("service_project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
