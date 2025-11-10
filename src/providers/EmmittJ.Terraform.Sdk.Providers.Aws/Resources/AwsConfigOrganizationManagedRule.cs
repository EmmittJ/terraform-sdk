using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationManagedRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_config_organization_managed_rule resource.
/// </summary>
public class AwsConfigOrganizationManagedRule : TerraformResource
{
    public AwsConfigOrganizationManagedRule(string name) : base("aws_config_organization_managed_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    [TerraformPropertyName("excluded_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludedAccounts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformPropertyName("input_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InputParameters { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformPropertyName("maximum_execution_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaximumExecutionFrequency { get; set; }

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
    /// The resource_id_scope attribute.
    /// </summary>
    [TerraformPropertyName("resource_id_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceIdScope { get; set; }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    [TerraformPropertyName("resource_types_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ResourceTypesScope { get; set; }

    /// <summary>
    /// The rule_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIdentifier is required")]
    [TerraformPropertyName("rule_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleIdentifier { get; set; }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    [TerraformPropertyName("tag_key_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TagKeyScope { get; set; }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    [TerraformPropertyName("tag_value_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TagValueScope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsConfigOrganizationManagedRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
