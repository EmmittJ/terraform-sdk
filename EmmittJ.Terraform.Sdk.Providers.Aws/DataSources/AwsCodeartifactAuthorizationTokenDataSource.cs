using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeartifact_authorization_token.
/// </summary>
public class AwsCodeartifactAuthorizationTokenDataSource : TerraformDataSource
{
    public AwsCodeartifactAuthorizationTokenDataSource(string name) : base("aws_codeartifact_authorization_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorization_token");
        this.DeclareOutput("expiration");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public string? DomainOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_owner")?.Value;
        set => this.WithProperty("domain_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public double? DurationSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("duration_seconds")?.Value;
        set => this.WithProperty("duration_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The authorization_token attribute.
    /// </summary>
    public TerraformExpression AuthorizationToken => this["authorization_token"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

}
