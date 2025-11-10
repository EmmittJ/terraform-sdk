using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogPortfolioShareTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("accepted");
        SetOutput("accept_language");
        SetOutput("id");
        SetOutput("portfolio_id");
        SetOutput("principal_id");
        SetOutput("region");
        SetOutput("share_principals");
        SetOutput("share_tag_options");
        SetOutput("type");
        SetOutput("wait_for_acceptance");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformProperty<string> AcceptLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accept_language");
        set => SetProperty("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    public required TerraformProperty<string> PortfolioId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("portfolio_id");
        set => SetProperty("portfolio_id", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_id");
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The share_principals attribute.
    /// </summary>
    public TerraformProperty<bool> SharePrincipals
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("share_principals");
        set => SetProperty("share_principals", value);
    }

    /// <summary>
    /// The share_tag_options attribute.
    /// </summary>
    public TerraformProperty<bool> ShareTagOptions
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("share_tag_options");
        set => SetProperty("share_tag_options", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The wait_for_acceptance attribute.
    /// </summary>
    public TerraformProperty<bool> WaitForAcceptance
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_acceptance");
        set => SetProperty("wait_for_acceptance", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogPortfolioShareTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformExpression Accepted => this["accepted"];

}
