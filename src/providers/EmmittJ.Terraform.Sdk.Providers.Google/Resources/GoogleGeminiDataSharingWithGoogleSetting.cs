using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleGeminiDataSharingWithGoogleSetting.
/// Nesting mode: single
/// </summary>
public class GoogleGeminiDataSharingWithGoogleSettingTimeoutsBlock : TerraformBlock
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
/// Represents a google_gemini_data_sharing_with_google_setting Terraform resource.
/// Manages a google_gemini_data_sharing_with_google_setting resource.
/// </summary>
public partial class GoogleGeminiDataSharingWithGoogleSetting(string name) : TerraformResource("google_gemini_data_sharing_with_google_setting", name)
{
    /// <summary>
    /// Id of the Data Sharing With Google Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSharingWithGoogleSettingId is required")]
    public required TerraformValue<string> DataSharingWithGoogleSettingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_sharing_with_google_setting_id");
        set => SetArgument("data_sharing_with_google_setting_id", value);
    }

    /// <summary>
    /// Whether data sharing should be enabled in GA products.
    /// </summary>
    public TerraformValue<bool>? EnableDataSharing
    {
        get => GetArgument<TerraformValue<bool>>("enable_data_sharing");
        set => SetArgument("enable_data_sharing", value);
    }

    /// <summary>
    /// Whether data sharing should be enabled in Preview products.
    /// </summary>
    public TerraformValue<bool>? EnablePreviewDataSharing
    {
        get => GetArgument<TerraformValue<bool>>("enable_preview_data_sharing");
        set => SetArgument("enable_preview_data_sharing", value);
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
    /// Format:projects/{project}/locations/{location}/dataSharingWithGoogleSettings/{dataSharingWithGoogleSetting}
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
    public GoogleGeminiDataSharingWithGoogleSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGeminiDataSharingWithGoogleSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
