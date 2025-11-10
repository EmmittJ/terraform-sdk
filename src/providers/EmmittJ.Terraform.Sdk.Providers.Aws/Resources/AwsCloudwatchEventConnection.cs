using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionAuthParametersBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for invocation_connectivity_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_cloudwatch_event_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventConnection : TerraformResource
{
    public AwsCloudwatchEventConnection(string name) : base("aws_cloudwatch_event_connection", name)
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    [TerraformPropertyName("authorization_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizationType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyIdentifier { get; set; }

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
    /// Block for auth_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthParameters block(s) allowed")]
    [TerraformPropertyName("auth_parameters")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventConnectionAuthParametersBlock>>? AuthParameters { get; set; } = new();

    /// <summary>
    /// Block for invocation_connectivity_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationConnectivityParameters block(s) allowed")]
    [TerraformPropertyName("invocation_connectivity_parameters")]
    public TerraformList<TerraformBlock<AwsCloudwatchEventConnectionInvocationConnectivityParametersBlock>>? InvocationConnectivityParameters { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_arn");

}
