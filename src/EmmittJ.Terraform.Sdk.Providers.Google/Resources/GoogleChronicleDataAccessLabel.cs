using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleDataAccessLabelTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessLabelId is required")]
    public required TerraformProperty<string> DataAccessLabelId
    {
        get => GetProperty<TerraformProperty<string>>("data_access_label_id");
        set => this.WithProperty("data_access_label_id", value);
    }

    /// <summary>
    /// Optional. A description of the data access label for a human reader.
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
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
    /// A UDM query over event data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UdmQuery is required")]
    public required TerraformProperty<string> UdmQuery
    {
        get => GetProperty<TerraformProperty<string>>("udm_query");
        set => this.WithProperty("udm_query", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleDataAccessLabelTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleChronicleDataAccessLabelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
