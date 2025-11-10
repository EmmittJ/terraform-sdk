using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backend_metastores in .
/// Nesting mode: set
/// </summary>
public class GoogleDataprocMetastoreFederationBackendMetastoresBlock : TerraformBlock
{
    /// <summary>
    /// The type of the backend metastore. Possible values: [&amp;quot;METASTORE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;DATAPROC_METASTORE&amp;quot;, &amp;quot;BIGQUERY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetastoreType is required")]
    public required TerraformProperty<string> MetastoreType
    {
        set => SetProperty("metastore_type", value);
    }

    /// <summary>
    /// The relative resource name of the metastore that is being federated. The formats of the relative resource names for the currently supported metastores are listed below: Dataplex: projects/{projectId}/locations/{location}/lakes/{lake_id} BigQuery: projects/{projectId} Dataproc Metastore: projects/{projectId}/locations/{location}/services/{serviceId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The rank attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rank is required")]
    public required TerraformProperty<string> Rank
    {
        set => SetProperty("rank", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocMetastoreFederationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataproc_metastore_federation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocMetastoreFederation : TerraformResource
{
    public GoogleDataprocMetastoreFederation(string name) : base("google_dataproc_metastore_federation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("endpoint_uri");
        SetOutput("name");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("deletion_protection");
        SetOutput("federation_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
        SetOutput("tags");
        SetOutput("version");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the federation. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the federation will fail.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The ID of the metastore federation. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FederationId is required")]
    public required TerraformProperty<string> FederationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("federation_id");
        set => SetProperty("federation_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// User-defined labels for the metastore federation.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location where the metastore federation should reside.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The Apache Hive metastore version of the federation. All backend metastore versions must be compatible with the federation version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for backend_metastores.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendMetastores is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendMetastores block(s) required")]
    public HashSet<GoogleDataprocMetastoreFederationBackendMetastoresBlock>? BackendMetastores
    {
        set => SetProperty("backend_metastores", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocMetastoreFederationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time when the metastore federation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The URI of the endpoint used to access the metastore federation.
    /// </summary>
    public TerraformExpression EndpointUri => this["endpoint_uri"];

    /// <summary>
    /// The relative resource name of the metastore federation.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the metastore federation.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Additional information about the current state of the metastore federation, if available.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The globally unique resource identifier of the metastore federation.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the metastore federation was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
