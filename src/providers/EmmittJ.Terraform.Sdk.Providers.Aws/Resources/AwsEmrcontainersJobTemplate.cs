using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for job_template_data in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrcontainersJobTemplateJobTemplateDataBlock() : TerraformBlock("job_template_data")
{
    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    [TerraformProperty("job_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? JobTags { get; set; }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformProperty("release_label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReleaseLabel { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEmrcontainersJobTemplateTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_emrcontainers_job_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrcontainersJobTemplate : TerraformResource
{
    public AwsEmrcontainersJobTemplate(string name) : base("aws_emrcontainers_job_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for job_template_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTemplateData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobTemplateData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobTemplateData block(s) allowed")]
    [TerraformProperty("job_template_data")]
    public required TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlock> JobTemplateData { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEmrcontainersJobTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
