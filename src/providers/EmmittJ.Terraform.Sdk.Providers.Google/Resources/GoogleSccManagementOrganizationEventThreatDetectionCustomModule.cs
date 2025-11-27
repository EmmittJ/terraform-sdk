using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSccManagementOrganizationEventThreatDetectionCustomModule.
/// Nesting mode: single
/// </summary>
public class GoogleSccManagementOrganizationEventThreatDetectionCustomModuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_scc_management_organization_event_threat_detection_custom_module Terraform resource.
/// Manages a google_scc_management_organization_event_threat_detection_custom_module resource.
/// </summary>
public partial class GoogleSccManagementOrganizationEventThreatDetectionCustomModule(string name) : TerraformResource("google_scc_management_organization_event_threat_detection_custom_module", name)
{
    /// <summary>
    /// Config for the module. For the resident module, its config value is defined at this level.
    /// For the inherited module, its config value is inherited from the ancestor module.
    /// </summary>
    public TerraformValue<string>? Config
    {
        get => new TerraformReference<string>(this, "config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// The human readable name to be displayed for the module.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The state of enablement for the module at the given level of the hierarchy. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EnablementState
    {
        get => new TerraformReference<string>(this, "enablement_state");
        set => SetArgument("enablement_state", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Location ID of the parent organization. Only global is supported at the moment.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Numerical ID of the parent organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// Immutable. Type for the module. e.g. CONFIGURABLE_BAD_IP.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The editor that last updated the custom module
    /// </summary>
    public TerraformValue<string> LastEditor
    {
        get => new TerraformReference<string>(this, "last_editor");
    }

    /// <summary>
    /// The resource name of the Event Threat Detection custom module.
    /// Its format is &amp;quot;organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{eventThreatDetectionCustomModule}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The time at which the custom module was last updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSccManagementOrganizationEventThreatDetectionCustomModuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSccManagementOrganizationEventThreatDetectionCustomModuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
