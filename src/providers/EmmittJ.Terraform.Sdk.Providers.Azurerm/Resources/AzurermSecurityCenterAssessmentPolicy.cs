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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformSet<string>? Categories
    {
        get => GetArgument<TerraformSet<string>>("categories");
        set => SetArgument("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The implementation_effort attribute.
    /// </summary>
    public TerraformValue<string>? ImplementationEffort
    {
        get => GetArgument<TerraformValue<string>>("implementation_effort");
        set => SetArgument("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    public TerraformValue<string>? RemediationDescription
    {
        get => GetArgument<TerraformValue<string>>("remediation_description");
        set => SetArgument("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<string>? Severity
    {
        get => GetArgument<TerraformValue<string>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    public TerraformSet<string>? Threats
    {
        get => GetArgument<TerraformSet<string>>("threats");
        set => SetArgument("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    public TerraformValue<string>? UserImpact
    {
        get => GetArgument<TerraformValue<string>>("user_impact");
        set => SetArgument("user_impact", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterAssessmentPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterAssessmentPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
