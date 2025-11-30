using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPolicySetDefinitionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPolicySetDefinitionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_policy_set_definition Terraform data source.
/// Retrieves information about a azurerm_policy_set_definition.
/// </summary>
public partial class AzurermPolicySetDefinitionDataSource(string name) : TerraformDataSource("azurerm_policy_set_definition", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The management_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagementGroupName
    {
        get => new TerraformReference<string>(this, "management_group_name");
        set => SetArgument("management_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string> Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
    }

    /// <summary>
    /// The policy_definition_group attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PolicyDefinitionGroup
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "policy_definition_group").ResolveNodes(ctx));
    }

    /// <summary>
    /// The policy_definition_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PolicyDefinitionReference
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "policy_definition_reference").ResolveNodes(ctx));
    }

    /// <summary>
    /// The policy_definitions attribute.
    /// </summary>
    public TerraformValue<string> PolicyDefinitions
    {
        get => new TerraformReference<string>(this, "policy_definitions");
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicySetDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicySetDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
