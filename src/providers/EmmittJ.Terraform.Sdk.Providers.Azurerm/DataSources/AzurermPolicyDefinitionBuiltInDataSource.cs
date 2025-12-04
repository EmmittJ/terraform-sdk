using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPolicyDefinitionBuiltInDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_policy_definition_built_in Terraform data source.
/// Retrieves information about a azurerm_policy_definition_built_in.
/// </summary>
public partial class AzurermPolicyDefinitionBuiltInDataSource(string name) : TerraformDataSource("azurerm_policy_definition_built_in", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
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
    /// The management_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagementGroupName
    {
        get => GetArgument<TerraformValue<string>>("management_group_name");
        set => SetArgument("management_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string> Metadata
        => AsReference("metadata");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
        => AsReference("mode");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    public TerraformValue<string> PolicyRule
        => AsReference("policy_rule");

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string> PolicyType
        => AsReference("policy_type");

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    public TerraformList<string> RoleDefinitionIds
        => AsReference("role_definition_ids");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
