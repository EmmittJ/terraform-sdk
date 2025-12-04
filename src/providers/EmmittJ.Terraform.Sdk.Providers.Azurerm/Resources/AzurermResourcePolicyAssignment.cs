using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermResourcePolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for non_compliance_message in AzurermResourcePolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentNonComplianceMessageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDefinitionReferenceId
    {
        get => GetArgument<TerraformValue<string>>("policy_definition_reference_id");
        set => SetArgument("policy_definition_reference_id", value);
    }

}


/// <summary>
/// Block type for overrides in AzurermResourcePolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentOverridesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourcePolicyAssignmentOverridesBlockSelectorsBlock>? Selectors
    {
        get => GetArgument<TerraformList<AzurermResourcePolicyAssignmentOverridesBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermResourcePolicyAssignmentOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentOverridesBlockSelectorsBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("in");
        set => SetArgument("in", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string>? Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The not_in attribute.
    /// </summary>
    public TerraformList<string>? NotIn
    {
        get => GetArgument<TerraformList<string>>("not_in");
        set => SetArgument("not_in", value);
    }

}


/// <summary>
/// Block type for resource_selectors in AzurermResourcePolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentResourceSelectorsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selectors is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selectors block(s) required")]
    public required TerraformList<AzurermResourcePolicyAssignmentResourceSelectorsBlockSelectorsBlock> Selectors
    {
        get => GetRequiredArgument<TerraformList<AzurermResourcePolicyAssignmentResourceSelectorsBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermResourcePolicyAssignmentResourceSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermResourcePolicyAssignmentResourceSelectorsBlockSelectorsBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("in");
        set => SetArgument("in", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The not_in attribute.
    /// </summary>
    public TerraformList<string>? NotIn
    {
        get => GetArgument<TerraformList<string>>("not_in");
        set => SetArgument("not_in", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermResourcePolicyAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermResourcePolicyAssignmentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resource_policy_assignment Terraform resource.
/// Manages a azurerm_resource_policy_assignment resource.
/// </summary>
public partial class AzurermResourcePolicyAssignment(string name) : TerraformResource("azurerm_resource_policy_assignment", name)
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
    /// The enforce attribute.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => GetArgument<TerraformValue<bool>>("enforce");
        set => SetArgument("enforce", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The not_scopes attribute.
    /// </summary>
    public TerraformList<string>? NotScopes
    {
        get => GetArgument<TerraformList<string>>("not_scopes");
        set => SetArgument("not_scopes", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    public required TerraformValue<string> PolicyDefinitionId
    {
        get => GetArgument<TerraformValue<string>>("policy_definition_id");
        set => SetArgument("policy_definition_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermResourcePolicyAssignmentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermResourcePolicyAssignmentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NonComplianceMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourcePolicyAssignmentNonComplianceMessageBlock>? NonComplianceMessage
    {
        get => GetArgument<TerraformList<AzurermResourcePolicyAssignmentNonComplianceMessageBlock>>("non_compliance_message");
        set => SetArgument("non_compliance_message", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourcePolicyAssignmentOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformList<AzurermResourcePolicyAssignmentOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// ResourceSelectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermResourcePolicyAssignmentResourceSelectorsBlock>? ResourceSelectors
    {
        get => GetArgument<TerraformList<AzurermResourcePolicyAssignmentResourceSelectorsBlock>>("resource_selectors");
        set => SetArgument("resource_selectors", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourcePolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourcePolicyAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
