using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_linked_service resource.
/// </summary>
public class AzurermSynapseLinkedService : TerraformResource
{
    public AzurermSynapseLinkedService(string name) : base("azurerm_synapse_linked_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The type_properties_json attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TypePropertiesJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_properties_json");
        set => this.WithProperty("type_properties_json", value);
    }

}
