using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_site_search_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock : TerraformBlock
{
    /// <summary>
    /// If set true, automatic refresh is disabled for the DataStore.
    /// </summary>
    public TerraformProperty<bool>? DisableAutomaticRefresh
    {
        get => GetProperty<TerraformProperty<bool>>("disable_automatic_refresh");
        set => WithProperty("disable_automatic_refresh", value);
    }

    /// <summary>
    /// If set true, initial indexing is disabled for the DataStore.
    /// </summary>
    public TerraformProperty<bool>? DisableInitialIndex
    {
        get => GetProperty<TerraformProperty<bool>>("disable_initial_index");
        set => WithProperty("disable_initial_index", value);
    }

}

/// <summary>
/// Block type for document_processing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The full resource name of the Document Processing Config. Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/documentProcessingConfig&#39;.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineDataStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentConfig is required")]
    public required TerraformProperty<string> ContentConfig
    {
        get => GetProperty<TerraformProperty<string>>("content_config");
        set => this.WithProperty("content_config", value);
    }

    /// <summary>
    /// If true, an advanced data store for site search will be created. If the
    /// data store is not configured as site search (GENERIC vertical and
    /// PUBLIC_WEBSITE contentConfig), this flag will be ignored.
    /// </summary>
    public TerraformProperty<bool>? CreateAdvancedSiteSearch
    {
        get => GetProperty<TerraformProperty<bool>>("create_advanced_site_search");
        set => this.WithProperty("create_advanced_site_search", value);
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    public required TerraformProperty<string> DataStoreId
    {
        get => GetProperty<TerraformProperty<string>>("data_store_id");
        set => this.WithProperty("data_store_id", value);
    }

    /// <summary>
    /// The display name of the data store. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The industry vertical that the data store registers. Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndustryVertical is required")]
    public required TerraformProperty<string> IndustryVertical
    {
        get => GetProperty<TerraformProperty<string>>("industry_vertical");
        set => this.WithProperty("industry_vertical", value);
    }

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources:
    /// &#39;/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;
    /// The KMS key to be used to protect this DataStore at creation time. Must be
    /// set for requests that need to comply with CMEK Org Policy protections.
    /// If this field is set and processed successfully, the DataStore will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<bool>? SkipDefaultSchemaCreation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_default_schema_creation");
        set => this.WithProperty("skip_default_schema_creation", value);
    }

    /// <summary>
    /// The solutions that the data store enrolls. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? SolutionTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("solution_types");
        set => this.WithProperty("solution_types", value);
    }

    /// <summary>
    /// Block for advanced_site_search_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSiteSearchConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock>? AdvancedSiteSearchConfig
    {
        get => GetProperty<List<GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock>>("advanced_site_search_config");
        set => this.WithProperty("advanced_site_search_config", value);
    }

    /// <summary>
    /// Block for document_processing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentProcessingConfig block(s) allowed")]
    public List<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock>? DocumentProcessingConfig
    {
        get => GetProperty<List<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock>>("document_processing_config");
        set => this.WithProperty("document_processing_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineDataStoreTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineDataStoreTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
