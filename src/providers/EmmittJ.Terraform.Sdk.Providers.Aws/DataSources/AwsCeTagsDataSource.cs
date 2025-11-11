using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlock
{
}

/// <summary>
/// Block type for sort_by in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceSortByBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [TerraformPropertyName("sort_order")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SortOrder { get; set; }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceTimePeriodBlock
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    [TerraformPropertyName("end")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    [TerraformPropertyName("start")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Start { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformPropertyName("search_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SearchString { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformPropertyName("tag_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagKey { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformPropertyName("filter")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for sort_by.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sort_by")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceSortByBlock>>? SortBy { get; set; }

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    [TerraformPropertyName("time_period")]
    public TerraformList<TerraformBlock<AwsCeTagsDataSourceTimePeriodBlock>>? TimePeriod { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Tags => new TerraformReference(this, "tags");

}
