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
    /// The namespace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The schema_compatibility attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SchemaCompatibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_compatibility");
        set => this.WithProperty("schema_compatibility", value);
    }

    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SchemaType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_type");
        set => this.WithProperty("schema_type", value);
    }

}
