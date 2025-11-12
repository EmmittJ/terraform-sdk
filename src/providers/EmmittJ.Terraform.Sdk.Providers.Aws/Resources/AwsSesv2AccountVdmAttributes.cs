using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dashboard_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2AccountVdmAttributesDashboardAttributesBlock() : TerraformBlock("dashboard_attributes")
{
    /// <summary>
    /// The engagement_metrics attribute.
    /// </summary>
    [TerraformProperty("engagement_metrics")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EngagementMetrics { get; set; }

}

/// <summary>
/// Block type for guardian_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2AccountVdmAttributesGuardianAttributesBlock() : TerraformBlock("guardian_attributes")
{
    /// <summary>
    /// The optimized_shared_delivery attribute.
    /// </summary>
    [TerraformProperty("optimized_shared_delivery")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OptimizedSharedDelivery { get; set; }

}

/// <summary>
/// Manages a aws_sesv2_account_vdm_attributes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesv2AccountVdmAttributes : TerraformResource
{
    public AwsSesv2AccountVdmAttributes(string name) : base("aws_sesv2_account_vdm_attributes", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vdm_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VdmEnabled is required")]
    [TerraformProperty("vdm_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VdmEnabled { get; set; }

    /// <summary>
    /// Block for dashboard_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardAttributes block(s) allowed")]
    [TerraformProperty("dashboard_attributes")]
    public TerraformList<AwsSesv2AccountVdmAttributesDashboardAttributesBlock> DashboardAttributes { get; set; } = new();

    /// <summary>
    /// Block for guardian_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianAttributes block(s) allowed")]
    [TerraformProperty("guardian_attributes")]
    public TerraformList<AwsSesv2AccountVdmAttributesGuardianAttributesBlock> GuardianAttributes { get; set; } = new();

}
