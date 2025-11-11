using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock : TerraformBlockBase
{


}

/// <summary>
/// Retrieves information about a aws_codecatalyst_dev_environment.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodecatalystDevEnvironmentDataSource : TerraformDataSource
{
    public AwsCodecatalystDevEnvironmentDataSource(string name) : base("aws_codecatalyst_dev_environment", name)
    {
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Alias { get; set; }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    [TerraformProperty("creator_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreatorId { get; set; }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    [TerraformProperty("env_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnvId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    [TerraformProperty("repositories")]
    public partial TerraformList<TerraformBlock<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>>? Repositories { get; set; }

    /// <summary>
    /// The ides attribute.
    /// </summary>
    [TerraformProperty("ides")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Ides { get; }

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("inactivity_timeout_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> InactivityTimeoutMinutes { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedTime { get; }

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    [TerraformProperty("persistent_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PersistentStorage { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

}
