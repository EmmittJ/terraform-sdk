using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringGroupTimeoutsBlock
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
/// Manages a google_monitoring_group resource.
/// </summary>
public class GoogleMonitoringGroup : TerraformResource
{
    public GoogleMonitoringGroup(string name) : base("google_monitoring_group", name)
    {
    }

    /// <summary>
    /// A user-assigned name for this group, used only for display
    /// purposes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The filter used to determine which monitored resources
    /// belong to this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// If true, the members of this group are considered to be a
    /// cluster. The system can perform additional analysis on
    /// groups that are clusters.
    /// </summary>
    [TerraformPropertyName("is_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsCluster { get; set; }

    /// <summary>
    /// The name of the group&#39;s parent, if it has one. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;. For
    /// groups with no parent, parentName is the empty string, &amp;quot;&amp;quot;.
    /// </summary>
    [TerraformPropertyName("parent_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParentName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMonitoringGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A unique identifier for this group. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
