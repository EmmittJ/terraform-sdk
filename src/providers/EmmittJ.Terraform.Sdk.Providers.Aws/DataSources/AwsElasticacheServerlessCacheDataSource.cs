using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elasticache_serverless_cache Terraform data source.
/// Retrieves information about a aws_elasticache_serverless_cache.
/// </summary>
public partial class AwsElasticacheServerlessCacheDataSource(string name) : TerraformDataSource("aws_elasticache_serverless_cache", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    public TerraformMap<object> CacheUsageLimits
        => AsReference("cache_usage_limits");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    public TerraformValue<string> DailySnapshotTime
        => AsReference("daily_snapshot_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformMap<object> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    public TerraformValue<string> FullEngineVersion
        => AsReference("full_engine_version");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MajorEngineVersion
        => AsReference("major_engine_version");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformMap<object> ReaderEndpoint
        => AsReference("reader_endpoint");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
        => AsReference("snapshot_retention_limit");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformList<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    public TerraformValue<string> UserGroupId
        => AsReference("user_group_id");

}
