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
    public TerraformLiteralProperty<string>? CloudWatchLogsGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_watch_logs_group_arn");
        set => this.WithProperty("cloud_watch_logs_group_arn", value);
    }

    /// <summary>
    /// The cloud_watch_logs_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CloudWatchLogsRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_watch_logs_role_arn");
        set => this.WithProperty("cloud_watch_logs_role_arn", value);
    }

    /// <summary>
    /// The enable_log_file_validation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableLogFileValidation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_log_file_validation");
        set => this.WithProperty("enable_log_file_validation", value);
    }

    /// <summary>
    /// The enable_logging attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_global_service_events attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeGlobalServiceEvents
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_global_service_events");
        set => this.WithProperty("include_global_service_events", value);
    }

    /// <summary>
    /// The is_multi_region_trail attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsMultiRegionTrail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_multi_region_trail");
        set => this.WithProperty("is_multi_region_trail", value);
    }

    /// <summary>
    /// The is_organization_trail attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsOrganizationTrail
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_organization_trail");
        set => this.WithProperty("is_organization_trail", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_name");
        set => this.WithProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key_prefix");
        set => this.WithProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The sns_topic_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnsTopicName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sns_topic_name");
        set => this.WithProperty("sns_topic_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
