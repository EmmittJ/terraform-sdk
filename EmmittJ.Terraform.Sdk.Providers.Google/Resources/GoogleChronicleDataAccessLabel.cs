using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_chronicle_data_access_label resource.
/// </summary>
public class GoogleChronicleDataAccessLabel : TerraformResource
{
    public GoogleChronicleDataAccessLabel(string name) : base("google_chronicle_data_access_label", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("author");
        this.DeclareOutput("create_time");
        this.DeclareOutput("display_name");
        this.DeclareOutput("last_editor");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Required. The ID to use for the data access label, which will become the label&#39;s
    /// display name and the final component of the label&#39;s resource name. The
    /// maximum number of characters should be 63. Regex pattern is as per AIP:
    /// https://google.aip.dev/122#resource-id-segments
    /// </summary>
    public string? DataAccessLabelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_access_label_id")?.Value;
        set => this.WithProperty("data_access_label_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. A description of the data access label for a human reader.
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
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
    /// A UDM query over event data.
    /// </summary>
    public string? UdmQuery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("udm_query")?.Value;
        set => this.WithProperty("udm_query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. The user who created the data access label.
    /// </summary>
    public TerraformExpression Author => this["author"];

    /// <summary>
    /// Output only. The time at which the data access label was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The short name displayed for the label as it appears on event data. This is same as data access label id.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. The user who last updated the data access label.
    /// </summary>
    public TerraformExpression LastEditor => this["last_editor"];

    /// <summary>
    /// The unique resource name of the data access label. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The time at which the data access label was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
