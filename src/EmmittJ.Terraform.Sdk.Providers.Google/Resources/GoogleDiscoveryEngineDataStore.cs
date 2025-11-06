using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_data_store resource.
/// </summary>
public class GoogleDiscoveryEngineDataStore : TerraformResource
{
    public GoogleDiscoveryEngineDataStore(string name) : base("google_discovery_engine_data_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("default_schema_id");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The content config of the data store. Possible values: [&amp;quot;NO_CONTENT&amp;quot;, &amp;quot;CONTENT_REQUIRED&amp;quot;, &amp;quot;PUBLIC_WEBSITE&amp;quot;]
    /// </summary>
    public string? ContentConfig
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_config")?.Value;
        set => this.WithProperty("content_config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, an advanced data store for site search will be created. If the
    /// data store is not configured as site search (GENERIC vertical and
    /// PUBLIC_WEBSITE contentConfig), this flag will be ignored.
    /// </summary>
    public bool? CreateAdvancedSiteSearch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_advanced_site_search")?.Value;
        set => this.WithProperty("create_advanced_site_search", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    public string? DataStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_store_id")?.Value;
        set => this.WithProperty("data_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the data store. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The industry vertical that the data store registers. Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    public string? IndustryVertical
    {
        get => GetProperty<TerraformLiteralProperty<string>>("industry_vertical")?.Value;
        set => this.WithProperty("industry_vertical", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources:
    /// &#39;/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;
    /// The KMS key to be used to protect this DataStore at creation time. Must be
    /// set for requests that need to comply with CMEK Org Policy protections.
    /// If this field is set and processed successfully, the DataStore will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    public string? KmsKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_name")?.Value;
        set => this.WithProperty("kms_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A boolean flag indicating whether to skip the default schema creation for
    /// the data store. Only enable this flag if you are certain that the default
    /// schema is incompatible with your use case.
    /// If set to true, you must manually create a schema for the data store
    /// before any documents can be ingested.
    /// This flag cannot be specified if &#39;data_store.starting_schema&#39; is
    /// specified.
    /// </summary>
    public bool? SkipDefaultSchemaCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_default_schema_creation")?.Value;
        set => this.WithProperty("skip_default_schema_creation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The solutions that the data store enrolls. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    public List<string>? SolutionTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("solution_types")?.Value;
        set => this.WithProperty("solution_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Timestamp when the DataStore was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The id of the default Schema associated with this data store.
    /// </summary>
    public TerraformExpression DefaultSchemaId => this["default_schema_id"];

    /// <summary>
    /// The unique full resource name of the data store. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
