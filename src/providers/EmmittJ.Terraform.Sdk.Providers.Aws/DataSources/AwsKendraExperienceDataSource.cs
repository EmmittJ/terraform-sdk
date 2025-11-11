using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_experience.
/// </summary>
public partial class AwsKendraExperienceDataSource : TerraformDataSource
{
    public AwsKendraExperienceDataSource(string name) : base("aws_kendra_experience", name)
    {
    }

    /// <summary>
    /// The experience_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExperienceId is required")]
    [TerraformProperty("experience_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExperienceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    [TerraformProperty("index_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IndexId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformProperty("configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Configuration { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Endpoints { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdatedAt { get; }

}
