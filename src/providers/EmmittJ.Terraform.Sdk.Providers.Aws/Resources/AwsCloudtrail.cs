using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudtrailAdvancedEventSelectorBlock() : TerraformBlock("advanced_event_selector")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for event_selector in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudtrailEventSelectorBlock() : TerraformBlock("event_selector")
{
    /// <summary>
    /// The exclude_management_event_sources attribute.
    /// </summary>
    [TerraformProperty("exclude_management_event_sources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ExcludeManagementEventSources { get; set; }

    /// <summary>
    /// The include_management_events attribute.
    /// </summary>
    [TerraformProperty("include_management_events")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeManagementEvents { get; set; }

    /// <summary>
    /// The read_write_type attribute.
    /// </summary>
    [TerraformProperty("read_write_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReadWriteType { get; set; }

}

/// <summary>
/// Block type for insight_selector in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudtrailInsightSelectorBlock() : TerraformBlock("insight_selector")
{
    /// <summary>
    /// The insight_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightType is required")]
    [TerraformProperty("insight_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InsightType { get; set; }

}

/// <summary>
/// Manages a aws_cloudtrail resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudtrail : TerraformResource
{
    public AwsCloudtrail(string name) : base("aws_cloudtrail", name)
    {
    }

    /// <summary>
    /// The cloud_watch_logs_group_arn attribute.
    /// </summary>
    [TerraformProperty("cloud_watch_logs_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudWatchLogsGroupArn { get; set; }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    [TerraformProperty("cloud_watch_logs_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudWatchLogsRoleArn { get; set; }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    [TerraformProperty("enable_log_file_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableLogFileValidation { get; set; }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    [TerraformProperty("enable_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    [TerraformProperty("include_global_service_events")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeGlobalServiceEvents { get; set; }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    [TerraformProperty("is_multi_region_trail")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsMultiRegionTrail { get; set; }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    [TerraformProperty("is_organization_trail")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsOrganizationTrail { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

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
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    [TerraformProperty("sns_topic_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnsTopicName { get; set; }

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
    /// Block for advanced_event_selector.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("advanced_event_selector")]
    public TerraformList<AwsCloudtrailAdvancedEventSelectorBlock> AdvancedEventSelector { get; set; } = new();

    /// <summary>
    /// Block for event_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EventSelector block(s) allowed")]
    [TerraformProperty("event_selector")]
    public TerraformList<AwsCloudtrailEventSelectorBlock> EventSelector { get; set; } = new();

    /// <summary>
    /// Block for insight_selector.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("insight_selector")]
    public TerraformSet<AwsCloudtrailInsightSelectorBlock> InsightSelector { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    [TerraformProperty("home_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HomeRegion { get; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnsTopicArn { get; }

}
