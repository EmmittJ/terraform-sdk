using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_api_key_credential_provider resource.
/// </summary>
public partial class AwsBedrockagentcoreApiKeyCredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreApiKeyCredentialProvider(string name) : base("aws_bedrockagentcore_api_key_credential_provider", name)
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformProperty("api_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiKey { get; set; }

    /// <summary>
    /// The api_key_wo attribute.
    /// </summary>
    [TerraformProperty("api_key_wo")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiKeyWo { get; set; }

    /// <summary>
    /// The api_key_wo_version attribute.
    /// </summary>
    [TerraformProperty("api_key_wo_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ApiKeyWoVersion { get; set; }

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
    /// The api_key_secret_arn attribute.
    /// </summary>
    [TerraformProperty("api_key_secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ApiKeySecretArn { get; }

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    [TerraformProperty("credential_provider_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CredentialProviderArn { get; }

}
