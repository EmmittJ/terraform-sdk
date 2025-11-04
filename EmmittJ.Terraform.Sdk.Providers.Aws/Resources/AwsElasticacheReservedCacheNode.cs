using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticache_reserved_cache_node resource.
/// </summary>
public class AwsElasticacheReservedCacheNode : TerraformResource
{
    public AwsElasticacheReservedCacheNode(string name) : base("aws_elasticache_reserved_cache_node", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cache_node_type");
        this.DeclareOutput("duration");
        this.DeclareOutput("fixed_price");
        this.DeclareOutput("offering_type");
        this.DeclareOutput("product_description");
        this.DeclareOutput("recurring_charges");
        this.DeclareOutput("start_time");
        this.DeclareOutput("state");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("usage_price");
    }

    /// <summary>
    /// The cache_node_count attribute.
    /// </summary>
    public double? CacheNodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cache_node_count")?.Value;
        set => this.WithProperty("cache_node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    public string? ReservedCacheNodesOfferingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reserved_cache_nodes_offering_id")?.Value;
        set => this.WithProperty("reserved_cache_nodes_offering_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformExpression CacheNodeType => this["cache_node_type"];

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformExpression Duration => this["duration"];

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformExpression FixedPrice => this["fixed_price"];

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformExpression OfferingType => this["offering_type"];

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformExpression ProductDescription => this["product_description"];

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformExpression RecurringCharges => this["recurring_charges"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformExpression UsagePrice => this["usage_price"];

}
