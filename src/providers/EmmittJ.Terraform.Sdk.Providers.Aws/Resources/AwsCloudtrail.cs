using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in .
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailAdvancedEventSelectorBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

}

/// <summary>
/// Block type for event_selector in .
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventSelectorBlock : ITerraformBlock
{
    /// <summary>
    /// The exclude_management_event_sources attribute.
    /// </summary>
    [TerraformPropertyName("exclude_management_event_sources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludeManagementEventSources { get; set; }

    /// <summary>
    /// The include_management_events attribute.
    /// </summary>
    [TerraformPropertyName("include_management_events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeManagementEvents { get; set; }

    /// <summary>
    /// The read_write_type attribute.
    /// </summary>
    [TerraformPropertyName("read_write_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReadWriteType { get; set; }

}

/// <summary>
/// Block type for insight_selector in .
/// Nesting mode: set
/// </summary>
public class AwsCloudtrailInsightSelectorBlock : ITerraformBlock
{
    /// <summary>
    /// The insight_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightType is required")]
    [TerraformPropertyName("insight_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InsightType { get; set; }

}

/// <summary>
/// Manages a aws_cloudtrail resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudtrail : TerraformResource
{
    public AwsCloudtrail(string name) : base("aws_cloudtrail", name)
    {
    }

    /// <summary>
    /// The cloud_watch_logs_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloud_watch_logs_group_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudWatchLogsGroupArn { get; set; }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloud_watch_logs_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudWatchLogsRoleArn { get; set; }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    [TerraformPropertyName("enable_log_file_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLogFileValidation { get; set; }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    [TerraformPropertyName("enable_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableLogging { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    [TerraformPropertyName("include_global_service_events")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeGlobalServiceEvents { get; set; }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    [TerraformPropertyName("is_multi_region_trail")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsMultiRegionTrail { get; set; }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    [TerraformPropertyName("is_organization_trail")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsOrganizationTrail { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnsTopicName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for advanced_event_selector.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("advanced_event_selector")]
    public TerraformList<TerraformBlock<AwsCloudtrailAdvancedEventSelectorBlock>>? AdvancedEventSelector { get; set; } = new();

    /// <summary>
    /// Block for event_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EventSelector block(s) allowed")]
    [TerraformPropertyName("event_selector")]
    public TerraformList<TerraformBlock<AwsCloudtrailEventSelectorBlock>>? EventSelector { get; set; } = new();

    /// <summary>
    /// Block for insight_selector.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("insight_selector")]
    public TerraformSet<TerraformBlock<AwsCloudtrailInsightSelectorBlock>>? InsightSelector { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomeRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "home_region");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SnsTopicArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sns_topic_arn");

}
