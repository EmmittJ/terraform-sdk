using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock() : TerraformBlock("git_repository")
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Branch { get; set; }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CaCertificateId { get; set; }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    [TerraformProperty("commit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Commit { get; set; }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    [TerraformProperty("git_tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GitTag { get; set; }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    [TerraformProperty("accelerator_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AcceleratorTags { get; set; }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformProperty("icon_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IconUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    [TerraformProperty("spring_cloud_accelerator_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudAcceleratorId { get; set; }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformProperty("git_repository")]
    public required TerraformList<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock> GitRepository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock Timeouts { get; set; } = new();

}
