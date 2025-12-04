using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogConstraintDataSource.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogConstraintDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_servicecatalog_constraint Terraform data source.
/// Retrieves information about a aws_servicecatalog_constraint.
/// </summary>
public partial class AwsServicecatalogConstraintDataSource(string name) : TerraformDataSource("aws_servicecatalog_constraint", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    public TerraformValue<string> PortfolioId
        => AsReference("portfolio_id");

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    public TerraformValue<string> ProductId
        => AsReference("product_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogConstraintDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogConstraintDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
