using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for status in AzurermSecurityCenterAssessment.
/// Nesting mode: list
/// </summary>
public class AzurermSecurityCenterAssessmentStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "status";

    /// <summary>
    /// The cause attribute.
    /// </summary>
    public TerraformValue<string>? Cause
    {
        get => GetArgument<TerraformValue<string>>("cause");
        set => SetArgument("cause", value);
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => GetRequiredArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSecurityCenterAssessment.
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_security_center_assessment Terraform resource.
/// Manages a azurerm_security_center_assessment resource.
/// </summary>
public partial class AzurermSecurityCenterAssessment(string name) : TerraformResource("azurerm_security_center_assessment", name)
{
    /// <summary>
    /// The additional_data attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalData
    {
        get => GetArgument<TerraformMap<string>>("additional_data");
        set => SetArgument("additional_data", value);
    }

    /// <summary>
    /// The assessment_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssessmentPolicyId is required")]
    public required TerraformValue<string> AssessmentPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("assessment_policy_id");
        set => SetArgument("assessment_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Status block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Status block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    public required TerraformList<AzurermSecurityCenterAssessmentStatusBlock> Status
    {
        get => GetRequiredArgument<TerraformList<AzurermSecurityCenterAssessmentStatusBlock>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterAssessmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterAssessmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
