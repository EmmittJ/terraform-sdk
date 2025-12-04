using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogPortfolioConstraintsDataSource.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogPortfolioConstraintsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_portfolio_constraints Terraform data source.
/// Retrieves information about a aws_servicecatalog_portfolio_constraints.
/// </summary>
public partial class AwsServicecatalogPortfolioConstraintsDataSource(string name) : TerraformDataSource("aws_servicecatalog_portfolio_constraints", name)
{
    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformValue<string>? AcceptLanguage
    {
        get => GetArgument<TerraformValue<string>>("accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    public required TerraformValue<string> PortfolioId
    {
        get => GetRequiredArgument<TerraformValue<string>>("portfolio_id");
        set => SetArgument("portfolio_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformValue<string>? ProductId
    {
        get => GetArgument<TerraformValue<string>>("product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Details
        => AsReference("details");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogPortfolioConstraintsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogPortfolioConstraintsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
