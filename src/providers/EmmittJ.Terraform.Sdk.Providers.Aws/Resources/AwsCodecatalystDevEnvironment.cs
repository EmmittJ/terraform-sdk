using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ides in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodecatalystDevEnvironmentIdesBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformProperty("runtime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Runtime { get; set; }

}

/// <summary>
/// Block type for persistent_storage in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodecatalystDevEnvironmentPersistentStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Size { get; set; }

}

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodecatalystDevEnvironmentRepositoriesBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [TerraformProperty("branch_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BranchName { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCodecatalystDevEnvironmentTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_codecatalyst_dev_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodecatalystDevEnvironment : TerraformResource
{
    public AwsCodecatalystDevEnvironment(string name) : base("aws_codecatalyst_dev_environment", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Alias { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("inactivity_timeout_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InactivityTimeoutMinutes { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformProperty("project_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    [TerraformProperty("space_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpaceName { get; set; }

    /// <summary>
    /// Block for ides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ides is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ides block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ides block(s) allowed")]
    [TerraformProperty("ides")]
    public partial TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentIdesBlock>>? Ides { get; set; }

    /// <summary>
    /// Block for persistent_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentStorage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PersistentStorage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentStorage block(s) allowed")]
    [TerraformProperty("persistent_storage")]
    public partial TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentPersistentStorageBlock>>? PersistentStorage { get; set; }

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    [TerraformProperty("repositories")]
    public partial TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentRepositoriesBlock>>? Repositories { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsCodecatalystDevEnvironmentTimeoutsBlock>? Timeouts { get; set; }

}
