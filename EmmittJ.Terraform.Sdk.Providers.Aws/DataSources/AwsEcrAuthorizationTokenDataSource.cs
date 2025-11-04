using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecr_authorization_token.
/// </summary>
public class AwsEcrAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsEcrAuthorizationTokenDataSource(string name) : base("aws_ecr_authorization_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorization_token");
        this.DeclareOutput("expires_at");
        this.DeclareOutput("password");
        this.DeclareOutput("proxy_endpoint");
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
    /// The registry_id attribute.
    /// </summary>
    public string? RegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_id")?.Value;
        set => this.WithProperty("registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The proxy_endpoint attribute.
    /// </summary>
    public TerraformExpression ProxyEndpoint => this["proxy_endpoint"];

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformExpression UserName => this["user_name"];

}
