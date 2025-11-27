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
        get => new TerraformReference<bool>(this, "default_baseline");
        set => SetArgument("default_baseline", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
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
    /// The approval_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApprovalRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "approval_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public TerraformList<string> ApprovedPatches
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "approved_patches").ResolveNodes(ctx));
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformValue<string> ApprovedPatchesComplianceLevel
    {
        get => new TerraformReference<string>(this, "approved_patches_compliance_level");
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool> ApprovedPatchesEnableNonSecurity
    {
        get => new TerraformReference<bool>(this, "approved_patches_enable_non_security");
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformValue<string> AvailableSecurityUpdatesComplianceStatus
    {
        get => new TerraformReference<string>(this, "available_security_updates_compliance_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The global_filter attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> GlobalFilter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "global_filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
    {
        get => new TerraformReference<string>(this, "json");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformList<string> RejectedPatches
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rejected_patches").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformValue<string> RejectedPatchesAction
    {
        get => new TerraformReference<string>(this, "rejected_patches_action");
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Source
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source").ResolveNodes(ctx));
    }

}
