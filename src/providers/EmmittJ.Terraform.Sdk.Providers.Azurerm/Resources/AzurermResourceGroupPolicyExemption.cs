using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermResourceGroupPolicyExemption.
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupPolicyExemptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_group_policy_exemption Terraform resource.
/// Manages a azurerm_resource_group_policy_exemption resource.
/// </summary>
public partial class AzurermResourceGroupPolicyExemption(string name) : TerraformResource("azurerm_resource_group_policy_exemption", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The exemption_category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExemptionCategory is required")]
    public required TerraformValue<string> ExemptionCategory
    {
        get => new TerraformReference<string>(this, "exemption_category");
        set => SetArgument("exemption_category", value);
    }

    /// <summary>
    /// The expires_on attribute.
    /// </summary>
    public TerraformValue<string>? ExpiresOn
    {
        get => new TerraformReference<string>(this, "expires_on");
        set => SetArgument("expires_on", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformValue<string> PolicyAssignmentId
    {
        get => new TerraformReference<string>(this, "policy_assignment_id");
        set => SetArgument("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_ids attribute.
    /// </summary>
    public TerraformList<string>? PolicyDefinitionReferenceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "policy_definition_reference_ids").ResolveNodes(ctx));
        set => SetArgument("policy_definition_reference_ids", value);
    }

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupId is required")]
    public required TerraformValue<string> ResourceGroupId
    {
        get => new TerraformReference<string>(this, "resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourceGroupPolicyExemptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourceGroupPolicyExemptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
