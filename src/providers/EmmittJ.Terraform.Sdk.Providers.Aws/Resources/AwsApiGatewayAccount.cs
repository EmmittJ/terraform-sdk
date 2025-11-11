using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_account resource.
/// </summary>
public class AwsApiGatewayAccount : TerraformResource
{
    public AwsApiGatewayAccount(string name) : base("aws_api_gateway_account", name)
    {
    }

    /// <summary>
    /// The cloudwatch_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CloudwatchRoleArn { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The api_key_version attribute.
    /// </summary>
    [TerraformPropertyName("api_key_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiKeyVersion => new TerraformReference(this, "api_key_version");

    /// <summary>
    /// The features attribute.
    /// </summary>
    [TerraformPropertyName("features")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Features => new TerraformReference(this, "features");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The throttle_settings attribute.
    /// </summary>
    [TerraformPropertyName("throttle_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ThrottleSettings => new TerraformReference(this, "throttle_settings");

}
