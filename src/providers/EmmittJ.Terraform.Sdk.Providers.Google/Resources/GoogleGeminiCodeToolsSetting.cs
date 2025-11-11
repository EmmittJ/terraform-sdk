using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enabled_tool in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGeminiCodeToolsSettingEnabledToolBlock : TerraformBlockBase
{
    /// <summary>
    /// Link to the Dev Connect Account Connector that holds the user credentials.
    /// projects/{project}/locations/{location}/accountConnectors/{account_connector_id}
    /// </summary>
    [TerraformProperty("account_connector")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccountConnector { get; set; }

    /// <summary>
    /// Handle used to invoke the tool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handle is required")]
    [TerraformProperty("handle")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Handle { get; set; }

    /// <summary>
    /// Link to the Tool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tool is required")]
    [TerraformProperty("tool")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Tool { get; set; }

    /// <summary>
    /// Overridden URI, if allowed by Tool.
    /// </summary>
    [TerraformProperty("uri_override")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UriOverride { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGeminiCodeToolsSettingTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gemini_code_tools_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGeminiCodeToolsSetting : TerraformResource
{
    public GoogleGeminiCodeToolsSetting(string name) : base("google_gemini_code_tools_setting", name)
    {
    }

    /// <summary>
    /// Id of the Code Tools Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeToolsSettingId is required")]
    [TerraformProperty("code_tools_setting_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CodeToolsSettingId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for enabled_tool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledTool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnabledTool block(s) required")]
    [TerraformProperty("enabled_tool")]
    public TerraformList<TerraformBlock<GoogleGeminiCodeToolsSettingEnabledToolBlock>>? EnabledTool { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleGeminiCodeToolsSettingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Create time stamp.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/codeToolsSettings/{codeToolsSetting}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Update time stamp.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
