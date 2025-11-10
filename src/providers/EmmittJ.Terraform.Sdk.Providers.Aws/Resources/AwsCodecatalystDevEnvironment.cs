using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ides in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentIdesBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Runtime { get; set; }

}

/// <summary>
/// Block type for persistent_storage in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentPersistentStorageBlock : ITerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Size { get; set; }

}

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentRepositoriesBlock : ITerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [TerraformPropertyName("branch_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BranchName { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCodecatalystDevEnvironmentTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_codecatalyst_dev_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodecatalystDevEnvironment : TerraformResource
{
    public AwsCodecatalystDevEnvironment(string name) : base("aws_codecatalyst_dev_environment", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Alias { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("inactivity_timeout_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InactivityTimeoutMinutes { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformPropertyName("project_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    [TerraformPropertyName("space_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpaceName { get; set; }

    /// <summary>
    /// Block for ides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ides is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ides block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ides block(s) allowed")]
    [TerraformPropertyName("ides")]
    public TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentIdesBlock>>? Ides { get; set; } = new();

    /// <summary>
    /// Block for persistent_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentStorage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PersistentStorage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentStorage block(s) allowed")]
    [TerraformPropertyName("persistent_storage")]
    public TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentPersistentStorageBlock>>? PersistentStorage { get; set; } = new();

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    [TerraformPropertyName("repositories")]
    public TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentRepositoriesBlock>>? Repositories { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCodecatalystDevEnvironmentTimeoutsBlock>? Timeouts { get; set; } = new();

}
