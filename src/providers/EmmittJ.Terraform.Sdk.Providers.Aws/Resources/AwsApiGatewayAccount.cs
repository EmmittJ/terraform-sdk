using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_account resource.
/// </summary>
public partial class AwsApiGatewayAccount : TerraformResource
{
    public AwsApiGatewayAccount(string name) : base("aws_api_gateway_account", name)
    {
    }

    /// <summary>
    /// The cloudwatch_role_arn attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CloudwatchRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The api_key_version attribute.
    /// </summary>
    [TerraformProperty("api_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiKeyVersion { get; }

    /// <summary>
    /// The features attribute.
    /// </summary>
    [TerraformProperty("features")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Features { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The throttle_settings attribute.
    /// </summary>
    [TerraformProperty("throttle_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ThrottleSettings { get; }

}
