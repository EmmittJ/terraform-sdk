using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrockagentcore_api_key_credential_provider Terraform resource.
/// Manages a aws_bedrockagentcore_api_key_credential_provider resource.
/// </summary>
public partial class AwsBedrockagentcoreApiKeyCredentialProvider(string name) : TerraformResource("aws_bedrockagentcore_api_key_credential_provider", name)
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string>? ApiKey
    {
        get => GetArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The api_key_wo attribute.
    /// </summary>
    public TerraformValue<string>? ApiKeyWo
    {
        get => GetArgument<TerraformValue<string>>("api_key_wo");
        set => SetArgument("api_key_wo", value);
    }

    /// <summary>
    /// The api_key_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ApiKeyWoVersion
    {
        get => GetArgument<TerraformValue<double>>("api_key_wo_version");
        set => SetArgument("api_key_wo_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The api_key_secret_arn attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApiKeySecretArn
        => AsReference("api_key_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    public TerraformValue<string> CredentialProviderArn
        => AsReference("credential_provider_arn");

}
