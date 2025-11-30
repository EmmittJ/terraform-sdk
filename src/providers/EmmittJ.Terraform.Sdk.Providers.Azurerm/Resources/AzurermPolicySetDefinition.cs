using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for policy_definition_group in AzurermPolicySetDefinition.
/// Nesting mode: set
/// </summary>
public class AzurermPolicySetDefinitionPolicyDefinitionGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_definition_group";

    /// <summary>
    /// The additional_metadata_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalMetadataResourceId
    {
        get => new TerraformReference<string>(this, "additional_metadata_resource_id");
        set => SetArgument("additional_metadata_resource_id", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformValue<string>? Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for policy_definition_reference in AzurermPolicySetDefinition.
/// Nesting mode: list
/// </summary>
public class AzurermPolicySetDefinitionPolicyDefinitionReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_definition_reference";

    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    public TerraformValue<string>? ParameterValues
    {
        get => new TerraformReference<string>(this, "parameter_values");
        set => SetArgument("parameter_values", value);
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
    /// The policy_group_names attribute.
    /// </summary>
    public TerraformSet<string>? PolicyGroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_group_names").ResolveNodes(ctx));
        set => SetArgument("policy_group_names", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformValue<string> ReferenceId
    {
        get => new TerraformReference<string>(this, "reference_id");
        set => SetArgument("reference_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPolicySetDefinition.
/// Nesting mode: single
/// </summary>
public class AzurermPolicySetDefinitionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_policy_set_definition Terraform resource.
/// Manages a azurerm_policy_set_definition resource.
/// </summary>
public partial class AzurermPolicySetDefinition(string name) : TerraformResource("azurerm_policy_set_definition", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
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
    /// The management_group_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ManagementGroupId
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
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// PolicyDefinitionGroup block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermPolicySetDefinitionPolicyDefinitionGroupBlock>? PolicyDefinitionGroup
    {
        get => GetArgument<TerraformSet<AzurermPolicySetDefinitionPolicyDefinitionGroupBlock>>("policy_definition_group");
        set => SetArgument("policy_definition_group", value);
    }

    /// <summary>
    /// PolicyDefinitionReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDefinitionReference block(s) required")]
    public required TerraformList<AzurermPolicySetDefinitionPolicyDefinitionReferenceBlock> PolicyDefinitionReference
    {
        get => GetRequiredArgument<TerraformList<AzurermPolicySetDefinitionPolicyDefinitionReferenceBlock>>("policy_definition_reference");
        set => SetArgument("policy_definition_reference", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicySetDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicySetDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
