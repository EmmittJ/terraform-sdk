using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_permission resource.
/// </summary>
public class AwsLambdaPermission : TerraformResource
{
    public AwsLambdaPermission(string name) : base("aws_lambda_permission", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The event_source_token attribute.
    /// </summary>
    [TerraformPropertyName("event_source_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventSourceToken { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The function_url_auth_type attribute.
    /// </summary>
    [TerraformPropertyName("function_url_auth_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FunctionUrlAuthType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// The principal_org_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_org_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrincipalOrgId { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    [TerraformPropertyName("source_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceAccount { get; set; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceArn { get; set; }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [TerraformPropertyName("statement_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StatementId { get; set; } = default!;

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    [TerraformPropertyName("statement_id_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StatementIdPrefix { get; set; } = default!;

}
