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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lighthouse_definition_id attribute.
    /// </summary>
    public string? LighthouseDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lighthouse_definition_id")?.Value;
        set => this.WithProperty("lighthouse_definition_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managing_tenant_id attribute.
    /// </summary>
    public string? ManagingTenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managing_tenant_id")?.Value;
        set => this.WithProperty("managing_tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
