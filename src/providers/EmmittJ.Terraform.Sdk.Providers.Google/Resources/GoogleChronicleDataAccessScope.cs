using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowed_data_access_labels in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock() : TerraformBlock("allowed_data_access_labels")
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    [TerraformProperty("asset_namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssetNamespace { get; set; }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    [TerraformProperty("data_access_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataAccessLabel { get; set; }


    /// <summary>
    /// The name of the log type.
    /// </summary>
    [TerraformProperty("log_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogType { get; set; }

}

/// <summary>
/// Block type for denied_data_access_labels in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock() : TerraformBlock("denied_data_access_labels")
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    [TerraformProperty("asset_namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssetNamespace { get; set; }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    [TerraformProperty("data_access_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataAccessLabel { get; set; }


    /// <summary>
    /// The name of the log type.
    /// </summary>
    [TerraformProperty("log_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleDataAccessScopeTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_chronicle_data_access_scope resource.
/// </summary>
public partial class GoogleChronicleDataAccessScope : TerraformResource
{
    public GoogleChronicleDataAccessScope(string name) : base("google_chronicle_data_access_scope", name)
    {
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
    [TerraformProperty("allow_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAll { get; set; }

    /// <summary>
    /// Required. The user provided scope id which will become the last part of the name
    /// of the scope resource.
    /// Needs to be compliant with https://google.aip.dev/122
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessScopeId is required")]
    [TerraformProperty("data_access_scope_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataAccessScopeId { get; set; }

    /// <summary>
    /// Optional. A description of the data access scope for a human reader.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for allowed_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("allowed_data_access_labels")]
    public TerraformList<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock> AllowedDataAccessLabels { get; set; } = new();

    /// <summary>
    /// Block for denied_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("denied_data_access_labels")]
    public TerraformList<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock> DeniedDataAccessLabels { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleChronicleDataAccessScopeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The user who created the data access scope.
    /// </summary>
    [TerraformProperty("author")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Author { get; }

    /// <summary>
    /// Output only. The time at which the data access scope was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The name to be used for display to customers of the data access scope.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. The user who last updated the data access scope.
    /// </summary>
    [TerraformProperty("last_editor")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastEditor { get; }

    /// <summary>
    /// The unique full name of the data access scope. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope_id}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The time at which the data access scope was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
