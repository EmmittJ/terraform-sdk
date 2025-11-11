using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53recoveryreadinessCellTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_route53recoveryreadiness_cell resource.
/// </summary>
public partial class AwsRoute53recoveryreadinessCell : TerraformResource
{
    public AwsRoute53recoveryreadinessCell(string name) : base("aws_route53recoveryreadiness_cell", name)
    {
    }

    /// <summary>
    /// The cell_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CellName is required")]
    [TerraformProperty("cell_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CellName { get; set; }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    [TerraformProperty("cells")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Cells { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRoute53recoveryreadinessCellTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The parent_readiness_scopes attribute.
    /// </summary>
    [TerraformProperty("parent_readiness_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ParentReadinessScopes { get; }

}
