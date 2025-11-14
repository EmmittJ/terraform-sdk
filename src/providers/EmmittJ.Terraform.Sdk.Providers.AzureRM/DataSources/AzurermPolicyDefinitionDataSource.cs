using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_policy_definition.
/// </summary>
public class AzurermPolicyDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionDataSource(string name) : base("azurerm_policy_definition", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The management_group_name attribute.
    /// </summary>
    [TerraformArgument("management_group_name")]
    public TerraformValue<string>? ManagementGroupName
    {
        get => new TerraformReference<string>(this, "management_group_name");
        set => SetArgument("management_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPolicyDefinitionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformArgument("mode")]
    public TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformValue<string> Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
    }

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    [TerraformArgument("policy_rule")]
    public TerraformValue<string> PolicyRule
    {
        get => new TerraformReference<string>(this, "policy_rule");
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [TerraformArgument("policy_type")]
    public TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
    }

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    [TerraformArgument("role_definition_ids")]
    public TerraformList<string> RoleDefinitionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "role_definition_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
