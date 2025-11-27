using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleGeminiReleaseChannelSettingBinding.
/// Nesting mode: single
/// </summary>
public class GoogleGeminiReleaseChannelSettingBindingTimeoutsBlock : TerraformBlock
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
/// Represents a google_gemini_release_channel_setting_binding Terraform resource.
/// Manages a google_gemini_release_channel_setting_binding resource.
/// </summary>
public partial class GoogleGeminiReleaseChannelSettingBinding(string name) : TerraformResource("google_gemini_release_channel_setting_binding", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Product type of the setting binding. Possible values: [&amp;quot;GEMINI_CLOUD_ASSIST&amp;quot;, &amp;quot;GEMINI_CODE_ASSIST&amp;quot;]
    /// </summary>
    public TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseChannelSettingId is required")]
    public required TerraformValue<string> ReleaseChannelSettingId
    {
        get => new TerraformReference<string>(this, "release_channel_setting_id");
        set => SetArgument("release_channel_setting_id", value);
    }

    /// <summary>
    /// Id of the setting binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SettingBindingId is required")]
    public required TerraformValue<string> SettingBindingId
    {
        get => new TerraformReference<string>(this, "setting_binding_id");
        set => SetArgument("setting_binding_id", value);
    }

    /// <summary>
    /// Target of the binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => new TerraformReference<string>(this, "target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Create time stamp.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/releaseChannelSettings/{setting}/settingBindings/{setting_binding}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Update time stamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGeminiReleaseChannelSettingBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGeminiReleaseChannelSettingBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
