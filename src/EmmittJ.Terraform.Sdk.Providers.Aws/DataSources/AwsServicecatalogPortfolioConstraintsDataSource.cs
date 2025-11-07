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
    public TerraformProperty<string>? AcceptLanguage
    {
        get => GetProperty<TerraformProperty<string>>("accept_language");
        set => this.WithProperty("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    public TerraformProperty<string>? PortfolioId
    {
        get => GetProperty<TerraformProperty<string>>("portfolio_id");
        set => this.WithProperty("portfolio_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProductId
    {
        get => GetProperty<TerraformProperty<string>>("product_id");
        set => this.WithProperty("product_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The details attribute.
    /// </summary>
    public TerraformExpression Details => this["details"];

}
