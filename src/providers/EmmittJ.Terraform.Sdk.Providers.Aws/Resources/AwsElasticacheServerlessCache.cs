using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cache_usage_limits in .
/// Nesting mode: list
/// </summary>
public class AwsElasticacheServerlessCacheCacheUsageLimitsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheServerlessCacheTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_elasticache_serverless_cache resource.
/// </summary>
public class AwsElasticacheServerlessCache : TerraformResource
{
    public AwsElasticacheServerlessCache(string name) : base("aws_elasticache_serverless_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("create_time");
        this.WithOutput("endpoint");
        this.WithOutput("full_engine_version");
        this.WithOutput("id");
        this.WithOutput("reader_endpoint");
        this.WithOutput("status");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    public TerraformProperty<string>? DailySnapshotTime
    {
        get => GetProperty<TerraformProperty<string>>("daily_snapshot_time");
        set => this.WithProperty("daily_snapshot_time", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? MajorEngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("major_engine_version");
        set => this.WithProperty("major_engine_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns_to_restore attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SnapshotArnsToRestore
    {
        get => GetProperty<List<TerraformProperty<string>>>("snapshot_arns_to_restore");
        set => this.WithProperty("snapshot_arns_to_restore", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformProperty<double>? SnapshotRetentionLimit
    {
        get => GetProperty<TerraformProperty<double>>("snapshot_retention_limit");
        set => this.WithProperty("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserGroupId
    {
        get => GetProperty<TerraformProperty<string>>("user_group_id");
        set => this.WithProperty("user_group_id", value);
    }

    /// <summary>
    /// Block for cache_usage_limits.
    /// Nesting mode: list
    /// </summary>
    public List<AwsElasticacheServerlessCacheCacheUsageLimitsBlock>? CacheUsageLimits
    {
        get => GetProperty<List<AwsElasticacheServerlessCacheCacheUsageLimitsBlock>>("cache_usage_limits");
        set => this.WithProperty("cache_usage_limits", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticacheServerlessCacheTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElasticacheServerlessCacheTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    public TerraformExpression FullEngineVersion => this["full_engine_version"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
