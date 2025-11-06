using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_chronicle_data_access_scope resource.
/// </summary>
public class GoogleChronicleDataAccessScope : TerraformResource
{
    public GoogleChronicleDataAccessScope(string name) : base("google_chronicle_data_access_scope", name)
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
    /// Optional. Whether or not the scope allows all labels, allow_all and
    /// allowed_data_access_labels are mutually exclusive and one of them must be
    /// present. denied_data_access_labels can still be used along with allow_all.
    /// When combined with denied_data_access_labels, access will be granted to all
    /// data that doesn&#39;t have labels mentioned in denied_data_access_labels. E.g.:
    /// A customer with scope with denied labels A and B and allow_all will be able
    /// to see all data except data labeled with A and data labeled with B and data
    /// with labels A and B.
    /// </summary>
    public bool? AllowAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_all")?.Value;
        set => this.WithProperty("allow_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Required. The user provided scope id which will become the last part of the name
    /// of the scope resource.
    /// Needs to be compliant with https://google.aip.dev/122
    /// </summary>
    public string? DataAccessScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_access_scope_id")?.Value;
        set => this.WithProperty("data_access_scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. A description of the data access scope for a human reader.
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
    /// Output only. The user who created the data access scope.
    /// </summary>
    public TerraformExpression Author => this["author"];

    /// <summary>
    /// Output only. The time at which the data access scope was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The name to be used for display to customers of the data access scope.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. The user who last updated the data access scope.
    /// </summary>
    public TerraformExpression LastEditor => this["last_editor"];

    /// <summary>
    /// The unique full name of the data access scope. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The time at which the data access scope was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
