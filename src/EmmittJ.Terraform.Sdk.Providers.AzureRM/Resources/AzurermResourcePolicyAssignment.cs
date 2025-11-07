using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_policy_assignment resource.
/// </summary>
public class AzurermResourcePolicyAssignment : TerraformResource
{
    public AzurermResourcePolicyAssignment(string name) : base("azurerm_resource_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enforce
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enforce");
        set => this.WithProperty("enforce", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NotScopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("not_scopes");
        set => this.WithProperty("not_scopes", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_definition_id");
        set => this.WithProperty("policy_definition_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

}
