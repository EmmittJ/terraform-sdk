using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_policy_definition resource.
/// </summary>
public class AzurermPolicyDefinition : TerraformResource
{
    public AzurermPolicyDefinition(string name) : base("azurerm_policy_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("role_definition_ids");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    public string? ManagementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_group_id")?.Value;
        set => this.WithProperty("management_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public string? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public string? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    public string? PolicyRule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_rule")?.Value;
        set => this.WithProperty("policy_rule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public string? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type")?.Value;
        set => this.WithProperty("policy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionIds => this["role_definition_ids"];

}
