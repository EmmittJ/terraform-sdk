using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsCeTagsDataSourceFilterBlock() : TerraformBlock("filter")
{
}

/// <summary>
/// Block type for sort_by in .
/// Nesting mode: list
/// </summary>
public partial class AwsCeTagsDataSourceSortByBlock() : TerraformBlock("sort_by")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    [TerraformProperty("sort_order")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SortOrder { get; set; }

}

/// <summary>
/// Block type for time_period in .
/// Nesting mode: list
/// </summary>
public partial class AwsCeTagsDataSourceTimePeriodBlock() : TerraformBlock("time_period")
{
    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    [TerraformProperty("end")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> End { get; set; }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    [TerraformProperty("start")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Start { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ce_tags.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCeTagsDataSource : TerraformDataSource
{
    public AwsCeTagsDataSource(string name) : base("aws_ce_tags", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformProperty("search_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SearchString { get; set; }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [TerraformProperty("tag_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagKey { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public TerraformList<AwsCeTagsDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for sort_by.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sort_by")]
    public TerraformList<AwsCeTagsDataSourceSortByBlock> SortBy { get; set; } = new();

    /// <summary>
    /// Block for time_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    [TerraformProperty("time_period")]
    public required TerraformList<AwsCeTagsDataSourceTimePeriodBlock> TimePeriod { get; set; } = new();

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Tags { get; }

}
