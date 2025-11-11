using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_site_search_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock
{
    /// <summary>
    /// If set true, automatic refresh is disabled for the DataStore.
    /// </summary>
    [TerraformPropertyName("disable_automatic_refresh")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableAutomaticRefresh { get; set; }

    /// <summary>
    /// If set true, initial indexing is disabled for the DataStore.
    /// </summary>
    [TerraformPropertyName("disable_initial_index")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableInitialIndex { get; set; }

}

/// <summary>
/// Block type for document_processing_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock
{

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineDataStoreTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_data_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineDataStore : TerraformResource
{
    public GoogleDiscoveryEngineDataStore(string name) : base("google_discovery_engine_data_store", name)
    {
    }

    /// <summary>
    /// The content config of the data store. Possible values: [&amp;quot;NO_CONTENT&amp;quot;, &amp;quot;CONTENT_REQUIRED&amp;quot;, &amp;quot;PUBLIC_WEBSITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentConfig is required")]
    [TerraformPropertyName("content_config")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContentConfig { get; set; }

    /// <summary>
    /// If true, an advanced data store for site search will be created. If the
    /// data store is not configured as site search (GENERIC vertical and
    /// PUBLIC_WEBSITE contentConfig), this flag will be ignored.
    /// </summary>
    [TerraformPropertyName("create_advanced_site_search")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateAdvancedSiteSearch { get; set; }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    [TerraformPropertyName("data_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataStoreId { get; set; }

    /// <summary>
    /// The display name of the data store. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The industry vertical that the data store registers. Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndustryVertical is required")]
    [TerraformPropertyName("industry_vertical")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IndustryVertical { get; set; }

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources:
    /// &#39;/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;
    /// The KMS key to be used to protect this DataStore at creation time. Must be
    /// set for requests that need to comply with CMEK Org Policy protections.
    /// If this field is set and processed successfully, the DataStore will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// A boolean flag indicating whether to skip the default schema creation for
    /// the data store. Only enable this flag if you are certain that the default
    /// schema is incompatible with your use case.
    /// If set to true, you must manually create a schema for the data store
    /// before any documents can be ingested.
    /// This flag cannot be specified if &#39;data_store.starting_schema&#39; is
    /// specified.
    /// </summary>
    [TerraformPropertyName("skip_default_schema_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipDefaultSchemaCreation { get; set; }

    /// <summary>
    /// The solutions that the data store enrolls. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("solution_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SolutionTypes { get; set; }

    /// <summary>
    /// Block for advanced_site_search_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSiteSearchConfig block(s) allowed")]
    [TerraformPropertyName("advanced_site_search_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock>>? AdvancedSiteSearchConfig { get; set; }

    /// <summary>
    /// Block for document_processing_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentProcessingConfig block(s) allowed")]
    [TerraformPropertyName("document_processing_config")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock>>? DocumentProcessingConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineDataStoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Timestamp when the DataStore was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The id of the default Schema associated with this data store.
    /// </summary>
    [TerraformPropertyName("default_schema_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSchemaId => new TerraformReference(this, "default_schema_id");

    /// <summary>
    /// The unique full resource name of the data store. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
