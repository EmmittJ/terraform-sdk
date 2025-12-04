using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleGeminiGeminiGcpEnablementSetting.
/// Nesting mode: single
/// </summary>
public class GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_gemini_gemini_gcp_enablement_setting Terraform resource.
/// Manages a google_gemini_gemini_gcp_enablement_setting resource.
/// </summary>
public partial class GoogleGeminiGeminiGcpEnablementSetting(string name) : TerraformResource("google_gemini_gemini_gcp_enablement_setting", name)
{
    /// <summary>
    /// Whether web grounding should be disabled.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? DisableWebGrounding
    {
        get => GetArgument<TerraformValue<bool>>("disable_web_grounding");
        set => SetArgument("disable_web_grounding", value);
    }

    /// <summary>
    /// Whether customer data sharing should be enabled.
    /// </summary>
    public TerraformValue<bool>? EnableCustomerDataSharing
    {
        get => GetArgument<TerraformValue<bool>>("enable_customer_data_sharing");
        set => SetArgument("enable_customer_data_sharing", value);
    }

    /// <summary>
    /// Id of the Gemini Gcp Enablement setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeminiGcpEnablementSettingId is required")]
    public required TerraformValue<string> GeminiGcpEnablementSettingId
    {
        get => GetArgument<TerraformValue<string>>("gemini_gcp_enablement_setting_id");
        set => SetArgument("gemini_gcp_enablement_setting_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Web grounding type.
    /// Possible values:
    /// GROUNDING_WITH_GOOGLE_SEARCH
    /// WEB_GROUNDING_FOR_ENTERPRISE
    /// </summary>
    public TerraformValue<string>? WebGroundingType
    {
        get => GetArgument<TerraformValue<string>>("web_grounding_type");
        set => SetArgument("web_grounding_type", value);
    }

    /// <summary>
    /// Create time stamp.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/geminiGcpEnablementSettings/{geminiGcpEnablementSetting}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Update time stamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
