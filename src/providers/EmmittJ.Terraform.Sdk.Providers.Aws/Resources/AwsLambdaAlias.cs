using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for routing_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaAliasRoutingConfigBlock() : TerraformBlock("routing_config")
{
    /// <summary>
    /// The additional_version_weights attribute.
    /// </summary>
    [TerraformProperty("additional_version_weights")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<double>? AdditionalVersionWeights { get; set; }

}

/// <summary>
/// Manages a aws_lambda_alias resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaAlias : TerraformResource
{
    public AwsLambdaAlias(string name) : base("aws_lambda_alias", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The function_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionVersion is required")]
    [TerraformProperty("function_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for routing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    [TerraformProperty("routing_config")]
    public TerraformList<AwsLambdaAliasRoutingConfigBlock> RoutingConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The invoke_arn attribute.
    /// </summary>
    [TerraformProperty("invoke_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvokeArn { get; }

}
