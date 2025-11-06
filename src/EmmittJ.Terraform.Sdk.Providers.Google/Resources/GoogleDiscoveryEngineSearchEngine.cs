using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_discovery_engine_search_engine resource.
/// </summary>
public class GoogleDiscoveryEngineSearchEngine : TerraformResource
{
    public GoogleDiscoveryEngineSearchEngine(string name) : base("google_discovery_engine_search_engine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// This is the application type this engine resource represents.
    /// The supported values: &#39;APP_TYPE_UNSPECIFIED&#39;, &#39;APP_TYPE_INTRANET&#39;.
    /// </summary>
    public string? AppType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_type")?.Value;
        set => this.WithProperty("app_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collection ID.
    /// </summary>
    public string? CollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collection_id")?.Value;
        set => this.WithProperty("collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_SEARCH type of engines, they can only associate with at most one data store.
    /// </summary>
    public List<string>? DataStoreIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("data_store_ids")?.Value;
        set => this.WithProperty("data_store_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Unique ID to use for Search Engine App.
    /// </summary>
    public string? EngineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_id")?.Value;
        set => this.WithProperty("engine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A map of the feature config for the engine to opt in or opt out of features.
    /// </summary>
    public Dictionary<string, string>? Features
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("features")?.Value;
        set => this.WithProperty("features", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    public string? IndustryVertical
    {
        get => GetProperty<TerraformLiteralProperty<string>>("industry_vertical")?.Value;
        set => this.WithProperty("industry_vertical", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The KMS key to be used to protect this Engine at creation time.
    /// 
    /// Must be set for requests that need to comply with CMEK Org Policy
    /// protections.
    /// 
    /// If this field is set and processed successfully, the Engine will be
    /// protected by the KMS key, as indicated in the cmek_config field.
    /// </summary>
    public string? KmsKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_name")?.Value;
        set => this.WithProperty("kms_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Location.
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
    /// Timestamp the Engine was created at.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique full resource name of the search engine. Values are of the format
    /// &#39;projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}&#39;.
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Timestamp the Engine was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
