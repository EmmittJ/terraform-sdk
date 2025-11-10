using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicySetDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_policy_set_definition.
/// </summary>
public class AzurermPolicySetDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicySetDefinitionDataSource(string name) : base("azurerm_policy_set_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("metadata");
        SetOutput("parameters");
        SetOutput("policy_definition_group");
        SetOutput("policy_definition_reference");
        SetOutput("policy_definitions");
        SetOutput("policy_type");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("management_group_name");
        SetOutput("name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
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
    /// The management_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ManagementGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("management_group_name");
        set => SetProperty("management_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPolicySetDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The policy_definition_group attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitionGroup => this["policy_definition_group"];

    /// <summary>
    /// The policy_definition_reference attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitionReference => this["policy_definition_reference"];

    /// <summary>
    /// The policy_definitions attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitions => this["policy_definitions"];

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformExpression PolicyType => this["policy_type"];

}
