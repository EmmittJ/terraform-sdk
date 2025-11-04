using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_principal_portfolio_association resource.
/// </summary>
public class AwsServicecatalogPrincipalPortfolioAssociation : TerraformResource
{
    public AwsServicecatalogPrincipalPortfolioAssociation(string name) : base("aws_servicecatalog_principal_portfolio_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public string? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language")?.Value;
        set => this.WithProperty("accept_language", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The portfolio_id attribute.
    /// </summary>
    public string? PortfolioId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("portfolio_id")?.Value;
        set => this.WithProperty("portfolio_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public string? PrincipalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_arn")?.Value;
        set => this.WithProperty("principal_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public string? PrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_type")?.Value;
        set => this.WithProperty("principal_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
