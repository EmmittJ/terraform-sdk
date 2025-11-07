using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_schema resource.
/// </summary>
public class GoogleDiscoveryEngineSchema : TerraformResource
{
    public GoogleDiscoveryEngineSchema(string name) : base("google_discovery_engine_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    public TerraformLiteralProperty<string>? DataStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_store_id");
        set => this.WithProperty("data_store_id", value);
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
    /// The JSON representation of the schema.
    /// </summary>
    public TerraformLiteralProperty<string>? JsonSchema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("json_schema");
        set => this.WithProperty("json_schema", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The unique id of the schema.
    /// </summary>
    public TerraformLiteralProperty<string>? SchemaId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_id");
        set => this.WithProperty("schema_id", value);
    }

    /// <summary>
    /// The unique full resource name of the schema. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/schemas/{schema_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
