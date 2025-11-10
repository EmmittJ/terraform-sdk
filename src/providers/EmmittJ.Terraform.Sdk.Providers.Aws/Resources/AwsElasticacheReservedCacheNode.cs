using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReservedCacheNodeTimeoutsBlock : TerraformBlock
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
    public TerraformProperty<double>? CacheNodeCount
    {
        get => GetProperty<TerraformProperty<double>>("cache_node_count");
        set => this.WithProperty("cache_node_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    public required TerraformProperty<string> ReservedCacheNodesOfferingId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reserved_cache_nodes_offering_id");
        set => this.WithProperty("reserved_cache_nodes_offering_id", value);
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
    public AwsElasticacheReservedCacheNodeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElasticacheReservedCacheNodeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
