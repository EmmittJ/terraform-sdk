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
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [TerraformPropertyName("authorization_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorization_type");

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Cors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformPropertyName("function_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FunctionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "function_arn");

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    [TerraformPropertyName("function_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FunctionUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "function_url");

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    [TerraformPropertyName("invoke_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvokeMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invoke_mode");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_time");

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    [TerraformPropertyName("url_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UrlId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url_id");

}
