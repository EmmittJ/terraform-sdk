using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogPortfolioShare.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogPortfolioShareTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_servicecatalog_portfolio_share Terraform resource.
/// Manages a aws_servicecatalog_portfolio_share resource.
/// </summary>
public partial class AwsServicecatalogPortfolioShare(string name) : TerraformResource("aws_servicecatalog_portfolio_share", name)
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
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
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
    /// The share_principals attribute.
    /// </summary>
    public TerraformValue<bool>? SharePrincipals
    {
        get => new TerraformReference<bool>(this, "share_principals");
        set => SetArgument("share_principals", value);
    }

    /// <summary>
    /// The share_tag_options attribute.
    /// </summary>
    public TerraformValue<bool>? ShareTagOptions
    {
        get => new TerraformReference<bool>(this, "share_tag_options");
        set => SetArgument("share_tag_options", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The wait_for_acceptance attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForAcceptance
    {
        get => new TerraformReference<bool>(this, "wait_for_acceptance");
        set => SetArgument("wait_for_acceptance", value);
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformValue<bool> Accepted
    {
        get => new TerraformReference<bool>(this, "accepted");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogPortfolioShareTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogPortfolioShareTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
