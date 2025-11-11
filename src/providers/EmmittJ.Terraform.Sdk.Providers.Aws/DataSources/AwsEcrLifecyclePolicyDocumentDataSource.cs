using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ecr_lifecycle_policy_document.
/// </summary>
public partial class AwsEcrLifecyclePolicyDocumentDataSource : TerraformDataSource
{
    public AwsEcrLifecyclePolicyDocumentDataSource(string name) : base("aws_ecr_lifecycle_policy_document", name)
    {
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("rule")]
    public TerraformList<TerraformBlock<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Json { get; }

}
