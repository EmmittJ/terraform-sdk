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
    public TerraformProperty<TerraformProperty<string>>? ApiKey { get; set; }

    /// <summary>
    /// The api_key_wo attribute.
    /// </summary>
    [TerraformPropertyName("api_key_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiKeyWo { get; set; }

    /// <summary>
    /// The api_key_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("api_key_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ApiKeyWoVersion { get; set; }

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
    /// The api_key_secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("api_key_secret_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ApiKeySecretArn => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "api_key_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformPropertyName("credential_provider_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CredentialProviderArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "credential_provider_arn");

}
