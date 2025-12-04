using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssm_patch_baseline Terraform data source.
/// Retrieves information about a aws_ssm_patch_baseline.
/// </summary>
public partial class AwsSsmPatchBaselineDataSource(string name) : TerraformDataSource("aws_ssm_patch_baseline", name)
{
    /// <summary>
    /// The default_baseline attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultBaseline
    {
        get => GetArgument<TerraformValue<bool>>("default_baseline");
        set => SetArgument("default_baseline", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => GetArgument<TerraformValue<string>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
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
    /// The approval_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApprovalRule
        => AsReference("approval_rule");

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public TerraformList<string> ApprovedPatches
        => AsReference("approved_patches");

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformValue<string> ApprovedPatchesComplianceLevel
        => AsReference("approved_patches_compliance_level");

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool> ApprovedPatchesEnableNonSecurity
        => AsReference("approved_patches_enable_non_security");

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformValue<string> AvailableSecurityUpdatesComplianceStatus
        => AsReference("available_security_updates_compliance_status");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The global_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GlobalFilter
        => AsReference("global_filter");

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => AsReference("json");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformList<string> RejectedPatches
        => AsReference("rejected_patches");

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformValue<string> RejectedPatchesAction
        => AsReference("rejected_patches_action");

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Source
        => AsReference("source");

}
