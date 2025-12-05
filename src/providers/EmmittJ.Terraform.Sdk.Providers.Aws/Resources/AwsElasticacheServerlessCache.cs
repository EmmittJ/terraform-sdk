using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_usage_limits in AwsElasticacheServerlessCache.
/// Nesting mode: list
/// </summary>
public class AwsElasticacheServerlessCacheCacheUsageLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_usage_limits";

    /// <summary>
    /// DataStorage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlockDataStorageBlock>? DataStorage
    {
        get => GetArgument<TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlockDataStorageBlock>>("data_storage");
        set => SetArgument("data_storage", value);
    }

    /// <summary>
    /// EcpuPerSecond block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlockEcpuPerSecondBlock>? EcpuPerSecond
    {
        get => GetArgument<TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlockEcpuPerSecondBlock>>("ecpu_per_second");
        set => SetArgument("ecpu_per_second", value);
    }

}

/// <summary>
/// Block type for data_storage in AwsElasticacheServerlessCacheCacheUsageLimitsBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticacheServerlessCacheCacheUsageLimitsBlockDataStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_storage";

    /// <summary>
    /// The maximum attribute.
    /// </summary>
    public TerraformValue<double> Maximum
    {
        get => GetArgument<TerraformValue<double>>("maximum") ?? CreateReference("maximum");
        set => SetArgument("maximum", value);
    }

    /// <summary>
    /// The minimum attribute.
    /// </summary>
    public TerraformValue<double> Minimum
    {
        get => GetArgument<TerraformValue<double>>("minimum") ?? CreateReference("minimum");
        set => SetArgument("minimum", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

}

/// <summary>
/// Block type for ecpu_per_second in AwsElasticacheServerlessCacheCacheUsageLimitsBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticacheServerlessCacheCacheUsageLimitsBlockEcpuPerSecondBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecpu_per_second";

    /// <summary>
    /// The maximum attribute.
    /// </summary>
    public TerraformValue<double> Maximum
    {
        get => GetArgument<TerraformValue<double>>("maximum") ?? CreateReference("maximum");
        set => SetArgument("maximum", value);
    }

    /// <summary>
    /// The minimum attribute.
    /// </summary>
    public TerraformValue<double> Minimum
    {
        get => GetArgument<TerraformValue<double>>("minimum") ?? CreateReference("minimum");
        set => SetArgument("minimum", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsElasticacheServerlessCache.
/// Nesting mode: single
/// </summary>
public class AwsElasticacheServerlessCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_elasticache_serverless_cache Terraform resource.
/// Manages a aws_elasticache_serverless_cache resource.
/// </summary>
public partial class AwsElasticacheServerlessCache(string name) : TerraformResource("aws_elasticache_serverless_cache", name)
{
    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    public TerraformValue<string> DailySnapshotTime
    {
        get => GetArgument<TerraformValue<string>>("daily_snapshot_time") ?? CreateReference("daily_snapshot_time");
        set => SetArgument("daily_snapshot_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? CreateReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
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
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformValue<string> MajorEngineVersion
    {
        get => GetArgument<TerraformValue<string>>("major_engine_version") ?? CreateReference("major_engine_version");
        set => SetArgument("major_engine_version", value);
    }

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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? CreateReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns_to_restore attribute.
    /// </summary>
    public TerraformList<string>? SnapshotArnsToRestore
    {
        get => GetArgument<TerraformList<string>>("snapshot_arns_to_restore");
        set => SetArgument("snapshot_arns_to_restore", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => GetArgument<TerraformValue<double>>("snapshot_retention_limit") ?? CreateReference("snapshot_retention_limit");
        set => SetArgument("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids") ?? CreateReference("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
    /// The user_group_id attribute.
    /// </summary>
    public TerraformValue<string>? UserGroupId
    {
        get => GetArgument<TerraformValue<string>>("user_group_id");
        set => SetArgument("user_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    public TerraformValue<string> FullEngineVersion
        => CreateReference("full_engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ReaderEndpoint
        => CreateReference("reader_endpoint");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// CacheUsageLimits block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlock>? CacheUsageLimits
    {
        get => GetArgument<TerraformList<AwsElasticacheServerlessCacheCacheUsageLimitsBlock>>("cache_usage_limits");
        set => SetArgument("cache_usage_limits", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheServerlessCacheTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheServerlessCacheTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
