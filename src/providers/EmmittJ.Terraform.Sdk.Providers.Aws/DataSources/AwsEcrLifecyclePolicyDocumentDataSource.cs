using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ecr_lifecycle_policy_document.
/// </summary>
public class AwsEcrLifecyclePolicyDocumentDataSource : TerraformDataSource
{
    public AwsEcrLifecyclePolicyDocumentDataSource(string name) : base("aws_ecr_lifecycle_policy_document", name)
    {
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rule")]
    public TerraformList<TerraformBlock<AwsEcrLifecyclePolicyDocumentDataSourceRuleBlock>>? Rule { get; set; } = new();

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Json => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "json");

}
