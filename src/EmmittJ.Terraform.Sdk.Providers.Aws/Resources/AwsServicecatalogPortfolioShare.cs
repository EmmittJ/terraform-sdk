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
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
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
    /// The share_principals attribute.
    /// </summary>
    public TerraformProperty<bool>? SharePrincipals
    {
        get => GetProperty<TerraformProperty<bool>>("share_principals");
        set => this.WithProperty("share_principals", value);
    }

    /// <summary>
    /// The share_tag_options attribute.
    /// </summary>
    public TerraformProperty<bool>? ShareTagOptions
    {
        get => GetProperty<TerraformProperty<bool>>("share_tag_options");
        set => this.WithProperty("share_tag_options", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The wait_for_acceptance attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForAcceptance
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_acceptance");
        set => this.WithProperty("wait_for_acceptance", value);
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformExpression Accepted => this["accepted"];

}
