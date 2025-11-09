using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("full_engine_version");
        this.DeclareOutput("id");
        this.DeclareOutput("reader_endpoint");
        this.DeclareOutput("status");
        this.DeclareOutput("tags_all");
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
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
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
    public TerraformProperty<string>? Name
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns_to_restore attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SnapshotArnsToRestore
    {
        get => GetProperty<TerraformProperty<List<string>>>("snapshot_arns_to_restore");
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
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
