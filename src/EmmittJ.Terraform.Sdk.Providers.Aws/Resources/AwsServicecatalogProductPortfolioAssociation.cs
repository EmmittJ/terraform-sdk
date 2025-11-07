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
    /// The source_portfolio_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourcePortfolioId
    {
        get => GetProperty<TerraformProperty<string>>("source_portfolio_id");
        set => this.WithProperty("source_portfolio_id", value);
    }

}
