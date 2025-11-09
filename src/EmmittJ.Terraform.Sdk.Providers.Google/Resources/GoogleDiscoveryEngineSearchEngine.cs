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
    public TerraformProperty<string>? AppType
    {
        get => GetProperty<TerraformProperty<string>>("app_type");
        set => this.WithProperty("app_type", value);
    }

    /// <summary>
    /// The collection ID.
    /// </summary>
    public TerraformProperty<string>? CollectionId
    {
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => this.WithProperty("collection_id", value);
    }

    /// <summary>
    /// The data stores associated with this engine. For SOLUTION_TYPE_SEARCH type of engines, they can only associate with at most one data store.
    /// </summary>
    public TerraformProperty<List<string>>? DataStoreIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("data_store_ids");
        set => this.WithProperty("data_store_ids", value);
    }

    /// <summary>
    /// Required. The display name of the engine. Should be human readable. UTF-8 encoded string with limit of 1024 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Unique ID to use for Search Engine App.
    /// </summary>
    public TerraformProperty<string>? EngineId
    {
        get => GetProperty<TerraformProperty<string>>("engine_id");
        set => this.WithProperty("engine_id", value);
    }

    /// <summary>
    /// A map of the feature config for the engine to opt in or opt out of features.
    /// </summary>
    public TerraformMapProperty<string>? Features
    {
        get => GetProperty<TerraformMapProperty<string>>("features");
        set => this.WithProperty("features", value);
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
    /// The industry vertical that the engine registers. The restriction of the Engine industry vertical is based on DataStore: If unspecified, default to GENERIC. Vertical on Engine has to match vertical of the DataStore liniked to the engine. Default value: &amp;quot;GENERIC&amp;quot; Possible values: [&amp;quot;GENERIC&amp;quot;, &amp;quot;MEDIA&amp;quot;, &amp;quot;HEALTHCARE_FHIR&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IndustryVertical
    {
        get => GetProperty<TerraformProperty<string>>("industry_vertical");
        set => this.WithProperty("industry_vertical", value);
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
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// Location.
    /// </summary>
    public TerraformProperty<string>? Location
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
