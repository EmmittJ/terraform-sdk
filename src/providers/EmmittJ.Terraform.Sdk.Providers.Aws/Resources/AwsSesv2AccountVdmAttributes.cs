using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dashboard_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesDashboardAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The engagement_metrics attribute.
    /// </summary>
    public TerraformProperty<string>? EngagementMetrics
    {
        set => SetProperty("engagement_metrics", value);
    }

}

/// <summary>
/// Block type for guardian_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesGuardianAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The optimized_shared_delivery attribute.
    /// </summary>
    public TerraformProperty<string>? OptimizedSharedDelivery
    {
        set => SetProperty("optimized_shared_delivery", value);
    }

}

/// <summary>
/// Manages a aws_sesv2_account_vdm_attributes resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2AccountVdmAttributes : TerraformResource
{
    public AwsSesv2AccountVdmAttributes(string name) : base("aws_sesv2_account_vdm_attributes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
        SetOutput("vdm_enabled");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The vdm_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VdmEnabled is required")]
    public required TerraformProperty<string> VdmEnabled
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vdm_enabled");
        set => SetProperty("vdm_enabled", value);
    }

    /// <summary>
    /// Block for dashboard_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardAttributes block(s) allowed")]
    public List<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>? DashboardAttributes
    {
        set => SetProperty("dashboard_attributes", value);
    }

    /// <summary>
    /// Block for guardian_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianAttributes block(s) allowed")]
    public List<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>? GuardianAttributes
    {
        set => SetProperty("guardian_attributes", value);
    }

}
