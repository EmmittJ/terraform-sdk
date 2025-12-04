using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dashboard_attributes in AwsSesv2AccountVdmAttributes.
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesDashboardAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dashboard_attributes";

    /// <summary>
    /// The engagement_metrics attribute.
    /// </summary>
    public TerraformValue<string>? EngagementMetrics
    {
        get => GetArgument<TerraformValue<string>>("engagement_metrics");
        set => SetArgument("engagement_metrics", value);
    }

}


/// <summary>
/// Block type for guardian_attributes in AwsSesv2AccountVdmAttributes.
/// Nesting mode: list
/// </summary>
public class AwsSesv2AccountVdmAttributesGuardianAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guardian_attributes";

    /// <summary>
    /// The optimized_shared_delivery attribute.
    /// </summary>
    public TerraformValue<string>? OptimizedSharedDelivery
    {
        get => GetArgument<TerraformValue<string>>("optimized_shared_delivery");
        set => SetArgument("optimized_shared_delivery", value);
    }

}


/// <summary>
/// Represents a aws_sesv2_account_vdm_attributes Terraform resource.
/// Manages a aws_sesv2_account_vdm_attributes resource.
/// </summary>
public partial class AwsSesv2AccountVdmAttributes(string name) : TerraformResource("aws_sesv2_account_vdm_attributes", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
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
    /// The vdm_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VdmEnabled is required")]
    public required TerraformValue<string> VdmEnabled
    {
        get => GetArgument<TerraformValue<string>>("vdm_enabled");
        set => SetArgument("vdm_enabled", value);
    }

    /// <summary>
    /// DashboardAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DashboardAttributes block(s) allowed")]
    public TerraformList<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>? DashboardAttributes
    {
        get => GetArgument<TerraformList<AwsSesv2AccountVdmAttributesDashboardAttributesBlock>>("dashboard_attributes");
        set => SetArgument("dashboard_attributes", value);
    }

    /// <summary>
    /// GuardianAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuardianAttributes block(s) allowed")]
    public TerraformList<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>? GuardianAttributes
    {
        get => GetArgument<TerraformList<AwsSesv2AccountVdmAttributesGuardianAttributesBlock>>("guardian_attributes");
        set => SetArgument("guardian_attributes", value);
    }

}
