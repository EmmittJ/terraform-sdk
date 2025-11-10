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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CloudwatchRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloudwatch_role_arn");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The api_key_version attribute.
    /// </summary>
    [TerraformPropertyName("api_key_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKeyVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key_version");

    /// <summary>
    /// The features attribute.
    /// </summary>
    [TerraformPropertyName("features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Features => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "features");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The throttle_settings attribute.
    /// </summary>
    [TerraformPropertyName("throttle_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ThrottleSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "throttle_settings");

}
