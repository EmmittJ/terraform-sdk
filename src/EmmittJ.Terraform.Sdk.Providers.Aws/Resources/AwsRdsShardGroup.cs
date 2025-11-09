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
    public TerraformProperty<double>? ComputeRedundancy
    {
        get => GetProperty<TerraformProperty<double>>("compute_redundancy");
        set => this.WithProperty("compute_redundancy", value);
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_identifier");
        set => this.WithProperty("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_shard_group_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbShardGroupIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_shard_group_identifier");
        set => this.WithProperty("db_shard_group_identifier", value);
    }

    /// <summary>
    /// The max_acu attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAcu
    {
        get => GetProperty<TerraformProperty<double>>("max_acu");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
