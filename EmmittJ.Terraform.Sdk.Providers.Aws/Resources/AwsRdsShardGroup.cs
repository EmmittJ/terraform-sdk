using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("db_shard_group_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The compute_redundancy attribute.
    /// </summary>
    public double? ComputeRedundancy
    {
        get => GetProperty<TerraformLiteralProperty<double>>("compute_redundancy")?.Value;
        set => this.WithProperty("compute_redundancy", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public string? DbClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_cluster_identifier")?.Value;
        set => this.WithProperty("db_cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_shard_group_identifier attribute.
    /// </summary>
    public string? DbShardGroupIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_shard_group_identifier")?.Value;
        set => this.WithProperty("db_shard_group_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_acu attribute.
    /// </summary>
    public double? MaxAcu
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_acu")?.Value;
        set => this.WithProperty("max_acu", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_acu attribute.
    /// </summary>
    public double? MinAcu
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_acu")?.Value;
        set => this.WithProperty("min_acu", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
