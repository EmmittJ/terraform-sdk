using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enabled_tool in .
/// Nesting mode: list
/// </summary>
public class GoogleGeminiCodeToolsSettingEnabledToolBlock : TerraformBlock
{
    /// <summary>
    /// Link to the Dev Connect Account Connector that holds the user credentials.
    /// projects/{project}/locations/{location}/accountConnectors/{account_connector_id}
    /// </summary>
    public TerraformProperty<string>? AccountConnector
    {
        get => GetProperty<TerraformProperty<string>>("account_connector");
        set => WithProperty("account_connector", value);
    }

    /// <summary>
    /// Handle used to invoke the tool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handle is required")]
    public required TerraformProperty<string> Handle
    {
        get => GetRequiredProperty<TerraformProperty<string>>("handle");
        set => WithProperty("handle", value);
    }

    /// <summary>
    /// Link to the Tool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tool is required")]
    public required TerraformProperty<string> Tool
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tool");
        set => WithProperty("tool", value);
    }

    /// <summary>
    /// Overridden URI, if allowed by Tool.
    /// </summary>
    public TerraformProperty<string>? UriOverride
    {
        get => GetProperty<TerraformProperty<string>>("uri_override");
        set => WithProperty("uri_override", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiCodeToolsSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_gemini_code_tools_setting resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGeminiCodeToolsSetting : TerraformResource
{
    public GoogleGeminiCodeToolsSetting(string name) : base("google_gemini_code_tools_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("name");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Id of the Code Tools Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeToolsSettingId is required")]
    public required TerraformProperty<string> CodeToolsSettingId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("code_tools_setting_id");
        set => this.WithProperty("code_tools_setting_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for enabled_tool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnabledTool block(s) required")]
    public List<GoogleGeminiCodeToolsSettingEnabledToolBlock>? EnabledTool
    {
        get => GetProperty<List<GoogleGeminiCodeToolsSettingEnabledToolBlock>>("enabled_tool");
        set => this.WithProperty("enabled_tool", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGeminiCodeToolsSettingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGeminiCodeToolsSettingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Create time stamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/codeToolsSettings/{codeToolsSetting}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Update time stamp.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
