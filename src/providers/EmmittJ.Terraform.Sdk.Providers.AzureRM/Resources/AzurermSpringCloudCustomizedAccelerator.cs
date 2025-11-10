using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock : ITerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Branch { get; set; }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CaCertificateId { get; set; }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    [TerraformPropertyName("commit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Commit { get; set; }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    [TerraformPropertyName("git_tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GitTag { get; set; }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock : ITerraformBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AcceleratorTags { get; set; }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformPropertyName("icon_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IconUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    [TerraformPropertyName("spring_cloud_accelerator_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpringCloudAcceleratorId { get; set; }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    [TerraformPropertyName("git_repository")]
    public TerraformList<TerraformBlock<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock>>? GitRepository { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock>? Timeouts { get; set; } = new();

}
