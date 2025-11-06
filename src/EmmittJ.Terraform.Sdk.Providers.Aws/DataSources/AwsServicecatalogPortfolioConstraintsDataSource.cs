using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicecatalog_portfolio_constraints.
/// </summary>
public class AwsServicecatalogPortfolioConstraintsDataSource : TerraformDataSource
{
    public AwsServicecatalogPortfolioConstraintsDataSource(string name) : base("aws_servicecatalog_portfolio_constraints", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("details");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The details attribute.
    /// </summary>
    public TerraformExpression Details => this["details"];

}
