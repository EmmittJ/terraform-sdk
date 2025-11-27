using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogProductPortfolioAssociation.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductPortfolioAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_product_portfolio_association Terraform resource.
/// Manages a aws_servicecatalog_product_portfolio_association resource.
/// </summary>
public partial class AwsServicecatalogProductPortfolioAssociation(string name) : TerraformResource("aws_servicecatalog_product_portfolio_association", name)
{
    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformValue<string>? AcceptLanguage
    {
        get => new TerraformReference<string>(this, "accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    public required TerraformValue<string> PortfolioId
    {
        get => new TerraformReference<string>(this, "portfolio_id");
        set => SetArgument("portfolio_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformValue<string> ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_portfolio_id attribute.
    /// </summary>
    public TerraformValue<string>? SourcePortfolioId
    {
        get => new TerraformReference<string>(this, "source_portfolio_id");
        set => SetArgument("source_portfolio_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProductPortfolioAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProductPortfolioAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
