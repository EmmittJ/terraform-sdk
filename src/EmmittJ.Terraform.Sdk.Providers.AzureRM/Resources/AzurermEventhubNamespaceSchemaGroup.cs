using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventhub_namespace_schema_group resource.
/// </summary>
public class AzurermEventhubNamespaceSchemaGroup : TerraformResource
{
    public AzurermEventhubNamespaceSchemaGroup(string name) : base("azurerm_eventhub_namespace_schema_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The schema_compatibility attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaCompatibility
    {
        get => GetProperty<TerraformProperty<string>>("schema_compatibility");
        set => this.WithProperty("schema_compatibility", value);
    }

    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaType
    {
        get => GetProperty<TerraformProperty<string>>("schema_type");
        set => this.WithProperty("schema_type", value);
    }

}
