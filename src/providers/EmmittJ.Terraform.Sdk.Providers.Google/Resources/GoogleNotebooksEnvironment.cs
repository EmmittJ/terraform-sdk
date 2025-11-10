using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for container_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentContainerImageBlock : ITerraformBlock
{
    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformPropertyName("repository")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Repository { get; set; }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksEnvironmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vm_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksEnvironmentVmImageBlock : ITerraformBlock
{
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    [TerraformPropertyName("image_family")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageFamily { get; set; }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    [TerraformPropertyName("image_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageName { get; set; }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

}

/// <summary>
/// Manages a google_notebooks_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNotebooksEnvironment : TerraformResource
{
    public GoogleNotebooksEnvironment(string name) : base("google_notebooks_environment", name)
    {
    }

    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name specified for the Environment instance.
    /// Format: projects/{project_id}/locations/{location}/environments/{environmentId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance fully boots up.
    /// The path must be a URL or Cloud Storage path. Example: &amp;quot;gs://path-to-file/file-name&amp;quot;
    /// </summary>
    [TerraformPropertyName("post_startup_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostStartupScript { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for container_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    [TerraformPropertyName("container_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksEnvironmentContainerImageBlock>>? ContainerImage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNotebooksEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vm_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    [TerraformPropertyName("vm_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksEnvironmentVmImageBlock>>? VmImage { get; set; } = new();

    /// <summary>
    /// Instance creation time
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

}
