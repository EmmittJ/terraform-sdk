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
        this.DeclareOutput("authorization_token");
        this.DeclareOutput("expires_at");
        this.DeclareOutput("password");
        this.DeclareOutput("user_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
