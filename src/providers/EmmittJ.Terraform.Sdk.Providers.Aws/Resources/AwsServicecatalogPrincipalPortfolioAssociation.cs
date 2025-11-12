using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsServicecatalogPrincipalPortfolioAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_principal_portfolio_association resource.
/// </summary>
public partial class AwsServicecatalogPrincipalPortfolioAssociation : TerraformResource
{
    public AwsServicecatalogPrincipalPortfolioAssociation(string name) : base("aws_servicecatalog_principal_portfolio_association", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformProperty("accept_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    [TerraformProperty("portfolio_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PortfolioId { get; set; }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    [TerraformProperty("principal_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalArn { get; set; }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    [TerraformProperty("principal_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrincipalType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsServicecatalogPrincipalPortfolioAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
