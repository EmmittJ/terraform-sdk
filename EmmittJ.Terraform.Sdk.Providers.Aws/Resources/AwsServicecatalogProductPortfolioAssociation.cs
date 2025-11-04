using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_product_portfolio_association resource.
/// </summary>
public class AwsServicecatalogProductPortfolioAssociation : TerraformResource
{
    public AwsServicecatalogProductPortfolioAssociation(string name) : base("aws_servicecatalog_product_portfolio_association", name)
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
    /// The product_id attribute.
    /// </summary>
    public string? ProductId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("product_id")?.Value;
        set => this.WithProperty("product_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_portfolio_id attribute.
    /// </summary>
    public string? SourcePortfolioId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_portfolio_id")?.Value;
        set => this.WithProperty("source_portfolio_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
