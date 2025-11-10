using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for policy_definition_group in .
/// Nesting mode: set
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock : TerraformBlock
{
    /// <summary>
    /// The additional_metadata_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalMetadataResourceId
    {
        set => SetProperty("additional_metadata_resource_id", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformProperty<string>? Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for policy_definition_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterValues
    {
        set => SetProperty("parameter_values", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionId is required")]
    public required TerraformProperty<string> PolicyDefinitionId
    {
        set => SetProperty("policy_definition_id", value);
    }

    /// <summary>
    /// The policy_group_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PolicyGroupNames
    {
        set => SetProperty("policy_group_names", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReferenceId
    {
        set => SetProperty("reference_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicySetDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("management_group_id");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("policy_type");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("management_group_id");
        set => SetProperty("management_group_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<string> Metadata
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<string> Parameters
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformProperty<string> PolicyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_type");
        set => SetProperty("policy_type", value);
    }

    /// <summary>
    /// Block for policy_definition_group.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionGroupBlock>? PolicyDefinitionGroup
    {
        set => SetProperty("policy_definition_group", value);
    }

    /// <summary>
    /// Block for policy_definition_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDefinitionReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDefinitionReference block(s) required")]
    public List<AzurermManagementGroupPolicySetDefinitionPolicyDefinitionReferenceBlock>? PolicyDefinitionReference
    {
        set => SetProperty("policy_definition_reference", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagementGroupPolicySetDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
