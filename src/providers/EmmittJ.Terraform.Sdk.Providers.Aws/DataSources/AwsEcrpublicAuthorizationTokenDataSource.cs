using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecrpublic_authorization_token Terraform data source.
/// Retrieves information about a aws_ecrpublic_authorization_token.
/// </summary>
public partial class AwsEcrpublicAuthorizationTokenDataSource(string name) : TerraformDataSource("aws_ecrpublic_authorization_token", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationToken
    {
        get => new TerraformReference<string>(this, "authorization_token");
    }

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    public TerraformValue<string> ExpiresAt
    {
        get => new TerraformReference<string>(this, "expires_at");
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
    }

}
