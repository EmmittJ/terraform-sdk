using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authorization in AzurermLighthouseDefinition.
/// Nesting mode: set
/// </summary>
public class AzurermLighthouseDefinitionAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// The delegated_role_definition_ids attribute.
    /// </summary>
    public TerraformSet<string>? DelegatedRoleDefinitionIds
    {
        get => GetArgument<TerraformSet<string>>("delegated_role_definition_ids");
        set => SetArgument("delegated_role_definition_ids", value);
    }

    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalDisplayName
    {
        get => GetArgument<TerraformValue<string>>("principal_display_name");
        set => SetArgument("principal_display_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

}


/// <summary>
/// Block type for eligible_authorization in AzurermLighthouseDefinition.
/// Nesting mode: set
/// </summary>
public class AzurermLighthouseDefinitionEligibleAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eligible_authorization";

    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalDisplayName
    {
        get => GetArgument<TerraformValue<string>>("principal_display_name");
        set => SetArgument("principal_display_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// JustInTimeAccessPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JustInTimeAccessPolicy block(s) allowed")]
    public TerraformList<AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlock>? JustInTimeAccessPolicy
    {
        get => GetArgument<TerraformList<AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlock>>("just_in_time_access_policy");
        set => SetArgument("just_in_time_access_policy", value);
    }

}

/// <summary>
/// Block type for just_in_time_access_policy in AzurermLighthouseDefinitionEligibleAuthorizationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "just_in_time_access_policy";

    /// <summary>
    /// The maximum_activation_duration attribute.
    /// </summary>
    public TerraformValue<string>? MaximumActivationDuration
    {
        get => GetArgument<TerraformValue<string>>("maximum_activation_duration");
        set => SetArgument("maximum_activation_duration", value);
    }

    /// <summary>
    /// The multi_factor_auth_provider attribute.
    /// </summary>
    public TerraformValue<string>? MultiFactorAuthProvider
    {
        get => GetArgument<TerraformValue<string>>("multi_factor_auth_provider");
        set => SetArgument("multi_factor_auth_provider", value);
    }

    /// <summary>
    /// Approver block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlockApproverBlock>? Approver
    {
        get => GetArgument<TerraformSet<AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlockApproverBlock>>("approver");
        set => SetArgument("approver", value);
    }

}

/// <summary>
/// Block type for approver in AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AzurermLighthouseDefinitionEligibleAuthorizationBlockJustInTimeAccessPolicyBlockApproverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approver";

    /// <summary>
    /// The principal_display_name attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalDisplayName
    {
        get => GetArgument<TerraformValue<string>>("principal_display_name");
        set => SetArgument("principal_display_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal_id");
        set => SetArgument("principal_id", value);
    }

}


/// <summary>
/// Block type for plan in AzurermLighthouseDefinition.
/// Nesting mode: list
/// </summary>
public class AzurermLighthouseDefinitionPlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

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
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformValue<string> Product
    {
        get => GetRequiredArgument<TerraformValue<string>>("product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLighthouseDefinition.
/// Nesting mode: single
/// </summary>
public class AzurermLighthouseDefinitionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_lighthouse_definition Terraform resource.
/// Manages a azurerm_lighthouse_definition resource.
/// </summary>
public partial class AzurermLighthouseDefinition(string name) : TerraformResource("azurerm_lighthouse_definition", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lighthouse_definition_id attribute.
    /// </summary>
    public TerraformValue<string> LighthouseDefinitionId
    {
        get => GetArgument<TerraformValue<string>>("lighthouse_definition_id") ?? CreateReference("lighthouse_definition_id");
        set => SetArgument("lighthouse_definition_id", value);
    }

    /// <summary>
    /// The managing_tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagingTenantId is required")]
    public required TerraformValue<string> ManagingTenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("managing_tenant_id");
        set => SetArgument("managing_tenant_id", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Authorization block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    public required TerraformSet<AzurermLighthouseDefinitionAuthorizationBlock> Authorization
    {
        get => GetRequiredArgument<TerraformSet<AzurermLighthouseDefinitionAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// EligibleAuthorization block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLighthouseDefinitionEligibleAuthorizationBlock>? EligibleAuthorization
    {
        get => GetArgument<TerraformSet<AzurermLighthouseDefinitionEligibleAuthorizationBlock>>("eligible_authorization");
        set => SetArgument("eligible_authorization", value);
    }

    /// <summary>
    /// Plan block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public TerraformList<AzurermLighthouseDefinitionPlanBlock>? Plan
    {
        get => GetArgument<TerraformList<AzurermLighthouseDefinitionPlanBlock>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLighthouseDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLighthouseDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
