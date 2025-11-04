using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_constraint resource.
/// </summary>
public class AwsServicecatalogConstraint : TerraformResource
{
    public AwsServicecatalogConstraint(string name) : base("aws_servicecatalog_constraint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("owner");
        this.DeclareOutput("status");
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
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public string? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
