using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleVertexAiIndexEndpoint.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for private_service_connect_config in GoogleVertexAiIndexEndpoint.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connect_config";

    /// <summary>
    /// If set to true, the IndexEndpoint is created without private service access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnablePrivateServiceConnect is required")]
    public required TerraformValue<bool> EnablePrivateServiceConnect
    {
        get => GetArgument<TerraformValue<bool>>("enable_private_service_connect");
        set => SetArgument("enable_private_service_connect", value);
    }

    /// <summary>
    /// A list of Projects from which the forwarding rule will target the service attachment.
    /// </summary>
    public TerraformList<string>? ProjectAllowlist
    {
        get => GetArgument<TerraformList<string>>("project_allowlist");
        set => SetArgument("project_allowlist", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiIndexEndpoint.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiIndexEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a google_vertex_ai_index_endpoint Terraform resource.
/// Manages a google_vertex_ai_index_endpoint resource.
/// </summary>
public partial class GoogleVertexAiIndexEndpoint(string name) : TerraformResource("google_vertex_ai_index_endpoint", name)
{
    /// <summary>
    /// The description of the Index.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
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
    /// The labels with user-defined metadata to organize your Indexes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The full name of the Google Compute Engine [network](https://cloud.google.com//compute/docs/networks-and-firewalls#networks) to which the index endpoint should be peered.
    /// Private services access must already be configured for the network. If left unspecified, the index endpoint is not peered with any network.
    /// [Format](https://cloud.google.com/compute/docs/reference/rest/v1/networks/insert): &#39;projects/{project}/global/networks/{network}&#39;.
    /// Where &#39;{project}&#39; is a project number, as in &#39;12345&#39;, and &#39;{network}&#39; is network name.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
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
    /// If true, the deployed index will be accessible through public endpoint.
    /// </summary>
    public TerraformValue<bool>? PublicEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_endpoint_enabled");
        set => SetArgument("public_endpoint_enabled", value);
    }

    /// <summary>
    /// The region of the index endpoint. eg us-central1
    /// </summary>
    public TerraformValue<string>? Region
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The resource name of the Index.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// If publicEndpointEnabled is true, this field will be populated with the domain name to use for this index endpoint.
    /// </summary>
    public TerraformValue<string> PublicEndpointDomainName
        => AsReference("public_endpoint_domain_name");

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

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// PrivateServiceConnectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnectConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock>? PrivateServiceConnectConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiIndexEndpointPrivateServiceConnectConfigBlock>>("private_service_connect_config");
        set => SetArgument("private_service_connect_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiIndexEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiIndexEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
