using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backend_metastores in .
/// Nesting mode: set
/// </summary>
public partial class GoogleDataprocMetastoreFederationBackendMetastoresBlock() : TerraformBlock("backend_metastores")
{
    /// <summary>
    /// The type of the backend metastore. Possible values: [&amp;quot;METASTORE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;DATAPROC_METASTORE&amp;quot;, &amp;quot;BIGQUERY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetastoreType is required")]
    [TerraformProperty("metastore_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetastoreType { get; set; }

    /// <summary>
    /// The relative resource name of the metastore that is being federated. The formats of the relative resource names for the currently supported metastores are listed below: Dataplex: projects/{projectId}/locations/{location}/lakes/{lake_id} BigQuery: projects/{projectId} Dataproc Metastore: projects/{projectId}/locations/{location}/services/{serviceId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The rank attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rank is required")]
    [TerraformProperty("rank")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Rank { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocMetastoreFederationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_metastore_federation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocMetastoreFederation : TerraformResource
{
    public GoogleDataprocMetastoreFederation(string name) : base("google_dataproc_metastore_federation", name)
    {
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the federation. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the federation will fail.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The ID of the metastore federation. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FederationId is required")]
    [TerraformProperty("federation_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FederationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the metastore federation.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the metastore federation should reside.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The Apache Hive metastore version of the federation. All backend metastore versions must be compatible with the federation version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for backend_metastores.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendMetastores is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendMetastores block(s) required")]
    [TerraformProperty("backend_metastores")]
    public required TerraformSet<GoogleDataprocMetastoreFederationBackendMetastoresBlock> BackendMetastores { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataprocMetastoreFederationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time when the metastore federation was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The URI of the endpoint used to access the metastore federation.
    /// </summary>
    [TerraformProperty("endpoint_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointUri { get; }

    /// <summary>
    /// The relative resource name of the metastore federation.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the metastore federation.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Additional information about the current state of the metastore federation, if available.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The globally unique resource identifier of the metastore federation.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The time when the metastore federation was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
