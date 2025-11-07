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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lighthouse_definition_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LighthouseDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lighthouse_definition_id");
        set => this.WithProperty("lighthouse_definition_id", value);
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
    /// The scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

}
