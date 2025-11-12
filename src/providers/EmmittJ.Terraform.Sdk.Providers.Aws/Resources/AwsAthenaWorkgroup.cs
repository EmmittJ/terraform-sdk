using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAthenaWorkgroupConfigurationBlock() : TerraformBlock("configuration")
{
    /// <summary>
    /// The bytes_scanned_cutoff_per_query attribute.
    /// </summary>
    [TerraformProperty("bytes_scanned_cutoff_per_query")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>
    /// The enforce_workgroup_configuration attribute.
    /// </summary>
    [TerraformProperty("enforce_workgroup_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformProperty("execution_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRole { get; set; }

    /// <summary>
    /// The publish_cloudwatch_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("publish_cloudwatch_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The requester_pays_enabled attribute.
    /// </summary>
    [TerraformProperty("requester_pays_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequesterPaysEnabled { get; set; }

}

/// <summary>
/// Manages a aws_athena_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAthenaWorkgroup : TerraformResource
{
    public AwsAthenaWorkgroup(string name) : base("aws_athena_workgroup", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformProperty("configuration")]
    public TerraformList<AwsAthenaWorkgroupConfigurationBlock> Configuration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
