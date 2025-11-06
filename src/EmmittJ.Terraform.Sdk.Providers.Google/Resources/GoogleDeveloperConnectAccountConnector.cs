using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_developer_connect_account_connector resource.
/// </summary>
public class GoogleDeveloperConnectAccountConnector : TerraformResource
{
    public GoogleDeveloperConnectAccountConnector(string name) : base("google_developer_connect_account_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("oauth_start_uri");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Required. The ID to use for the AccountConnector, which will become the final
    /// component of the AccountConnector&#39;s resource name. Its format should adhere
    /// to https://google.aip.dev/122#resource-id-segments Names must be unique
    /// per-project per-location.
    /// </summary>
    public string? AccountConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_connector_id")?.Value;
        set => this.WithProperty("account_connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Allows users to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// Optional. Labels as key value pairs
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
    /// The location of the resource.
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
    /// Output only. The timestamp when the userConnection was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. The resource name of the userConnection, in the format
    /// &#39;projects/{project}/locations/{location}/accountConnectors/{account_connector_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Start OAuth flow by clicking on this URL.
    /// </summary>
    public TerraformExpression OauthStartUri => this["oauth_start_uri"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The timestamp when the userConnection was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
