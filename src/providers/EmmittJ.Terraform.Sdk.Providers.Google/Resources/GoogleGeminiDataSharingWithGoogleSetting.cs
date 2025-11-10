using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiDataSharingWithGoogleSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_gemini_data_sharing_with_google_setting resource.
/// </summary>
public class GoogleGeminiDataSharingWithGoogleSetting : TerraformResource
{
    public GoogleGeminiDataSharingWithGoogleSetting(string name) : base("google_gemini_data_sharing_with_google_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("data_sharing_with_google_setting_id");
        SetOutput("enable_data_sharing");
        SetOutput("enable_preview_data_sharing");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Id of the Data Sharing With Google Setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSharingWithGoogleSettingId is required")]
    public required TerraformProperty<string> DataSharingWithGoogleSettingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_sharing_with_google_setting_id");
        set => SetProperty("data_sharing_with_google_setting_id", value);
    }

    /// <summary>
    /// Whether data sharing should be enabled in GA products.
    /// </summary>
    public TerraformProperty<bool> EnableDataSharing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_data_sharing");
        set => SetProperty("enable_data_sharing", value);
    }

    /// <summary>
    /// Whether data sharing should be enabled in Preview products.
    /// </summary>
    public TerraformProperty<bool> EnablePreviewDataSharing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_preview_data_sharing");
        set => SetProperty("enable_preview_data_sharing", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGeminiDataSharingWithGoogleSettingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// Format:projects/{project}/locations/{location}/dataSharingWithGoogleSettings/{dataSharingWithGoogleSetting}
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
