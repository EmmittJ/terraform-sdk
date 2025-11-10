using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for container_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentContainerImageBlock : TerraformBlock
{
    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformProperty<string> Repository
    {
        set => SetProperty("repository", value);
    }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        set => SetProperty("tag", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksEnvironmentTimeoutsBlock : TerraformBlock
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
/// Block type for vm_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentVmImageBlock : TerraformBlock
{
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    public TerraformProperty<string>? ImageFamily
    {
        set => SetProperty("image_family", value);
    }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformProperty<string> Project
    {
        set => SetProperty("project", value);
    }

}

/// <summary>
/// Manages a google_notebooks_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNotebooksEnvironment : TerraformResource
{
    public GoogleNotebooksEnvironment(string name) : base("google_notebooks_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("post_startup_script");
        SetOutput("project");
    }

    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name specified for the Environment instance.
    /// Format: projects/{project_id}/locations/{location}/environments/{environmentId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance fully boots up.
    /// The path must be a URL or Cloud Storage path. Example: &amp;quot;gs://path-to-file/file-name&amp;quot;
    /// </summary>
    public TerraformProperty<string> PostStartupScript
    {
        get => GetRequiredOutput<TerraformProperty<string>>("post_startup_script");
        set => SetProperty("post_startup_script", value);
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
    /// Block for container_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public List<GoogleNotebooksEnvironmentContainerImageBlock>? ContainerImage
    {
        set => SetProperty("container_image", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNotebooksEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vm_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    public List<GoogleNotebooksEnvironmentVmImageBlock>? VmImage
    {
        set => SetProperty("vm_image", value);
    }

    /// <summary>
    /// Instance creation time
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
