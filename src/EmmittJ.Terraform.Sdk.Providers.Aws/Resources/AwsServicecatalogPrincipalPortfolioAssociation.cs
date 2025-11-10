using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogPrincipalPortfolioAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    public required TerraformProperty<string> PortfolioId
    {
        get => GetProperty<TerraformProperty<string>>("portfolio_id");
        set => this.WithProperty("portfolio_id", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    public required TerraformProperty<string> PrincipalArn
    {
        get => GetProperty<TerraformProperty<string>>("principal_arn");
        set => this.WithProperty("principal_arn", value);
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalType
    {
        get => GetProperty<TerraformProperty<string>>("principal_type");
        set => this.WithProperty("principal_type", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsServicecatalogPrincipalPortfolioAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsServicecatalogPrincipalPortfolioAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
