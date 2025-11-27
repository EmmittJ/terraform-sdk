using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elasticache_reserved_cache_node_offering Terraform data source.
/// Retrieves information about a aws_elasticache_reserved_cache_node_offering.
/// </summary>
public partial class AwsElasticacheReservedCacheNodeOfferingDataSource(string name) : TerraformDataSource("aws_elasticache_reserved_cache_node_offering", name)
{
    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNodeType is required")]
    public required TerraformValue<string> CacheNodeType
    {
        get => new TerraformReference<string>(this, "cache_node_type");
        set => SetArgument("cache_node_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    public required TerraformValue<string> OfferingType
    {
        get => new TerraformReference<string>(this, "offering_type");
        set => SetArgument("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    public required TerraformValue<string> ProductDescription
    {
        get => new TerraformReference<string>(this, "product_description");
        set => SetArgument("product_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
    {
        get => new TerraformReference<double>(this, "fixed_price");
    }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformValue<string> OfferingId
    {
        get => new TerraformReference<string>(this, "offering_id");
    }

}
