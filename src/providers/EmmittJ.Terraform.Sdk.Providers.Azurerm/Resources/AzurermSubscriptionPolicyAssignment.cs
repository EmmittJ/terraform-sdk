using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermSubscriptionPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentIdentityBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for non_compliance_message in AzurermSubscriptionPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentNonComplianceMessageBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("content");
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
/// Block type for overrides in AzurermSubscriptionPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentOverridesBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionPolicyAssignmentOverridesBlockSelectorsBlock>? Selectors
    {
        get => GetArgument<TerraformList<AzurermSubscriptionPolicyAssignmentOverridesBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermSubscriptionPolicyAssignmentOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentOverridesBlockSelectorsBlock : TerraformBlock
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
/// Block type for resource_selectors in AzurermSubscriptionPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentResourceSelectorsBlock : TerraformBlock
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
    public required TerraformList<AzurermSubscriptionPolicyAssignmentResourceSelectorsBlockSelectorsBlock> Selectors
    {
        get => GetRequiredArgument<TerraformList<AzurermSubscriptionPolicyAssignmentResourceSelectorsBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in AzurermSubscriptionPolicyAssignmentResourceSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSubscriptionPolicyAssignmentResourceSelectorsBlockSelectorsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("kind");
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
/// Block type for timeouts in AzurermSubscriptionPolicyAssignment.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionPolicyAssignmentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscription_policy_assignment Terraform resource.
/// Manages a azurerm_subscription_policy_assignment resource.
/// </summary>
public partial class AzurermSubscriptionPolicyAssignment(string name) : TerraformResource("azurerm_subscription_policy_assignment", name)
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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    public TerraformValue<string> Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata") ?? AsReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
        get => GetRequiredArgument<TerraformValue<string>>("policy_definition_id");
        set => SetArgument("policy_definition_id", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformValue<string> SubscriptionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermSubscriptionPolicyAssignmentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermSubscriptionPolicyAssignmentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NonComplianceMessage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionPolicyAssignmentNonComplianceMessageBlock>? NonComplianceMessage
    {
        get => GetArgument<TerraformList<AzurermSubscriptionPolicyAssignmentNonComplianceMessageBlock>>("non_compliance_message");
        set => SetArgument("non_compliance_message", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionPolicyAssignmentOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformList<AzurermSubscriptionPolicyAssignmentOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// ResourceSelectors block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubscriptionPolicyAssignmentResourceSelectorsBlock>? ResourceSelectors
    {
        get => GetArgument<TerraformList<AzurermSubscriptionPolicyAssignmentResourceSelectorsBlock>>("resource_selectors");
        set => SetArgument("resource_selectors", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionPolicyAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
