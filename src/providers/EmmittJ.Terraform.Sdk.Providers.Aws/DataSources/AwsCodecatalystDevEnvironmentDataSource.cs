using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock : ITerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [TerraformPropertyName("branch_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BranchName => new TerraformReferenceProperty<TerraformProperty<string>>("", "branch_name");

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [TerraformPropertyName("repository_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RepositoryName => new TerraformReferenceProperty<TerraformProperty<string>>("", "repository_name");

}

/// <summary>
/// Retrieves information about a aws_codecatalyst_dev_environment.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodecatalystDevEnvironmentDataSource : TerraformDataSource
{
    public AwsCodecatalystDevEnvironmentDataSource(string name) : base("aws_codecatalyst_dev_environment", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Alias { get; set; }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    [TerraformPropertyName("creator_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreatorId { get; set; }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    [TerraformPropertyName("env_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnvId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    [TerraformPropertyName("repositories")]
    public TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>>? Repositories { get; set; } = new();

    /// <summary>
    /// The ides attribute.
    /// </summary>
    [TerraformPropertyName("ides")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Ides => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ides");

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("inactivity_timeout_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InactivityTimeoutMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "inactivity_timeout_minutes");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_time");

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    [TerraformPropertyName("persistent_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PersistentStorage => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "persistent_storage");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

}
