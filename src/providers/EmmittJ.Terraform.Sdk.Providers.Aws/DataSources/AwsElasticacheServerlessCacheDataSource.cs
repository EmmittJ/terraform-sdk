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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    public TerraformMap<object> CacheUsageLimits
    {
        get => TerraformMap<object>.Lazy(ctx => new TerraformReference<TerraformMap<object>>(this, "cache_usage_limits").ResolveNodes(ctx));
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    public TerraformValue<string> DailySnapshotTime
    {
        get => new TerraformReference<string>(this, "daily_snapshot_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformMap<object> Endpoint
    {
        get => TerraformMap<object>.Lazy(ctx => new TerraformReference<TerraformMap<object>>(this, "endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    public TerraformValue<string> FullEngineVersion
    {
        get => new TerraformReference<string>(this, "full_engine_version");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MajorEngineVersion
    {
        get => new TerraformReference<string>(this, "major_engine_version");
    }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformMap<object> ReaderEndpoint
    {
        get => TerraformMap<object>.Lazy(ctx => new TerraformReference<TerraformMap<object>>(this, "reader_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformList<string> SecurityGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformList<string> SubnetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    public TerraformValue<string> UserGroupId
    {
        get => new TerraformReference<string>(this, "user_group_id");
    }

}
