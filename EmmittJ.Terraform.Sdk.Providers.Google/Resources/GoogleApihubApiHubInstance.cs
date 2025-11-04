using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apihub_api_hub_instance resource.
/// </summary>
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
    public string? ApiHubInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_hub_instance_id")?.Value;
        set => this.WithProperty("api_hub_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Description of the ApiHub instance.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Optional. Instance labels to represent user-provided metadata.
    /// Refer to cloud documentation on labels for more details.
    /// https://cloud.google.com/compute/docs/labeling-resources
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
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
