using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowed_data_access_labels in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock : TerraformBlock
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    public TerraformProperty<string>? AssetNamespace
    {
        set => SetProperty("asset_namespace", value);
    }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    public TerraformProperty<string>? DataAccessLabel
    {
        set => SetProperty("data_access_label", value);
    }

    /// <summary>
    /// Output only. The display name of the label.
    /// Data access label and log types&#39;s name
    /// will match the display name of the resource.
    /// The asset namespace will match the namespace itself.
    /// The ingestion key value pair will match the key of the tuple.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The name of the log type.
    /// </summary>
    public TerraformProperty<string>? LogType
    {
        set => SetProperty("log_type", value);
    }

}

/// <summary>
/// Block type for denied_data_access_labels in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock : TerraformBlock
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    public TerraformProperty<string>? AssetNamespace
    {
        set => SetProperty("asset_namespace", value);
    }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    public TerraformProperty<string>? DataAccessLabel
    {
        set => SetProperty("data_access_label", value);
    }

    /// <summary>
    /// Output only. The display name of the label.
    /// Data access label and log types&#39;s name
    /// will match the display name of the resource.
    /// The asset namespace will match the namespace itself.
    /// The ingestion key value pair will match the key of the tuple.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The name of the log type.
    /// </summary>
    public TerraformProperty<string>? LogType
    {
        set => SetProperty("log_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleDataAccessScopeTimeoutsBlock : TerraformBlock
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
        SetOutput("author");
        SetOutput("create_time");
        SetOutput("display_name");
        SetOutput("last_editor");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("allow_all");
        SetOutput("data_access_scope_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("location");
        SetOutput("project");
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
    public TerraformProperty<bool> AllowAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_all");
        set => SetProperty("allow_all", value);
    }

    /// <summary>
    /// Required. The user provided scope id which will become the last part of the name
    /// of the scope resource.
    /// Needs to be compliant with https://google.aip.dev/122
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessScopeId is required")]
    public required TerraformProperty<string> DataAccessScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_access_scope_id");
        set => SetProperty("data_access_scope_id", value);
    }

    /// <summary>
    /// Optional. A description of the data access scope for a human reader.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    /// Block for allowed_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock>? AllowedDataAccessLabels
    {
        set => SetProperty("allowed_data_access_labels", value);
    }

    /// <summary>
    /// Block for denied_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock>? DeniedDataAccessLabels
    {
        set => SetProperty("denied_data_access_labels", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleDataAccessScopeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
