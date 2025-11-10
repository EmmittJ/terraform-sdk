using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enabled_tool in .
/// Nesting mode: list
/// </summary>
public class GoogleGeminiCodeToolsSettingEnabledToolBlock : ITerraformBlock
{
    /// <summary>
    /// Link to the Dev Connect Account Connector that holds the user credentials.
    /// projects/{project}/locations/{location}/accountConnectors/{account_connector_id}
    /// </summary>
    [TerraformPropertyName("account_connector")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountConnector { get; set; }

    /// <summary>
    /// Handle used to invoke the tool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handle is required")]
    [TerraformPropertyName("handle")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Handle { get; set; }

    /// <summary>
    /// Link to the Tool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tool is required")]
    [TerraformPropertyName("tool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Tool { get; set; }

    /// <summary>
    /// Overridden URI, if allowed by Tool.
    /// </summary>
    [TerraformPropertyName("uri_override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UriOverride { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiCodeToolsSettingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> CodeToolsSettingId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for enabled_tool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledTool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnabledTool block(s) required")]
    [TerraformPropertyName("enabled_tool")]
    public TerraformList<TerraformBlock<GoogleGeminiCodeToolsSettingEnabledToolBlock>>? EnabledTool { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGeminiCodeToolsSettingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time stamp.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/codeToolsSettings/{codeToolsSetting}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Update time stamp.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
