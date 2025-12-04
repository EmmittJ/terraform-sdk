using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vertex_ai_index Terraform data source.
/// Retrieves information about a google_vertex_ai_index.
/// </summary>
public partial class GoogleVertexAiIndexDataSource(string name) : TerraformDataSource("google_vertex_ai_index", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the Index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The region of the index. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The pointers to DeployedIndexes created from this Index. An Index can be only deleted if all its DeployedIndexes had been undeployed first.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeployedIndexes
        => AsReference("deployed_indexes");

    /// <summary>
    /// The description of the Index.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Customer-managed encryption key spec for an Index. If set, this Index and all sub-resources of this Index will be secured by this key.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionSpec
        => AsReference("encryption_spec");

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Stats of the index resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> IndexStats
        => AsReference("index_stats");

    /// <summary>
    /// The update method to use with this Index. The value must be the followings. If not set, BATCH_UPDATE will be used by default.
    /// * BATCH_UPDATE: user can call indexes.patch with files on Cloud Storage of datapoints to update.
    /// * STREAM_UPDATE: user can call indexes.upsertDatapoints/DeleteDatapoints to update the Index and the updates will be applied in corresponding DeployedIndexes in nearly real-time.
    /// </summary>
    public TerraformValue<string> IndexUpdateMethod
        => AsReference("index_update_method");

    /// <summary>
    /// The labels with user-defined metadata to organize your Indexes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Additional information about the Index.
    /// Although this field is not marked as required in the API specification, it is currently required when creating an Index and must be provided.
    /// Attempts to create an Index without this field will result in an API error.
    /// </summary>
    public TerraformList<TerraformMap<object>> Metadata
        => AsReference("metadata");

    /// <summary>
    /// Points to a YAML file stored on Google Cloud Storage describing additional information about the Index, that is specific to it. Unset if the Index does not have any additional information.
    /// </summary>
    public TerraformValue<string> MetadataSchemaUri
        => AsReference("metadata_schema_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
