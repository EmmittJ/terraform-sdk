using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_function_url.
/// </summary>
public partial class AwsLambdaFunctionUrlDataSource : TerraformDataSource
{
    public AwsLambdaFunctionUrlDataSource(string name) : base("aws_lambda_function_url", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The authorization_type attribute.
    /// </summary>
    [TerraformProperty("authorization_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationType { get; }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformProperty("cors")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Cors { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformProperty("function_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FunctionArn { get; }

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    [TerraformProperty("function_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FunctionUrl { get; }

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    [TerraformProperty("invoke_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvokeMode { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTime { get; }

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    [TerraformProperty("url_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UrlId { get; }

}
