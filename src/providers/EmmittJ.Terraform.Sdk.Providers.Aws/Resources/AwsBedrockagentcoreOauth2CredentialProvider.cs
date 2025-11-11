using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oauth2_provider_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock
{
}

/// <summary>
/// Manages a aws_bedrockagentcore_oauth2_credential_provider resource.
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreOauth2CredentialProvider(string name) : base("aws_bedrockagentcore_oauth2_credential_provider", name)
    {
    }

    /// <summary>
    /// The credential_provider_vendor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialProviderVendor is required")]
    [TerraformPropertyName("credential_provider_vendor")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CredentialProviderVendor { get; set; }

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
    /// Block for oauth2_provider_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("oauth2_provider_config")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>>? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// The client_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("client_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClientSecretArn => new TerraformReference(this, "client_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_provider_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CredentialProviderArn => new TerraformReference(this, "credential_provider_arn");

}
