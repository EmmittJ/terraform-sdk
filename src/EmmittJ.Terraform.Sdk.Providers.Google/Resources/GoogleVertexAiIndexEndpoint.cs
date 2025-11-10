using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointEncryptionSpecBlock : TerraformBlock
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
/// Block type for private_service_connect_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, the IndexEndpoint is created without private service access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    public required TerraformProperty<bool> EnablePrivateServiceConnect
    {
        get => GetProperty<TerraformProperty<bool>>("enable_private_service_connect");
        set => WithProperty("enable_private_service_connect", value);
    }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    public List<TerraformProperty<string>>? ProjectAllowlist
    {
        get => GetProperty<List<TerraformProperty<string>>>("project_allowlist");
        set => WithProperty("project_allowlist", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a google_vertex_ai_index_endpoint resource.
/// </summary>
public class GoogleVertexAiIndexEndpoint : TerraformResource
{
    public GoogleVertexAiIndexEndpoint(string name) : base("google_vertex_ai_index_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("public_endpoint_domain_name");
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
    /// The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks) to which the index endpoint should be peered.
    /// Private services access must already be configured for the network. If left unspecified, the index endpoint is not peered with any network.
    /// [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/insert): &#39;projects/{project}/global/networks/{network}&#39;.
    /// Where &#39;{project}&#39; is a project number, as in &#39;12345&#39;, and &#39;{network}&#39; is network name.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
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
    /// If true, the deployed index will be accessible through public endpoint.
    /// </summary>
    public TerraformProperty<bool>? PublicEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_endpoint_enabled");
        set => this.WithProperty("public_endpoint_enabled", value);
    }

    /// <summary>
    /// The region of the index endpoint. eg us-central1
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
    public List<GoogleVertexAiIndexEndpointEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetProperty<List<GoogleVertexAiIndexEndpointEncryptionSpecBlock>>("encryption_spec");
        set => this.WithProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for private_service_connect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public List<GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetProperty<List<GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => this.WithProperty("private_service_connect_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiIndexEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleVertexAiIndexEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The resource name of the Index.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// If publicEndpointEnabled is true, this field will be populated with the domain name to use for this index endpoint.
    /// </summary>
    public TerraformExpression PublicEndpointDomainName => this["public_endpoint_domain_name"];

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
