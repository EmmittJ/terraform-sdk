using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewFiltersBlock : ITerraformBlock
{
    /// <summary>
    /// The filter_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterString is required")]
    [TerraformPropertyName("filter_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FilterString { get; set; }

}

/// <summary>
/// Block type for included_property in .
/// Nesting mode: list
/// </summary>
public class AwsResourceexplorer2ViewIncludedPropertyBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Manages a aws_resourceexplorer2_view resource.
/// </summary>
public class AwsResourceexplorer2View : TerraformResource
{
    public AwsResourceexplorer2View(string name) : base("aws_resourceexplorer2_view", name)
    {
    }

    /// <summary>
    /// The default_view attribute.
    /// </summary>
    [TerraformPropertyName("default_view")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DefaultView { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "default_view");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Scope { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scope");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filters")]
    public TerraformList<TerraformBlock<AwsResourceexplorer2ViewFiltersBlock>>? Filters { get; set; } = new();

    /// <summary>
    /// Block for included_property.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("included_property")]
    public TerraformList<TerraformBlock<AwsResourceexplorer2ViewIncludedPropertyBlock>>? IncludedProperty { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
