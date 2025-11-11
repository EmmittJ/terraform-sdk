using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventConnectionAuthParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for invocation_connectivity_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchEventConnection : TerraformResource
{
    public AwsCloudwatchEventConnection(string name) : base("aws_cloudwatch_event_connection", name)
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    [TerraformProperty("authorization_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizationType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyIdentifier { get; set; }

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
    /// Block for auth_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthParameters block(s) allowed")]
    [TerraformProperty("auth_parameters")]
    public partial TerraformList<TerraformBlock<AwsCloudwatchEventConnectionAuthParametersBlock>>? AuthParameters { get; set; }

    /// <summary>
    /// Block for invocation_connectivity_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationConnectivityParameters block(s) allowed")]
    [TerraformProperty("invocation_connectivity_parameters")]
    public partial TerraformList<TerraformBlock<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>>? InvocationConnectivityParameters { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretArn { get; }

}
