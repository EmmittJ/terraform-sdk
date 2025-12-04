using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for container_image in GoogleNotebooksEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentContainerImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_image";

    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => GetArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNotebooksEnvironment.
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksEnvironmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vm_image in GoogleNotebooksEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentVmImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_image";

    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    public TerraformValue<string>? ImageFamily
    {
        get => GetArgument<TerraformValue<string>>("image_family");
        set => SetArgument("image_family", value);
    }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    public TerraformValue<string>? ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Represents a google_notebooks_environment Terraform resource.
/// Manages a google_notebooks_environment resource.
/// </summary>
public partial class GoogleNotebooksEnvironment(string name) : TerraformResource("google_notebooks_environment", name)
{
    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name specified for the Environment instance.
    /// Format: projects/{project_id}/locations/{location}/environments/{environmentId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance fully boots up.
    /// The path must be a URL or Cloud Storage path. Example: &amp;quot;gs://path-to-file/file-name&amp;quot;
    /// </summary>
    public TerraformValue<string>? PostStartupScript
    {
        get => GetArgument<TerraformValue<string>>("post_startup_script");
        set => SetArgument("post_startup_script", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Instance creation time
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// ContainerImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public TerraformList<GoogleNotebooksEnvironmentContainerImageBlock>? ContainerImage
    {
        get => GetArgument<TerraformList<GoogleNotebooksEnvironmentContainerImageBlock>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNotebooksEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNotebooksEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VmImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    public TerraformList<GoogleNotebooksEnvironmentVmImageBlock>? VmImage
    {
        get => GetArgument<TerraformList<GoogleNotebooksEnvironmentVmImageBlock>>("vm_image");
        set => SetArgument("vm_image", value);
    }

}
