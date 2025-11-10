using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oauth2_provider_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> CredentialProviderVendor { get; set; }

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
    /// Block for oauth2_provider_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("oauth2_provider_config")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>>? Oauth2ProviderConfig { get; set; } = new();

    /// <summary>
    /// The client_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("client_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClientSecretArn => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "client_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_provider_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CredentialProviderArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "credential_provider_arn");

}
