using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecr_authorization_token Terraform data source.
/// Retrieves information about a aws_ecr_authorization_token.
/// </summary>
public partial class AwsEcrAuthorizationTokenDataSource(string name) : TerraformDataSource("aws_ecr_authorization_token", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string>? RegistryId
    {
        get => GetArgument<TerraformValue<string>>("registry_id");
        set => SetArgument("registry_id", value);
    }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationToken
        => AsReference("authorization_token");

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    public TerraformValue<string> ExpiresAt
        => AsReference("expires_at");

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
        => AsReference("password");

    /// <summary>
    /// The proxy_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ProxyEndpoint
        => AsReference("proxy_endpoint");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
        => AsReference("user_name");

}
