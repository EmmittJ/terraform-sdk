using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enabled_tool in .
/// Nesting mode: list
/// </summary>
public class GoogleGeminiCodeToolsSettingEnabledToolBlock
{
    /// <summary>
    /// Link to the Dev Connect Account Connector that holds the user credentials.
    /// projects/{project}/locations/{location}/accountConnectors/{account_connector_id}
    /// </summary>
    [TerraformPropertyName("account_connector")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountConnector { get; set; }

    /// <summary>
    /// Handle used to invoke the tool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handle is required")]
    [TerraformPropertyName("handle")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Handle { get; set; }

    /// <summary>
    /// Link to the Tool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tool is required")]
    [TerraformPropertyName("tool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tool { get; set; }

    /// <summary>
    /// Overridden URI, if allowed by Tool.
    /// </summary>
    [TerraformPropertyName("uri_override")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UriOverride { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiCodeToolsSettingTimeoutsBlock
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
/// Manages a google_gemini_code_tools_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGeminiCodeToolsSetting : TerraformResource
{
    public GoogleGeminiCodeToolsSetting(string name) : base("google_gemini_code_tools_setting", name)
    {
    }

    /// <summary>
    /// Id of the Code Tools Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeToolsSettingId is required")]
    [TerraformPropertyName("code_tools_setting_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CodeToolsSettingId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for enabled_tool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledTool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnabledTool block(s) required")]
    [TerraformPropertyName("enabled_tool")]
    public TerraformList<TerraformBlock<GoogleGeminiCodeToolsSettingEnabledToolBlock>>? EnabledTool { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGeminiCodeToolsSettingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Create time stamp.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/codeToolsSettings/{codeToolsSetting}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Update time stamp.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
