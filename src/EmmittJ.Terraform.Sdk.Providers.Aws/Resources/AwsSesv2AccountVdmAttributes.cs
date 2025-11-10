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
        get => GetProperty<TerraformProperty<string>>("engagement_metrics");
        set => WithProperty("engagement_metrics", value);
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
        get => GetProperty<TerraformProperty<string>>("optimized_shared_delivery");
        set => WithProperty("optimized_shared_delivery", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vdm_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VdmEnabled is required")]
    public required TerraformProperty<string> VdmEnabled
    {
        get => GetProperty<TerraformProperty<string>>("vdm_enabled");
        set => this.WithProperty("vdm_enabled", value);
    }

    /// <summary>
    /// Block for dashboard_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardAttributes block(s) allowed")]
    public List<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>? DashboardAttributes
    {
        get => GetProperty<List<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>>("dashboard_attributes");
        set => this.WithProperty("dashboard_attributes", value);
    }

    /// <summary>
    /// Block for guardian_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianAttributes block(s) allowed")]
    public List<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>? GuardianAttributes
    {
        get => GetProperty<List<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>>("guardian_attributes");
        set => this.WithProperty("guardian_attributes", value);
    }

}
