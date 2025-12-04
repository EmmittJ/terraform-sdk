using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagementGroupPolicyExemption.
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicyExemptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_management_group_policy_exemption Terraform resource.
/// Manages a azurerm_management_group_policy_exemption resource.
/// </summary>
public partial class AzurermManagementGroupPolicyExemption(string name) : TerraformResource("azurerm_management_group_policy_exemption", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The exemption_category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExemptionCategory is required")]
    public required TerraformValue<string> ExemptionCategory
    {
        get => GetArgument<TerraformValue<string>>("exemption_category");
        set => SetArgument("exemption_category", value);
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public TerraformValue<string>? ExpiresOn
    {
        get => GetArgument<TerraformValue<string>>("expires_on");
        set => SetArgument("expires_on", value);
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => GetArgument<TerraformValue<string>>("management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformValue<string> PolicyAssignmentId
    {
        get => GetArgument<TerraformValue<string>>("policy_assignment_id");
        set => SetArgument("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public TerraformList<string>? PolicyDefinitionReferenceIds
    {
        get => GetArgument<TerraformList<string>>("policy_definition_reference_ids");
        set => SetArgument("policy_definition_reference_ids", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupPolicyExemptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupPolicyExemptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
