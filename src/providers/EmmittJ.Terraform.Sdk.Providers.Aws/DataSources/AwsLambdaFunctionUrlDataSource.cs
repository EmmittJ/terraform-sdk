using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function_url.
/// </summary>
public class AwsLambdaFunctionUrlDataSource : TerraformDataSource
{
    public AwsLambdaFunctionUrlDataSource(string name) : base("aws_lambda_function_url", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The authorization_type attribute.
    /// </summary>
    [TerraformPropertyName("authorization_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizationType => new TerraformReference(this, "authorization_type");

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Cors => new TerraformReference(this, "cors");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformPropertyName("function_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionArn => new TerraformReference(this, "function_arn");

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    [TerraformPropertyName("function_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionUrl => new TerraformReference(this, "function_url");

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    [TerraformPropertyName("invoke_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvokeMode => new TerraformReference(this, "invoke_mode");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedTime => new TerraformReference(this, "last_modified_time");

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    [TerraformPropertyName("url_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UrlId => new TerraformReference(this, "url_id");

}
