using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPolicyAssignmentDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPolicyAssignmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_policy_assignment Terraform data source.
/// Retrieves information about a azurerm_policy_assignment.
/// </summary>
public partial class AzurermPolicyAssignmentDataSource(string name) : TerraformDataSource("azurerm_policy_assignment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => new TerraformReference<string>(this, "scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    public TerraformValue<bool> Enforce
    {
        get => new TerraformReference<bool>(this, "enforce");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
    }

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NonComplianceMessage
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "non_compliance_message").ResolveNodes(ctx));
    }

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    public TerraformList<string> NotScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string> Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyDefinitionId
    {
        get => new TerraformReference<string>(this, "policy_definition_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyAssignmentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
