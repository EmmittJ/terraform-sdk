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
        this.DeclareOutput("arn");
        this.DeclareOutput("cache_usage_limits");
        this.DeclareOutput("create_time");
        this.DeclareOutput("daily_snapshot_time");
        this.DeclareOutput("description");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine");
        this.DeclareOutput("full_engine_version");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("major_engine_version");
        this.DeclareOutput("reader_endpoint");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("snapshot_retention_limit");
        this.DeclareOutput("status");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("user_group_id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
