using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dashboard_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesDashboardAttributesBlock
{
    /// <summary>
    /// The engagement_metrics attribute.
    /// </summary>
    [TerraformPropertyName("engagement_metrics")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EngagementMetrics { get; set; }

}

/// <summary>
/// Block type for guardian_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesGuardianAttributesBlock
{
    /// <summary>
    /// The optimized_shared_delivery attribute.
    /// </summary>
    [TerraformPropertyName("optimized_shared_delivery")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OptimizedSharedDelivery { get; set; }

}

/// <summary>
/// Manages a aws_sesv2_account_vdm_attributes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2AccountVdmAttributes : TerraformResource
{
    public AwsSesv2AccountVdmAttributes(string name) : base("aws_sesv2_account_vdm_attributes", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vdm_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VdmEnabled is required")]
    [TerraformPropertyName("vdm_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VdmEnabled { get; set; }

    /// <summary>
    /// Block for dashboard_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardAttributes block(s) allowed")]
    [TerraformPropertyName("dashboard_attributes")]
    public TerraformList<TerraformBlock<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>>? DashboardAttributes { get; set; }

    /// <summary>
    /// Block for guardian_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianAttributes block(s) allowed")]
    [TerraformPropertyName("guardian_attributes")]
    public TerraformList<TerraformBlock<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>>? GuardianAttributes { get; set; }

}
