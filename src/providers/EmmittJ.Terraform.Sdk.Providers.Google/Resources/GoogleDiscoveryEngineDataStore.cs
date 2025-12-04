using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_site_search_config in GoogleDiscoveryEngineDataStore.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_site_search_config";

    /// <summary>
    /// If set true, automatic refresh is disabled for the DataStore.
    /// </summary>
    public TerraformValue<bool>? DisableAutomaticRefresh
    {
        get => GetArgument<TerraformValue<bool>>("disable_automatic_refresh");
        set => SetArgument("disable_automatic_refresh", value);
    }

    /// <summary>
    /// If set true, initial indexing is disabled for the DataStore.
    /// </summary>
    public TerraformValue<bool>? DisableInitialIndex
    {
        get => GetArgument<TerraformValue<bool>>("disable_initial_index");
        set => SetArgument("disable_initial_index", value);
    }

}


/// <summary>
/// Block type for document_processing_config in GoogleDiscoveryEngineDataStore.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "document_processing_config";

    /// <summary>
    /// The full resource name of the Document Processing Config. Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/documentProcessingConfig&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ChunkingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChunkingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlock>? ChunkingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlock>>("chunking_config");
        set => SetArgument("chunking_config", value);
    }

    /// <summary>
    /// DefaultParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock>? DefaultParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock>>("default_parsing_config");
        set => SetArgument("default_parsing_config", value);
    }

    /// <summary>
    /// ParsingConfigOverrides block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock>? ParsingConfigOverrides
    {
        get => GetArgument<TerraformSet<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock>>("parsing_config_overrides");
        set => SetArgument("parsing_config_overrides", value);
    }

}

/// <summary>
/// Block type for chunking_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "chunking_config";

    /// <summary>
    /// LayoutBasedChunkingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LayoutBasedChunkingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlockLayoutBasedChunkingConfigBlock>? LayoutBasedChunkingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlockLayoutBasedChunkingConfigBlock>>("layout_based_chunking_config");
        set => SetArgument("layout_based_chunking_config", value);
    }

}

/// <summary>
/// Block type for layout_based_chunking_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockChunkingConfigBlockLayoutBasedChunkingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layout_based_chunking_config";

    /// <summary>
    /// The token size limit for each chunk.
    /// Supported values: 100-500 (inclusive). Default value: 500.
    /// </summary>
    public TerraformValue<double>? ChunkSize
    {
        get => GetArgument<TerraformValue<double>>("chunk_size");
        set => SetArgument("chunk_size", value);
    }

    /// <summary>
    /// Whether to include appending different levels of headings to chunks from the middle of the document to prevent context loss.
    /// Default value: False.
    /// </summary>
    public TerraformValue<bool>? IncludeAncestorHeadings
    {
        get => GetArgument<TerraformValue<bool>>("include_ancestor_headings");
        set => SetArgument("include_ancestor_headings", value);
    }

}

/// <summary>
/// Block type for default_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_parsing_config";

    /// <summary>
    /// DigitalParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DigitalParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockDigitalParsingConfigBlock>? DigitalParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockDigitalParsingConfigBlock>>("digital_parsing_config");
        set => SetArgument("digital_parsing_config", value);
    }

    /// <summary>
    /// LayoutParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LayoutParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockLayoutParsingConfigBlock>? LayoutParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockLayoutParsingConfigBlock>>("layout_parsing_config");
        set => SetArgument("layout_parsing_config", value);
    }

    /// <summary>
    /// OcrParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OcrParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockOcrParsingConfigBlock>? OcrParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockOcrParsingConfigBlock>>("ocr_parsing_config");
        set => SetArgument("ocr_parsing_config", value);
    }

}

/// <summary>
/// Block type for digital_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockDigitalParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "digital_parsing_config";

}

/// <summary>
/// Block type for layout_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockLayoutParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layout_parsing_config";

    /// <summary>
    /// If true, the LLM based annotation is added to the image during parsing.
    /// </summary>
    public TerraformValue<bool>? EnableImageAnnotation
    {
        get => GetArgument<TerraformValue<bool>>("enable_image_annotation");
        set => SetArgument("enable_image_annotation", value);
    }

    /// <summary>
    /// If true, the LLM based annotation is added to the table during parsing.
    /// </summary>
    public TerraformValue<bool>? EnableTableAnnotation
    {
        get => GetArgument<TerraformValue<bool>>("enable_table_annotation");
        set => SetArgument("enable_table_annotation", value);
    }

    /// <summary>
    /// List of HTML classes to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlClasses
    {
        get => GetArgument<TerraformList<string>>("exclude_html_classes");
        set => SetArgument("exclude_html_classes", value);
    }

    /// <summary>
    /// List of HTML elements to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlElements
    {
        get => GetArgument<TerraformList<string>>("exclude_html_elements");
        set => SetArgument("exclude_html_elements", value);
    }

    /// <summary>
    /// List of HTML ids to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlIds
    {
        get => GetArgument<TerraformList<string>>("exclude_html_ids");
        set => SetArgument("exclude_html_ids", value);
    }

    /// <summary>
    /// Contains the required structure types to extract from the document. Supported values: &#39;shareholder-structure&#39;.
    /// </summary>
    public TerraformList<string>? StructuredContentTypes
    {
        get => GetArgument<TerraformList<string>>("structured_content_types");
        set => SetArgument("structured_content_types", value);
    }

}

/// <summary>
/// Block type for ocr_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockDefaultParsingConfigBlockOcrParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ocr_parsing_config";

    /// <summary>
    /// If true, will use native text instead of OCR text on pages containing native text.
    /// </summary>
    public TerraformValue<bool>? UseNativeText
    {
        get => GetArgument<TerraformValue<bool>>("use_native_text");
        set => SetArgument("use_native_text", value);
    }

}

/// <summary>
/// Block type for parsing_config_overrides in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parsing_config_overrides";

    /// <summary>
    /// The file_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileType is required")]
    public required TerraformValue<string> FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

    /// <summary>
    /// DigitalParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DigitalParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockDigitalParsingConfigBlock>? DigitalParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockDigitalParsingConfigBlock>>("digital_parsing_config");
        set => SetArgument("digital_parsing_config", value);
    }

    /// <summary>
    /// LayoutParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LayoutParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockLayoutParsingConfigBlock>? LayoutParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockLayoutParsingConfigBlock>>("layout_parsing_config");
        set => SetArgument("layout_parsing_config", value);
    }

    /// <summary>
    /// OcrParsingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OcrParsingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockOcrParsingConfigBlock>? OcrParsingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockOcrParsingConfigBlock>>("ocr_parsing_config");
        set => SetArgument("ocr_parsing_config", value);
    }

}

/// <summary>
/// Block type for digital_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockDigitalParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "digital_parsing_config";

}

/// <summary>
/// Block type for layout_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockLayoutParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "layout_parsing_config";

    /// <summary>
    /// If true, the LLM based annotation is added to the image during parsing.
    /// </summary>
    public TerraformValue<bool>? EnableImageAnnotation
    {
        get => GetArgument<TerraformValue<bool>>("enable_image_annotation");
        set => SetArgument("enable_image_annotation", value);
    }

    /// <summary>
    /// If true, the LLM based annotation is added to the table during parsing.
    /// </summary>
    public TerraformValue<bool>? EnableTableAnnotation
    {
        get => GetArgument<TerraformValue<bool>>("enable_table_annotation");
        set => SetArgument("enable_table_annotation", value);
    }

    /// <summary>
    /// List of HTML classes to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlClasses
    {
        get => GetArgument<TerraformList<string>>("exclude_html_classes");
        set => SetArgument("exclude_html_classes", value);
    }

    /// <summary>
    /// List of HTML elements to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlElements
    {
        get => GetArgument<TerraformList<string>>("exclude_html_elements");
        set => SetArgument("exclude_html_elements", value);
    }

    /// <summary>
    /// List of HTML ids to exclude from the parsed content.
    /// </summary>
    public TerraformList<string>? ExcludeHtmlIds
    {
        get => GetArgument<TerraformList<string>>("exclude_html_ids");
        set => SetArgument("exclude_html_ids", value);
    }

    /// <summary>
    /// Contains the required structure types to extract from the document. Supported values: &#39;shareholder-structure&#39;.
    /// </summary>
    public TerraformList<string>? StructuredContentTypes
    {
        get => GetArgument<TerraformList<string>>("structured_content_types");
        set => SetArgument("structured_content_types", value);
    }

}

/// <summary>
/// Block type for ocr_parsing_config in GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlockParsingConfigOverridesBlockOcrParsingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ocr_parsing_config";

    /// <summary>
    /// If true, will use native text instead of OCR text on pages containing native text.
    /// </summary>
    public TerraformValue<bool>? UseNativeText
    {
        get => GetArgument<TerraformValue<bool>>("use_native_text");
        set => SetArgument("use_native_text", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineDataStore.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineDataStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_data_store Terraform resource.
/// Manages a google_discovery_engine_data_store resource.
/// </summary>
public partial class GoogleDiscoveryEngineDataStore(string name) : TerraformResource("google_discovery_engine_data_store", name)
{
    /// <summary>
    /// The content config of the data store. Possible values: [&amp;quot;NO_CONTENT&amp;quot;, &amp;quot;CONTENT_REQUIRED&amp;quot;, &amp;quot;PUBLIC_WEBSITE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentConfig is required")]
    public required TerraformValue<string> ContentConfig
    {
        get => GetArgument<TerraformValue<string>>("content_config");
        set => SetArgument("content_config", value);
    }

    /// <summary>
    /// If true, an advanced data store for site search will be created. If the
    /// data store is not configured as site search (GENERIC vertical and
    /// PUBLIC_WEBSITE contentConfig), this flag will be ignored.
    /// </summary>
    public TerraformValue<bool>? CreateAdvancedSiteSearch
    {
        get => GetArgument<TerraformValue<bool>>("create_advanced_site_search");
        set => SetArgument("create_advanced_site_search", value);
    }

    /// <summary>
    /// The unique id of the data store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStoreId is required")]
    public required TerraformValue<string> DataStoreId
    {
        get => GetArgument<TerraformValue<string>>("data_store_id");
        set => SetArgument("data_store_id", value);
    }

    /// <summary>
    /// The display name of the data store. This field must be a UTF-8 encoded
    /// string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The industry vertical that the data store registers. Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndustryVertical is required")]
    public required TerraformValue<string> IndustryVertical
    {
        get => GetArgument<TerraformValue<string>>("industry_vertical");
        set => SetArgument("industry_vertical", value);
    }

    /// <summary>
    /// KMS key resource name which will be used to encrypt resources:
    /// &#39;/{project}/locations/{location}/keyRings/{keyRing}/cryptoKeys/{keyId}&#39;
    /// The KMS key to be used to protect this DataStore at creation time. Must be
    /// set for requests that need to comply with CMEK Org Policy protections.
    /// If this field is set and processed successfully, the DataStore will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
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
    public TerraformValue<bool>? SkipDefaultSchemaCreation
    {
        get => GetArgument<TerraformValue<bool>>("skip_default_schema_creation");
        set => SetArgument("skip_default_schema_creation", value);
    }

    /// <summary>
    /// The solutions that the data store enrolls. Possible values: [&amp;quot;SOLUTION_TYPE_RECOMMENDATION&amp;quot;, &amp;quot;SOLUTION_TYPE_SEARCH&amp;quot;, &amp;quot;SOLUTION_TYPE_CHAT&amp;quot;, &amp;quot;SOLUTION_TYPE_GENERATIVE_CHAT&amp;quot;]
    /// </summary>
    public TerraformList<string>? SolutionTypes
    {
        get => GetArgument<TerraformList<string>>("solution_types");
        set => SetArgument("solution_types", value);
    }

    /// <summary>
    /// Timestamp when the DataStore was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The id of the default Schema associated with this data store.
    /// </summary>
    public TerraformValue<string> DefaultSchemaId
        => AsReference("default_schema_id");

    /// <summary>
    /// The unique full resource name of the data store. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// AdvancedSiteSearchConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSiteSearchConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock>? AdvancedSiteSearchConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreAdvancedSiteSearchConfigBlock>>("advanced_site_search_config");
        set => SetArgument("advanced_site_search_config", value);
    }

    /// <summary>
    /// DocumentProcessingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentProcessingConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock>? DocumentProcessingConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineDataStoreDocumentProcessingConfigBlock>>("document_processing_config");
        set => SetArgument("document_processing_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineDataStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineDataStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
