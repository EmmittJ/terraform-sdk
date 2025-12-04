using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enabled_tool in GoogleGeminiCodeToolsSetting.
/// Nesting mode: list
/// </summary>
public class GoogleGeminiCodeToolsSettingEnabledToolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_tool";

    /// <summary>
    /// Link to the Dev Connect Account Connector that holds the user credentials.
    /// projects/{project}/locations/{location}/accountConnectors/{account_connector_id}
    /// </summary>
    public TerraformValue<string>? AccountConnector
    {
        get => GetArgument<TerraformValue<string>>("account_connector");
        set => SetArgument("account_connector", value);
    }

    /// <summary>
    /// Handle used to invoke the tool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handle is required")]
    public required TerraformValue<string> Handle
    {
        get => GetRequiredArgument<TerraformValue<string>>("handle");
        set => SetArgument("handle", value);
    }

    /// <summary>
    /// Link to the Tool
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tool is required")]
    public required TerraformValue<string> Tool
    {
        get => GetRequiredArgument<TerraformValue<string>>("tool");
        set => SetArgument("tool", value);
    }

    /// <summary>
    /// Overridden URI, if allowed by Tool.
    /// </summary>
    public TerraformValue<string>? UriOverride
    {
        get => GetArgument<TerraformValue<string>>("uri_override");
        set => SetArgument("uri_override", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGeminiCodeToolsSettingEnabledToolBlockConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleGeminiCodeToolsSettingEnabledToolBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}

/// <summary>
/// Block type for config in GoogleGeminiCodeToolsSettingEnabledToolBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGeminiCodeToolsSettingEnabledToolBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Key of the configuration item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Value of the configuration item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGeminiCodeToolsSetting.
/// Nesting mode: single
/// </summary>
public class GoogleGeminiCodeToolsSettingTimeoutsBlock : TerraformBlock
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
/// Represents a google_gemini_code_tools_setting Terraform resource.
/// Manages a google_gemini_code_tools_setting resource.
/// </summary>
public partial class GoogleGeminiCodeToolsSetting(string name) : TerraformResource("google_gemini_code_tools_setting", name)
{
    /// <summary>
    /// Id of the Code Tools Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeToolsSettingId is required")]
    public required TerraformValue<string> CodeToolsSettingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("code_tools_setting_id");
        set => SetArgument("code_tools_setting_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
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
    /// Format:projects/{project}/locations/{location}/codeToolsSettings/{codeToolsSetting}
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
    /// EnabledTool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledTool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnabledTool block(s) required")]
    public required TerraformList<GoogleGeminiCodeToolsSettingEnabledToolBlock> EnabledTool
    {
        get => GetRequiredArgument<TerraformList<GoogleGeminiCodeToolsSettingEnabledToolBlock>>("enabled_tool");
        set => SetArgument("enabled_tool", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGeminiCodeToolsSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGeminiCodeToolsSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
