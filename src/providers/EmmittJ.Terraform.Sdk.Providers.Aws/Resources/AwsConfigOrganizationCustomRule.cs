using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsConfigOrganizationCustomRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_config_organization_custom_rule resource.
/// </summary>
public partial class AwsConfigOrganizationCustomRule : TerraformResource
{
    public AwsConfigOrganizationCustomRule(string name) : base("aws_config_organization_custom_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    [TerraformProperty("excluded_accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ExcludedAccounts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    [TerraformProperty("input_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputParameters { get; set; }

    /// <summary>
    /// The lambda_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaFunctionArn is required")]
    [TerraformProperty("lambda_function_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LambdaFunctionArn { get; set; }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    [TerraformProperty("maximum_execution_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaximumExecutionFrequency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_id_scope attribute.
    /// </summary>
    [TerraformProperty("resource_id_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceIdScope { get; set; }

    /// <summary>
    /// The resource_types_scope attribute.
    /// </summary>
    [TerraformProperty("resource_types_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ResourceTypesScope { get; set; }

    /// <summary>
    /// The tag_key_scope attribute.
    /// </summary>
    [TerraformProperty("tag_key_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagKeyScope { get; set; }

    /// <summary>
    /// The tag_value_scope attribute.
    /// </summary>
    [TerraformProperty("tag_value_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TagValueScope { get; set; }

    /// <summary>
    /// The trigger_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerTypes is required")]
    [TerraformProperty("trigger_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> TriggerTypes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsConfigOrganizationCustomRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
