using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsShardGroupTimeoutsBlock : TerraformBlock
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
/// Manages a aws_rds_shard_group resource.
/// </summary>
public class AwsRdsShardGroup : TerraformResource
{
    public AwsRdsShardGroup(string name) : base("aws_rds_shard_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("db_shard_group_resource_id");
        this.WithOutput("endpoint");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The compute_redundancy attribute.
    /// </summary>
    public TerraformProperty<double>? ComputeRedundancy
    {
        get => GetProperty<TerraformProperty<double>>("compute_redundancy");
        set => this.WithProperty("compute_redundancy", value);
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformProperty<string> DbClusterIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_cluster_identifier");
        set => this.WithProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_shard_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbShardGroupIdentifier is required")]
    public required TerraformProperty<string> DbShardGroupIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_shard_group_identifier");
        set => this.WithProperty("db_shard_group_identifier", value);
    }

    /// <summary>
    /// The max_acu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAcu is required")]
    public required TerraformProperty<double> MaxAcu
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_acu");
        set => this.WithProperty("max_acu", value);
    }

    /// <summary>
    /// The min_acu attribute.
    /// </summary>
    public TerraformProperty<double>? MinAcu
    {
        get => GetProperty<TerraformProperty<double>>("min_acu");
        set => this.WithProperty("min_acu", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsShardGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRdsShardGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The db_shard_group_resource_id attribute.
    /// </summary>
    public TerraformExpression DbShardGroupResourceId => this["db_shard_group_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
