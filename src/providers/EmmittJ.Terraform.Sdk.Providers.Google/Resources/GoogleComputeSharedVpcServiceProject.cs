using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeSharedVpcServiceProject.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSharedVpcServiceProjectTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_shared_vpc_service_project Terraform resource.
/// Manages a google_compute_shared_vpc_service_project resource.
/// </summary>
public partial class GoogleComputeSharedVpcServiceProject(string name) : TerraformResource("google_compute_shared_vpc_service_project", name)
{
    /// <summary>
    /// The deletion policy for the shared VPC service. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;ABANDON&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The ID of a host project to associate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostProject is required")]
    public required TerraformValue<string> HostProject
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_project");
        set => SetArgument("host_project", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the project that will serve as a Shared VPC service project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceProject is required")]
    public required TerraformValue<string> ServiceProject
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_project");
        set => SetArgument("service_project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSharedVpcServiceProjectTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSharedVpcServiceProjectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
