using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSecurityCenterAssessmentPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_security_center_assessment_policy Terraform resource.
/// Manages a azurerm_security_center_assessment_policy resource.
/// </summary>
public partial class AzurermSecurityCenterAssessmentPolicy(string name) : TerraformResource("azurerm_security_center_assessment_policy", name)
{
    /// <summary>
    /// The categories attribute.
    /// </summary>
    public TerraformSet<string> Categories
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "categories").ResolveNodes(ctx));
        set => SetArgument("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The implementation_effort attribute.
    /// </summary>
    public TerraformValue<string>? ImplementationEffort
    {
        get => new TerraformReference<string>(this, "implementation_effort");
        set => SetArgument("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public TerraformValue<string>? RemediationDescription
    {
        get => new TerraformReference<string>(this, "remediation_description");
        set => SetArgument("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<string>? Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public TerraformSet<string>? Threats
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "threats").ResolveNodes(ctx));
        set => SetArgument("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public TerraformValue<string>? UserImpact
    {
        get => new TerraformReference<string>(this, "user_impact");
        set => SetArgument("user_impact", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterAssessmentPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
