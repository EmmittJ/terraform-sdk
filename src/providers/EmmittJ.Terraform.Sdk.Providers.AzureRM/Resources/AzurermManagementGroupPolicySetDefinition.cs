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
/// Block type for policy_definition_group in .
/// Nesting mode: set
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_definition_group";

    /// <summary>
    /// The additional_metadata_resource_id attribute.
    /// </summary>
    [TerraformArgument("additional_metadata_resource_id")]
    public TerraformValue<string>? AdditionalMetadataResourceId
    {
        get => new TerraformReference<string>(this, "additional_metadata_resource_id");
        set => SetArgument("additional_metadata_resource_id", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformArgument("category")]
    public TerraformValue<string>? Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for policy_definition_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_definition_reference";

    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    [TerraformArgument("parameter_values")]
    public TerraformValue<string>? ParameterValues
    {
        get => new TerraformReference<string>(this, "parameter_values");
        set => SetArgument("parameter_values", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    [TerraformArgument("policy_definition_id")]
    public required TerraformValue<string> PolicyDefinitionId
    {
        get => new TerraformReference<string>(this, "policy_definition_id");
        set => SetArgument("policy_definition_id", value);
    }

    /// <summary>
    /// The policy_group_names attribute.
    /// </summary>
    [TerraformArgument("policy_group_names")]
    public TerraformSet<string>? PolicyGroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_group_names").ResolveNodes(ctx));
        set => SetArgument("policy_group_names", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    [TerraformArgument("reference_id")]
    public TerraformValue<string> ReferenceId
    {
        get => new TerraformReference<string>(this, "reference_id");
        set => SetArgument("reference_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_management_group_policy_set_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermManagementGroupPolicySetDefinition : TerraformResource
{
    public AzurermManagementGroupPolicySetDefinition(string name) : base("azurerm_management_group_policy_set_definition", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    [TerraformArgument("management_group_id")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => new TerraformReference<string>(this, "management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    [TerraformArgument("policy_type")]
    public required TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// Block for policy_definition_group.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("policy_definition_group")]
    public TerraformSet<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock> PolicyDefinitionGroup { get; set; } = new();

    /// <summary>
    /// Block for policy_definition_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDefinitionReference block(s) required")]
    [TerraformArgument("policy_definition_reference")]
    public required TerraformList<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock> PolicyDefinitionReference { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagementGroupPolicySetDefinitionTimeoutsBlock Timeouts { get; set; } = new();

}
