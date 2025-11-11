using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsConfigOrganizationCustomRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_config_organization_custom_rule resource.
/// </summary>
public class AwsConfigOrganizationCustomRule : TerraformResource
{
    public AwsConfigOrganizationCustomRule(string name) : base("aws_config_organization_custom_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    [TerraformPropertyName("excluded_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExcludedAccounts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformPropertyName("input_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InputParameters { get; set; }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaFunctionArn is required")]
    [TerraformPropertyName("lambda_function_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LambdaFunctionArn { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformPropertyName("maximum_execution_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaximumExecutionFrequency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_id_scope attribute.
    /// </summary>
    [TerraformPropertyName("resource_id_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceIdScope { get; set; }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    [TerraformPropertyName("resource_types_scope")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ResourceTypesScope { get; set; }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    [TerraformPropertyName("tag_key_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagKeyScope { get; set; }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    [TerraformPropertyName("tag_value_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TagValueScope { get; set; }

    /// <summary>
    /// The trigger_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTypes is required")]
    [TerraformPropertyName("trigger_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> TriggerTypes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsConfigOrganizationCustomRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
