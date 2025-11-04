using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_portfolio_share resource.
/// </summary>
public class AwsServicecatalogPortfolioShare : TerraformResource
{
    public AwsServicecatalogPortfolioShare(string name) : base("aws_servicecatalog_portfolio_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accepted");
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
    /// The principal_id attribute.
    /// </summary>
    public string? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id")?.Value;
        set => this.WithProperty("principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The share_principals attribute.
    /// </summary>
    public bool? SharePrincipals
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("share_principals")?.Value;
        set => this.WithProperty("share_principals", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The share_tag_options attribute.
    /// </summary>
    public bool? ShareTagOptions
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("share_tag_options")?.Value;
        set => this.WithProperty("share_tag_options", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The wait_for_acceptance attribute.
    /// </summary>
    public bool? WaitForAcceptance
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_acceptance")?.Value;
        set => this.WithProperty("wait_for_acceptance", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformExpression Accepted => this["accepted"];

}
