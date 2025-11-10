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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("db_shard_group_resource_id");
        SetOutput("endpoint");
        SetOutput("tags_all");
        SetOutput("compute_redundancy");
        SetOutput("db_cluster_identifier");
        SetOutput("db_shard_group_identifier");
        SetOutput("max_acu");
        SetOutput("min_acu");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The compute_redundancy attribute.
    /// </summary>
    public TerraformProperty<double> ComputeRedundancy
    {
        get => GetRequiredOutput<TerraformProperty<double>>("compute_redundancy");
        set => SetProperty("compute_redundancy", value);
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformProperty<string> DbClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_cluster_identifier");
        set => SetProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_shard_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbShardGroupIdentifier is required")]
    public required TerraformProperty<string> DbShardGroupIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_shard_group_identifier");
        set => SetProperty("db_shard_group_identifier", value);
    }

    /// <summary>
    /// The max_acu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAcu is required")]
    public required TerraformProperty<double> MaxAcu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_acu");
        set => SetProperty("max_acu", value);
    }

    /// <summary>
    /// The min_acu attribute.
    /// </summary>
    public TerraformProperty<double> MinAcu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_acu");
        set => SetProperty("min_acu", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsShardGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
