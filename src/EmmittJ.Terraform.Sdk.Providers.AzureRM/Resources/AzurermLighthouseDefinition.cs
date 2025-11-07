using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lighthouse_definition resource.
/// </summary>
public class AzurermLighthouseDefinition : TerraformResource
{
    public AzurermLighthouseDefinition(string name) : base("azurerm_lighthouse_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lighthouse_definition_id attribute.
    /// </summary>
    public TerraformProperty<string>? LighthouseDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("lighthouse_definition_id");
        set => this.WithProperty("lighthouse_definition_id", value);
    }

    /// <summary>
    /// The managing_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagingTenantId
    {
        get => GetProperty<TerraformProperty<string>>("managing_tenant_id");
        set => this.WithProperty("managing_tenant_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

}
