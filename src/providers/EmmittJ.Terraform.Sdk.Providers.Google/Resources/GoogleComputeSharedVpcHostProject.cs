using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeSharedVpcHostProject.
/// Nesting mode: single
/// </summary>
public class GoogleComputeSharedVpcHostProjectTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_shared_vpc_host_project Terraform resource.
/// Manages a google_compute_shared_vpc_host_project resource.
/// </summary>
public partial class GoogleComputeSharedVpcHostProject(string name) : TerraformResource("google_compute_shared_vpc_host_project", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the project that will serve as a Shared VPC host project
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeSharedVpcHostProjectTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeSharedVpcHostProjectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
