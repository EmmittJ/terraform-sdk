using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_domain_dkim resource.
/// </summary>
public class AwsSesDomainDkim : TerraformResource
{
    public AwsSesDomainDkim(string name) : base("aws_ses_domain_dkim", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dkim_tokens");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dkim_tokens attribute.
    /// </summary>
    public TerraformExpression DkimTokens => this["dkim_tokens"];

}
