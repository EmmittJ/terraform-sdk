using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for container_image in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksEnvironmentContainerImageBlock : TerraformBlockBase
{
    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformProperty("repository")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Repository { get; set; }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tag { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNotebooksEnvironmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vm_image in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksEnvironmentVmImageBlock : TerraformBlockBase
{
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    [TerraformProperty("image_family")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageFamily { get; set; }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    [TerraformProperty("image_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageName { get; set; }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Project { get; set; }

}

/// <summary>
/// Manages a google_notebooks_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNotebooksEnvironment : TerraformResource
{
    public GoogleNotebooksEnvironment(string name) : base("google_notebooks_environment", name)
    {
    }

    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name specified for the Environment instance.
    /// Format: projects/{project_id}/locations/{location}/environments/{environmentId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance fully boots up.
    /// The path must be a URL or Cloud Storage path. Example: &amp;quot;gs://path-to-file/file-name&amp;quot;
    /// </summary>
    [TerraformProperty("post_startup_script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostStartupScript { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for container_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    [TerraformProperty("container_image")]
    public partial TerraformList<TerraformBlock<GoogleNotebooksEnvironmentContainerImageBlock>>? ContainerImage { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNotebooksEnvironmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vm_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    [TerraformProperty("vm_image")]
    public partial TerraformList<TerraformBlock<GoogleNotebooksEnvironmentVmImageBlock>>? VmImage { get; set; }

    /// <summary>
    /// Instance creation time
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

}
