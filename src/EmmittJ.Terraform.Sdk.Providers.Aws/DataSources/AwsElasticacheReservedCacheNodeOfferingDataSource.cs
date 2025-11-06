using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_reserved_cache_node_offering.
/// </summary>
public class AwsElasticacheReservedCacheNodeOfferingDataSource : TerraformDataSource
{
    public AwsElasticacheReservedCacheNodeOfferingDataSource(string name) : base("aws_elasticache_reserved_cache_node_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fixed_price");
        this.DeclareOutput("offering_id");
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public string? CacheNodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_node_type")?.Value;
        set => this.WithProperty("cache_node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public string? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public string? OfferingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offering_type")?.Value;
        set => this.WithProperty("offering_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public string? ProductDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_description")?.Value;
        set => this.WithProperty("product_description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The fixed_price attribute.
    /// </summary>
    public TerraformExpression FixedPrice => this["fixed_price"];

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformExpression OfferingId => this["offering_id"];

}
