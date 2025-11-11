using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_permission resource.
/// </summary>
public partial class AwsLambdaPermission : TerraformResource
{
    public AwsLambdaPermission(string name) : base("aws_lambda_permission", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    [TerraformProperty("event_source_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventSourceToken { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    [TerraformProperty("function_url_auth_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FunctionUrlAuthType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    [TerraformProperty("principal_org_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrincipalOrgId { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformProperty("qualifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    [TerraformProperty("source_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceAccount { get; set; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformProperty("source_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceArn { get; set; }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [TerraformProperty("statement_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StatementId { get; set; }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    [TerraformProperty("statement_id_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StatementIdPrefix { get; set; }

}
