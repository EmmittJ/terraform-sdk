using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMonitoringGroupTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_monitoring_group resource.
/// </summary>
public partial class GoogleMonitoringGroup : TerraformResource
{
    public GoogleMonitoringGroup(string name) : base("google_monitoring_group", name)
    {
    }

    /// <summary>
    /// A user-assigned name for this group, used only for display
    /// purposes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The filter used to determine which monitored resources
    /// belong to this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If true, the members of this group are considered to be a
    /// cluster. The system can perform additional analysis on
    /// groups that are clusters.
    /// </summary>
    [TerraformProperty("is_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsCluster { get; set; }

    /// <summary>
    /// The name of the group&#39;s parent, if it has one. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;. For
    /// groups with no parent, parentName is the empty string, &amp;quot;&amp;quot;.
    /// </summary>
    [TerraformProperty("parent_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleMonitoringGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// A unique identifier for this group. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
