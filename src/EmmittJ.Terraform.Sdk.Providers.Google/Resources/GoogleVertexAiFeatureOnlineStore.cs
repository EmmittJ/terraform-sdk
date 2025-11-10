using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigtable in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreBigtableBlock : TerraformBlock
{
}

/// <summary>
/// Block type for dedicated_serving_endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Domain name to use for this FeatureOnlineStore
    /// </summary>
    public TerraformProperty<string>? PublicEndpointDomainName
    {
        get => GetProperty<TerraformProperty<string>>("public_endpoint_domain_name");
        set => WithProperty("public_endpoint_domain_name", value);
    }

    /// <summary>
    /// Name of the service attachment resource. Applicable only if private service connect is enabled and after FeatureViewSync is created.
    /// </summary>
    public TerraformProperty<string>? ServiceAttachment
    {
        get => GetProperty<TerraformProperty<string>>("service_attachment");
        set => WithProperty("service_attachment", value);
    }

}

/// <summary>
/// Block type for optimized in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreOptimizedBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreTimeoutsBlock : TerraformBlock
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
/// Manages a google_vertex_ai_feature_online_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiFeatureOnlineStore : TerraformResource
{
    public GoogleVertexAiFeatureOnlineStore(string name) : base("google_vertex_ai_feature_online_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If set to true, any FeatureViews and Features for this FeatureOnlineStore will also be deleted.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The labels with user-defined metadata to organize your feature online stores.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name of the Feature Online Store. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The region of feature online store. eg us-central1
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for bigtable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bigtable block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreBigtableBlock>? Bigtable
    {
        get => GetProperty<List<GoogleVertexAiFeatureOnlineStoreBigtableBlock>>("bigtable");
        set => this.WithProperty("bigtable", value);
    }

    /// <summary>
    /// Block for dedicated_serving_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedServingEndpoint block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock>? DedicatedServingEndpoint
    {
        get => GetProperty<List<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock>>("dedicated_serving_endpoint");
        set => this.WithProperty("dedicated_serving_endpoint", value);
    }

    /// <summary>
    /// Block for optimized.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Optimized block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreOptimizedBlock>? Optimized
    {
        get => GetProperty<List<GoogleVertexAiFeatureOnlineStoreOptimizedBlock>>("optimized");
        set => this.WithProperty("optimized", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiFeatureOnlineStoreTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiFeatureOnlineStoreTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the feature online store was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The state of the Feature Online Store. See the possible states in [this link](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.featureOnlineStores#state).
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp of when the feature online store was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
