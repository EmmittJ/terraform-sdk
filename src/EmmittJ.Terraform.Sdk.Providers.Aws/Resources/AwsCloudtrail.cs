using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudtrail resource.
/// </summary>
public class AwsCloudtrail : TerraformResource
{
    public AwsCloudtrail(string name) : base("aws_cloudtrail", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("home_region");
        this.DeclareOutput("sns_topic_arn");
    }

    /// <summary>
    /// The cloud_watch_logs_group_arn attribute.
    /// </summary>
    public string? CloudWatchLogsGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_watch_logs_group_arn")?.Value;
        set => this.WithProperty("cloud_watch_logs_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    public string? CloudWatchLogsRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_watch_logs_role_arn")?.Value;
        set => this.WithProperty("cloud_watch_logs_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    public bool? EnableLogFileValidation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_log_file_validation")?.Value;
        set => this.WithProperty("enable_log_file_validation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public bool? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging")?.Value;
        set => this.WithProperty("enable_logging", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    public bool? IncludeGlobalServiceEvents
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_global_service_events")?.Value;
        set => this.WithProperty("include_global_service_events", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    public bool? IsMultiRegionTrail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_multi_region_trail")?.Value;
        set => this.WithProperty("is_multi_region_trail", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    public bool? IsOrganizationTrail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_organization_trail")?.Value;
        set => this.WithProperty("is_organization_trail", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public string? S3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_name")?.Value;
        set => this.WithProperty("s3_bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public string? S3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key_prefix")?.Value;
        set => this.WithProperty("s3_key_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    public string? SnsTopicName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sns_topic_name")?.Value;
        set => this.WithProperty("sns_topic_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
