using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lighthouse_assignment resource.
/// </summary>
public class AzurermLighthouseAssignment : TerraformResource
{
    public AzurermLighthouseAssignment(string name) : base("azurerm_lighthouse_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
