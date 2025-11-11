using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_api_key_credential_provider resource.
/// </summary>
public class AwsBedrockagentcoreApiKeyCredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreApiKeyCredentialProvider(string name) : base("aws_bedrockagentcore_api_key_credential_provider", name)
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiKey { get; set; }

    /// <summary>
    /// The api_key_wo attribute.
    /// </summary>
    [TerraformPropertyName("api_key_wo")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiKeyWo { get; set; }

    /// <summary>
    /// The api_key_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("api_key_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ApiKeyWoVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The api_key_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("api_key_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ApiKeySecretArn => new TerraformReference(this, "api_key_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_provider_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CredentialProviderArn => new TerraformReference(this, "credential_provider_arn");

}
