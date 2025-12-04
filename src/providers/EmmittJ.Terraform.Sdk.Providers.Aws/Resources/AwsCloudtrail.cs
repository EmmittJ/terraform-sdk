using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in AwsCloudtrail.
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailAdvancedEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_event_selector";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// FieldSelector block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldSelector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldSelector block(s) required")]
    public required TerraformSet<AwsCloudtrailAdvancedEventSelectorBlockFieldSelectorBlock> FieldSelector
    {
        get => GetRequiredArgument<TerraformSet<AwsCloudtrailAdvancedEventSelectorBlockFieldSelectorBlock>>("field_selector");
        set => SetArgument("field_selector", value);
    }

}

/// <summary>
/// Block type for field_selector in AwsCloudtrailAdvancedEventSelectorBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudtrailAdvancedEventSelectorBlockFieldSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_selector";

    /// <summary>
    /// The ends_with attribute.
    /// </summary>
    public TerraformList<string>? EndsWith
    {
        get => GetArgument<TerraformList<string>>("ends_with");
        set => SetArgument("ends_with", value);
    }

    /// <summary>
    /// The equals attribute.
    /// </summary>
    public TerraformList<string>? EqualsAttribute
    {
        get => GetArgument<TerraformList<string>>("equals");
        set => SetArgument("equals", value);
    }

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The not_ends_with attribute.
    /// </summary>
    public TerraformList<string>? NotEndsWith
    {
        get => GetArgument<TerraformList<string>>("not_ends_with");
        set => SetArgument("not_ends_with", value);
    }

    /// <summary>
    /// The not_equals attribute.
    /// </summary>
    public TerraformList<string>? NotEquals
    {
        get => GetArgument<TerraformList<string>>("not_equals");
        set => SetArgument("not_equals", value);
    }

    /// <summary>
    /// The not_starts_with attribute.
    /// </summary>
    public TerraformList<string>? NotStartsWith
    {
        get => GetArgument<TerraformList<string>>("not_starts_with");
        set => SetArgument("not_starts_with", value);
    }

    /// <summary>
    /// The starts_with attribute.
    /// </summary>
    public TerraformList<string>? StartsWith
    {
        get => GetArgument<TerraformList<string>>("starts_with");
        set => SetArgument("starts_with", value);
    }

}


/// <summary>
/// Block type for event_selector in AwsCloudtrail.
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_selector";

    /// <summary>
    /// The exclude_management_event_sources attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeManagementEventSources
    {
        get => GetArgument<TerraformSet<string>>("exclude_management_event_sources");
        set => SetArgument("exclude_management_event_sources", value);
    }

    /// <summary>
    /// The include_management_events attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeManagementEvents
    {
        get => GetArgument<TerraformValue<bool>>("include_management_events");
        set => SetArgument("include_management_events", value);
    }

    /// <summary>
    /// The read_write_type attribute.
    /// </summary>
    public TerraformValue<string>? ReadWriteType
    {
        get => GetArgument<TerraformValue<string>>("read_write_type");
        set => SetArgument("read_write_type", value);
    }

    /// <summary>
    /// DataResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudtrailEventSelectorBlockDataResourceBlock>? DataResource
    {
        get => GetArgument<TerraformList<AwsCloudtrailEventSelectorBlockDataResourceBlock>>("data_resource");
        set => SetArgument("data_resource", value);
    }

}

/// <summary>
/// Block type for data_resource in AwsCloudtrailEventSelectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventSelectorBlockDataResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_resource";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for insight_selector in AwsCloudtrail.
/// Nesting mode: set
/// </summary>
public class AwsCloudtrailInsightSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "insight_selector";

    /// <summary>
    /// The insight_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightType is required")]
    public required TerraformValue<string> InsightType
    {
        get => GetArgument<TerraformValue<string>>("insight_type");
        set => SetArgument("insight_type", value);
    }

}


/// <summary>
/// Represents a aws_cloudtrail Terraform resource.
/// Manages a aws_cloudtrail resource.
/// </summary>
public partial class AwsCloudtrail(string name) : TerraformResource("aws_cloudtrail", name)
{
    /// <summary>
    /// The cloud_watch_logs_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? CloudWatchLogsGroupArn
    {
        get => GetArgument<TerraformValue<string>>("cloud_watch_logs_group_arn");
        set => SetArgument("cloud_watch_logs_group_arn", value);
    }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? CloudWatchLogsRoleArn
    {
        get => GetArgument<TerraformValue<string>>("cloud_watch_logs_role_arn");
        set => SetArgument("cloud_watch_logs_role_arn", value);
    }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    public TerraformValue<bool>? EnableLogFileValidation
    {
        get => GetArgument<TerraformValue<bool>>("enable_log_file_validation");
        set => SetArgument("enable_log_file_validation", value);
    }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformValue<bool>? EnableLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeGlobalServiceEvents
    {
        get => GetArgument<TerraformValue<bool>>("include_global_service_events");
        set => SetArgument("include_global_service_events", value);
    }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    public TerraformValue<bool>? IsMultiRegionTrail
    {
        get => GetArgument<TerraformValue<bool>>("is_multi_region_trail");
        set => SetArgument("is_multi_region_trail", value);
    }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    public TerraformValue<bool>? IsOrganizationTrail
    {
        get => GetArgument<TerraformValue<bool>>("is_organization_trail");
        set => SetArgument("is_organization_trail", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    public TerraformValue<string>? SnsTopicName
    {
        get => GetArgument<TerraformValue<string>>("sns_topic_name");
        set => SetArgument("sns_topic_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    public TerraformValue<string> HomeRegion
        => AsReference("home_region");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => AsReference("sns_topic_arn");

    /// <summary>
    /// AdvancedEventSelector block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCloudtrailAdvancedEventSelectorBlock>? AdvancedEventSelector
    {
        get => GetArgument<TerraformList<AwsCloudtrailAdvancedEventSelectorBlock>>("advanced_event_selector");
        set => SetArgument("advanced_event_selector", value);
    }

    /// <summary>
    /// EventSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EventSelector block(s) allowed")]
    public TerraformList<AwsCloudtrailEventSelectorBlock>? EventSelector
    {
        get => GetArgument<TerraformList<AwsCloudtrailEventSelectorBlock>>("event_selector");
        set => SetArgument("event_selector", value);
    }

    /// <summary>
    /// InsightSelector block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudtrailInsightSelectorBlock>? InsightSelector
    {
        get => GetArgument<TerraformSet<AwsCloudtrailInsightSelectorBlock>>("insight_selector");
        set => SetArgument("insight_selector", value);
    }

}
