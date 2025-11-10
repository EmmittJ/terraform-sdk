using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_serverless_cache.
/// </summary>
public class AwsElasticacheServerlessCacheDataSource : TerraformDataSource
{
    public AwsElasticacheServerlessCacheDataSource(string name) : base("aws_elasticache_serverless_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cache_usage_limits");
        SetOutput("create_time");
        SetOutput("daily_snapshot_time");
        SetOutput("description");
        SetOutput("endpoint");
        SetOutput("engine");
        SetOutput("full_engine_version");
        SetOutput("kms_key_id");
        SetOutput("major_engine_version");
        SetOutput("reader_endpoint");
        SetOutput("security_group_ids");
        SetOutput("snapshot_retention_limit");
        SetOutput("status");
        SetOutput("subnet_ids");
        SetOutput("user_group_id");
        SetOutput("name");
        SetOutput("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    public TerraformExpression CacheUsageLimits => this["cache_usage_limits"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    public TerraformExpression DailySnapshotTime => this["daily_snapshot_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    public TerraformExpression FullEngineVersion => this["full_engine_version"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformExpression MajorEngineVersion => this["major_engine_version"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformExpression SnapshotRetentionLimit => this["snapshot_retention_limit"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    public TerraformExpression UserGroupId => this["user_group_id"];

}
