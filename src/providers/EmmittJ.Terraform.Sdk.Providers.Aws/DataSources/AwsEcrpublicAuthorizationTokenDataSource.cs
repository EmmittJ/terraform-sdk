using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecrpublic_authorization_token.
/// </summary>
public class AwsEcrpublicAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrpublicAuthorizationTokenDataSource(string name) : base("aws_ecrpublic_authorization_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authorization_token");
        SetOutput("expires_at");
        SetOutput("password");
        SetOutput("user_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The authorization_token attribute.
    /// </summary>
    public TerraformExpression AuthorizationToken => this["authorization_token"];

    /// <summary>
    /// The expires_at attribute.
    /// </summary>
    public TerraformExpression ExpiresAt => this["expires_at"];

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformExpression Password => this["password"];

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformExpression UserName => this["user_name"];

}
