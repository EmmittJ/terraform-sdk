using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_servicecatalog_portfolio_status Terraform resource.
/// Manages a aws_sagemaker_servicecatalog_portfolio_status resource.
/// </summary>
public partial class AwsSagemakerServicecatalogPortfolioStatus(string name) : TerraformResource("aws_sagemaker_servicecatalog_portfolio_status", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}
