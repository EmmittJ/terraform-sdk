using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Allows inserting, updating  or deleting the contents of the Matching Engine Index.
    /// The string must be a valid Cloud Storage directory path. If this
    /// field is set when calling IndexService.UpdateIndex, then no other
    /// Index field can be also updated as part of the same call.
    /// The expected structure and format of the files this URI points to is
    /// described at https://cloud.google.com/vertex-ai/docs/matching-engine/using-matching-engine#input-data-format
    /// </summary>
    public TerraformProperty<string>? ContentsDeltaUri
    {
        get => GetProperty<TerraformProperty<string>>("contents_delta_uri");
        set => WithProperty("contents_delta_uri", value);
    }

    /// <summary>
    /// If this field is set together with contentsDeltaUri when calling IndexService.UpdateIndex,
    /// then existing content of the Index will be replaced by the data from the contentsDeltaUri.
    /// </summary>
    public TerraformProperty<bool>? IsCompleteOverwrite
    {
        get => GetProperty<TerraformProperty<bool>>("is_complete_overwrite");
        set => WithProperty("is_complete_overwrite", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexTimeoutsBlock : TerraformBlock
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
/// Manages a google_vertex_ai_index resource.
/// </summary>
public class GoogleVertexAiIndex : TerraformResource
{
    public GoogleVertexAiIndex(string name) : base("google_vertex_ai_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("deployed_indexes");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("index_stats");
        this.DeclareOutput("metadata_schema_uri");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The description of the Index.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
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
    /// The update method to use with this Index. The value must be the followings. If not set, BATCH_UPDATE will be used by default.
    /// * BATCH_UPDATE: user can call indexes.patch with files on Cloud Storage of datapoints to update.
    /// * STREAM_UPDATE: user can call indexes.upsertDatapoints/DeleteDatapoints to update the Index and the updates will be applied in corresponding DeployedIndexes in nearly real-time.
    /// </summary>
    public TerraformProperty<string>? IndexUpdateMethod
    {
        get => GetProperty<TerraformProperty<string>>("index_update_method");
        set => this.WithProperty("index_update_method", value);
    }

    /// <summary>
    /// The labels with user-defined metadata to organize your Indexes.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the index. eg us-central1
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public List<GoogleVertexAiIndexEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetProperty<List<GoogleVertexAiIndexEncryptionSpecBlock>>("encryption_spec");
        set => this.WithProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metadata block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public List<GoogleVertexAiIndexMetadataBlock>? Metadata
    {
        get => GetProperty<List<GoogleVertexAiIndexMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiIndexTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiIndexTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The pointers to DeployedIndexes created from this Index. An Index can be only deleted if all its DeployedIndexes had been undeployed first.
    /// </summary>
    public TerraformExpression DeployedIndexes => this["deployed_indexes"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Stats of the index resource.
    /// </summary>
    public TerraformExpression IndexStats => this["index_stats"];

    /// <summary>
    /// Points to a YAML file stored on Google Cloud Storage describing additional information about the Index, that is specific to it. Unset if the Index does not have any additional information.
    /// </summary>
    public TerraformExpression MetadataSchemaUri => this["metadata_schema_uri"];

    /// <summary>
    /// The resource name of the Index.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
