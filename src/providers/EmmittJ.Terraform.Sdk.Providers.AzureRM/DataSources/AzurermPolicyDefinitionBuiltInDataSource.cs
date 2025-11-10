using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_policy_definition_built_in.
/// </summary>
public class AzurermPolicyDefinitionBuiltInDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionBuiltInDataSource(string name) : base("azurerm_policy_definition_built_in", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("metadata");
        SetOutput("mode");
        SetOutput("parameters");
        SetOutput("policy_rule");
        SetOutput("policy_type");
        SetOutput("role_definition_ids");
        SetOutput("type");
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
    public AzurermPolicyDefinitionBuiltInDataSourceTimeoutsBlock? Timeouts
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
    /// The mode attribute.
    /// </summary>
    public TerraformExpression Mode => this["mode"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    public TerraformExpression PolicyRule => this["policy_rule"];

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformExpression PolicyType => this["policy_type"];

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionIds => this["role_definition_ids"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
