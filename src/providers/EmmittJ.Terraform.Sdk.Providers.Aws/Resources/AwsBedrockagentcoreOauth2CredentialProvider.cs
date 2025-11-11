using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oauth2_provider_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_bedrockagentcore_oauth2_credential_provider resource.
/// </summary>
public partial class AwsBedrockagentcoreOauth2CredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreOauth2CredentialProvider(string name) : base("aws_bedrockagentcore_oauth2_credential_provider", name)
    {
    }

    /// <summary>
    /// The credential_provider_vendor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialProviderVendor is required")]
    [TerraformProperty("credential_provider_vendor")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CredentialProviderVendor { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for oauth2_provider_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("oauth2_provider_config")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>>? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// The client_secret_arn attribute.
    /// </summary>
    [TerraformProperty("client_secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ClientSecretArn { get; }

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformProperty("credential_provider_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CredentialProviderArn { get; }

}
