using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubApiHubInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. The Customer Managed Encryption Key (CMEK) used for data encryption.
    /// The CMEK name should follow the format of
    /// &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;,
    /// where the location must match the instance location.
    /// If the CMEK is not provided, a GMEK will be created for the instance.
    /// </summary>
    public TerraformProperty<string>? CmekKeyName
    {
        get => GetProperty<TerraformProperty<string>>("cmek_key_name");
        set => WithProperty("cmek_key_name", value);
    }

    /// <summary>
    /// Optional. If true, the search will be disabled for the instance. The default value
    /// is false.
    /// </summary>
    public TerraformProperty<bool>? DisableSearch
    {
        get => GetProperty<TerraformProperty<bool>>("disable_search");
        set => WithProperty("disable_search", value);
    }

    /// <summary>
    /// Optional. Encryption type for the region. If the encryption type is CMEK, the
    /// cmek_key_name must be provided. If no encryption type is provided,
    /// GMEK will be used.
    /// Possible values:
    /// ENCRYPTION_TYPE_UNSPECIFIED
    /// GMEK
    /// CMEK
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => WithProperty("encryption_type", value);
    }

    /// <summary>
    /// Optional. The name of the Vertex AI location where the data store is stored.
    /// </summary>
    public TerraformProperty<string>? VertexLocation
    {
        get => GetProperty<TerraformProperty<string>>("vertex_location");
        set => WithProperty("vertex_location", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubApiHubInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_apihub_api_hub_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubApiHubInstance : TerraformResource
{
    public GoogleApihubApiHubInstance(string name) : base("google_apihub_api_hub_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("state_message");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Identifier to assign to the Api Hub instance. Must be unique within
    /// scope of the parent resource. If the field is not provided,
    /// system generated id will be used.
    /// 
    /// This value should be 4-40 characters, and valid characters
    /// are &#39;/a-z[0-9]-_/&#39;.
    /// </summary>
    public TerraformProperty<string>? ApiHubInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("api_hub_instance_id");
        set => this.WithProperty("api_hub_instance_id", value);
    }

    /// <summary>
    /// Optional. Description of the ApiHub instance.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Optional. Instance labels to represent user-provided metadata.
    /// Refer to cloud documentation on labels for more details.
    /// https://cloud.google.com/compute/docs/labeling-resources
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
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
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public List<GoogleApihubApiHubInstanceConfigBlock>? Config
    {
        get => GetProperty<List<GoogleApihubApiHubInstanceConfigBlock>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApihubApiHubInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApihubApiHubInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Creation timestamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. Format:
    /// &#39;projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The current state of the ApiHub instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// INACTIVE
    /// CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// FAILED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Extra information about ApiHub instance state. Currently the message
    /// would be populated when state is &#39;FAILED&#39;.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Last update timestamp.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
