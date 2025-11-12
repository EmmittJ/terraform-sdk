using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmPatchBaselinesDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ssm_patch_baselines.
/// </summary>
public partial class AwsSsmPatchBaselinesDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselinesDataSource(string name) : base("aws_ssm_patch_baselines", name)
    {
    }

    /// <summary>
    /// The default_baselines attribute.
    /// </summary>
    [TerraformProperty("default_baselines")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultBaselines { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformList<AwsSsmPatchBaselinesDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The baseline_identities attribute.
    /// </summary>
    [TerraformProperty("baseline_identities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BaselineIdentities { get; }

}
