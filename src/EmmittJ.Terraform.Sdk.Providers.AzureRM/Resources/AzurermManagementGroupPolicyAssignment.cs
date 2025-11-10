using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for non_compliance_message in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDefinitionReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("policy_definition_reference_id");
        set => WithProperty("policy_definition_reference_id", value);
    }

}

/// <summary>
/// Block type for overrides in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentOverridesBlock : TerraformBlock
{
    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for resource_selectors in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicyAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_management_group_policy_assignment resource.
/// </summary>
public class AzurermManagementGroupPolicyAssignment : TerraformResource
{
    public AzurermManagementGroupPolicyAssignment(string name) : base("azurerm_management_group_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    public TerraformProperty<bool>? Enforce
    {
        get => GetProperty<TerraformProperty<bool>>("enforce");
        set => this.WithProperty("enforce", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<string>? Metadata
    {
        get => GetProperty<TerraformProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotScopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("not_scopes");
        set => this.WithProperty("not_scopes", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<string>? Parameters
    {
        get => GetProperty<TerraformProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    public required TerraformProperty<string> PolicyDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("policy_definition_id");
        set => this.WithProperty("policy_definition_id", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermManagementGroupPolicyAssignmentIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermManagementGroupPolicyAssignmentIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for non_compliance_message.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock>? NonComplianceMessage
    {
        get => GetProperty<List<AzurermManagementGroupPolicyAssignmentNonComplianceMessageBlock>>("non_compliance_message");
        set => this.WithProperty("non_compliance_message", value);
    }

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermManagementGroupPolicyAssignmentOverridesBlock>? Overrides
    {
        get => GetProperty<List<AzurermManagementGroupPolicyAssignmentOverridesBlock>>("overrides");
        set => this.WithProperty("overrides", value);
    }

    /// <summary>
    /// Block for resource_selectors.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock>? ResourceSelectors
    {
        get => GetProperty<List<AzurermManagementGroupPolicyAssignmentResourceSelectorsBlock>>("resource_selectors");
        set => this.WithProperty("resource_selectors", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagementGroupPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagementGroupPolicyAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
