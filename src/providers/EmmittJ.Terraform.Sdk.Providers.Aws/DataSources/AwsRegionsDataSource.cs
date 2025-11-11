using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsRegionsDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_regions.
/// </summary>
public partial class AwsRegionsDataSource : TerraformDataSource
{
    public AwsRegionsDataSource(string name) : base("aws_regions", name)
    {
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    [TerraformProperty("all_regions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllRegions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsRegionsDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Names { get; }

}
