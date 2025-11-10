using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for sort_by in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceSortByBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [TerraformPropertyName("sort_order")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SortOrder { get; set; }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceTimePeriodBlock : ITerraformBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    [TerraformPropertyName("end")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    [TerraformPropertyName("start")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Start { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ce_tags.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCeTagsDataSource : TerraformDataSource
{
    public AwsCeTagsDataSource(string name) : base("aws_ce_tags", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformPropertyName("search_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SearchString { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformPropertyName("tag_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TagKey { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for sort_by.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sort_by")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceSortByBlock>>? SortBy { get; set; } = new();

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    [TerraformPropertyName("time_period")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceTimePeriodBlock>>? TimePeriod { get; set; } = new();

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Tags => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "tags");

}
