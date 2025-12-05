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
        get => GetRequiredArgument<TerraformValue<string>>("cache_node_type");
        set => SetArgument("cache_node_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    public required TerraformValue<string> OfferingType
    {
        get => GetRequiredArgument<TerraformValue<string>>("offering_type");
        set => SetArgument("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    public required TerraformValue<string> ProductDescription
    {
        get => GetRequiredArgument<TerraformValue<string>>("product_description");
        set => SetArgument("product_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
        => CreateReference("fixed_price");

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformValue<string> OfferingId
        => CreateReference("offering_id");

}
