using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in .
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailAdvancedEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for event_selector in .
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// The exclude_management_event_sources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeManagementEventSources
    {
        set => SetProperty("exclude_management_event_sources", value);
    }

    /// <summary>
    /// The include_management_events attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeManagementEvents
    {
        set => SetProperty("include_management_events", value);
    }

    /// <summary>
    /// The read_write_type attribute.
    /// </summary>
    public TerraformProperty<string>? ReadWriteType
    {
        set => SetProperty("read_write_type", value);
    }

}

/// <summary>
/// Block type for insight_selector in .
/// Nesting mode: set
/// </summary>
public class AwsCloudtrailInsightSelectorBlock : TerraformBlock
{
    /// <summary>
    /// The insight_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightType is required")]
    public required TerraformProperty<string> InsightType
    {
        set => SetProperty("insight_type", value);
    }

}

/// <summary>
/// Manages a aws_cloudtrail resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudtrail : TerraformResource
{
    public AwsCloudtrail(string name) : base("aws_cloudtrail", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("home_region");
        SetOutput("sns_topic_arn");
        SetOutput("cloud_watch_logs_group_arn");
        SetOutput("cloud_watch_logs_role_arn");
        SetOutput("enable_log_file_validation");
        SetOutput("enable_logging");
        SetOutput("id");
        SetOutput("include_global_service_events");
        SetOutput("is_multi_region_trail");
        SetOutput("is_organization_trail");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("s3_bucket_name");
        SetOutput("s3_key_prefix");
        SetOutput("sns_topic_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cloud_watch_logs_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> CloudWatchLogsGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_watch_logs_group_arn");
        set => SetProperty("cloud_watch_logs_group_arn", value);
    }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> CloudWatchLogsRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_watch_logs_role_arn");
        set => SetProperty("cloud_watch_logs_role_arn", value);
    }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    public TerraformProperty<bool> EnableLogFileValidation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_log_file_validation");
        set => SetProperty("enable_log_file_validation", value);
    }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformProperty<bool> EnableLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_logging");
        set => SetProperty("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeGlobalServiceEvents
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_global_service_events");
        set => SetProperty("include_global_service_events", value);
    }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    public TerraformProperty<bool> IsMultiRegionTrail
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_multi_region_trail");
        set => SetProperty("is_multi_region_trail", value);
    }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    public TerraformProperty<bool> IsOrganizationTrail
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_organization_trail");
        set => SetProperty("is_organization_trail", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket_name");
        set => SetProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string> S3KeyPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_key_prefix");
        set => SetProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    public TerraformProperty<string> SnsTopicName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sns_topic_name");
        set => SetProperty("sns_topic_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for advanced_event_selector.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudtrailAdvancedEventSelectorBlock>? AdvancedEventSelector
    {
        set => SetProperty("advanced_event_selector", value);
    }

    /// <summary>
    /// Block for event_selector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EventSelector block(s) allowed")]
    public List<AwsCloudtrailEventSelectorBlock>? EventSelector
    {
        set => SetProperty("event_selector", value);
    }

    /// <summary>
    /// Block for insight_selector.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudtrailInsightSelectorBlock>? InsightSelector
    {
        set => SetProperty("insight_selector", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    public TerraformExpression HomeRegion => this["home_region"];

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformExpression SnsTopicArn => this["sns_topic_arn"];

}
