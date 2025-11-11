using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowed_data_access_labels in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    [TerraformPropertyName("asset_namespace")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssetNamespace { get; set; }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    [TerraformPropertyName("data_access_label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataAccessLabel { get; set; }


    /// <summary>
    /// The name of the log type.
    /// </summary>
    [TerraformPropertyName("log_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogType { get; set; }

}

/// <summary>
/// Block type for denied_data_access_labels in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock
{
    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    [TerraformPropertyName("asset_namespace")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AssetNamespace { get; set; }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    [TerraformPropertyName("data_access_label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataAccessLabel { get; set; }


    /// <summary>
    /// The name of the log type.
    /// </summary>
    [TerraformPropertyName("log_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleDataAccessScopeTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_chronicle_data_access_scope resource.
/// </summary>
public class GoogleChronicleDataAccessScope : TerraformResource
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
    [TerraformPropertyName("allow_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAll { get; set; }

    /// <summary>
    /// Required. The user provided scope id which will become the last part of the name
    /// of the scope resource.
    /// Needs to be compliant with https://google.aip.dev/122
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessScopeId is required")]
    [TerraformPropertyName("data_access_scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataAccessScopeId { get; set; }

    /// <summary>
    /// Optional. A description of the data access scope for a human reader.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for allowed_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("allowed_data_access_labels")]
    public TerraformList<TerraformBlock<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock>>? AllowedDataAccessLabels { get; set; }

    /// <summary>
    /// Block for denied_data_access_labels.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("denied_data_access_labels")]
    public TerraformList<TerraformBlock<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock>>? DeniedDataAccessLabels { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleChronicleDataAccessScopeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The user who created the data access scope.
    /// </summary>
    [TerraformPropertyName("author")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Author => new TerraformReference(this, "author");

    /// <summary>
    /// Output only. The time at which the data access scope was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Output only. The name to be used for display to customers of the data access scope.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// Output only. The user who last updated the data access scope.
    /// </summary>
    [TerraformPropertyName("last_editor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastEditor => new TerraformReference(this, "last_editor");

    /// <summary>
    /// The unique full name of the data access scope. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope_id}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. The time at which the data access scope was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
