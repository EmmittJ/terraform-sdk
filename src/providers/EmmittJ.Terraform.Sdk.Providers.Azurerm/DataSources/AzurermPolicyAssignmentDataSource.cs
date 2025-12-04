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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => GetArgument<TerraformValue<string>>("scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    public TerraformValue<bool> Enforce
        => AsReference("enforce");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string> Metadata
        => AsReference("metadata");

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NonComplianceMessage
        => AsReference("non_compliance_message");

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    public TerraformList<string> NotScopes
        => AsReference("not_scopes");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyDefinitionId
        => AsReference("policy_definition_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyAssignmentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
