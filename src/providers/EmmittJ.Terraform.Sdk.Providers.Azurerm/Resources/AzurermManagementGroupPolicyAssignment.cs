using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermManagementGroupPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for non_compliance_message in AzurermManagementGroupPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "non_compliance_message";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDefinitionReferenceId
    {
        get => new TerraformReference<string>(this, "policy_definition_reference_id");
        set => SetArgument("policy_definition_reference_id", value);
    }

}


/// <summary>
/// Block type for overrides in AzurermManagementGroupPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overrides";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermManagementGroupPolicyAssignmentOverridesBlockSelectorsBlock>? Selectors
    {
        get => GetArgument<TerraformList<AzurermManagementGroupPolicyAssignmentOverridesBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermManagementGroupPolicyAssignmentOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentOverridesBlockSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// The in attribute.
    /// </summary>
    public TerraformList<string>? InAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "in").ResolveNodes(ctx));
        set => SetArgument("in", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The not_in attribute.
    /// </summary>
    public TerraformList<string>? NotIn
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_in").ResolveNodes(ctx));
        set => SetArgument("not_in", value);
    }

}


/// <summary>
/// Block type for resource_selectors in AzurermManagementGroupPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_selectors";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selectors is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selectors block(s) required")]
    public required TerraformList<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlockSelectorsBlock> Selectors
    {
        get => GetRequiredArgument<TerraformList<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentResourceSelectorsBlockSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// The in attribute.
    /// </summary>
    public TerraformList<string>? InAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "in").ResolveNodes(ctx));
        set => SetArgument("in", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The not_in attribute.
    /// </summary>
    public TerraformList<string>? NotIn
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_in").ResolveNodes(ctx));
        set => SetArgument("not_in", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermManagementGroupPolicyAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicyAssignmentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_management_group_policy_assignment Terraform resource.
/// Manages a azurerm_management_group_policy_assignment resource.
/// </summary>
public partial class AzurermManagementGroupPolicyAssignment(string name) : TerraformResource("azurerm_management_group_policy_assignment", name)
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
    /// The enforce attribute.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => new TerraformReference<bool>(this, "enforce");
        set => SetArgument("enforce", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => new TerraformReference<string>(this, "management_group_id");
        set => SetArgument("management_group_id", value);
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
    /// The not_scopes attribute.
    /// </summary>
    public TerraformList<string>? NotScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_scopes").ResolveNodes(ctx));
        set => SetArgument("not_scopes", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    public required TerraformValue<string> PolicyDefinitionId
    {
        get => new TerraformReference<string>(this, "policy_definition_id");
        set => SetArgument("policy_definition_id", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermManagementGroupPolicyAssignmentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermManagementGroupPolicyAssignmentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NonComplianceMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock>? NonComplianceMessage
    {
        get => GetArgument<TerraformList<AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock>>("non_compliance_message");
        set => SetArgument("non_compliance_message", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermManagementGroupPolicyAssignmentOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformList<AzurermManagementGroupPolicyAssignmentOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// ResourceSelectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock>? ResourceSelectors
    {
        get => GetArgument<TerraformList<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock>>("resource_selectors");
        set => SetArgument("resource_selectors", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupPolicyAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
