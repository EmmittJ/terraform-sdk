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
    public TerraformMapProperty<string>? AdditionalProperties
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The type_properties_json attribute.
    /// </summary>
    public TerraformProperty<string>? TypePropertiesJson
    {
        get => GetProperty<TerraformProperty<string>>("type_properties_json");
        set => this.WithProperty("type_properties_json", value);
    }

}
