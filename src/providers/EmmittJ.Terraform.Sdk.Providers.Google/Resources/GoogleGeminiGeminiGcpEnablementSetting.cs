using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock : TerraformBlock
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
/// Manages a google_gemini_gemini_gcp_enablement_setting resource.
/// </summary>
public class GoogleGeminiGeminiGcpEnablementSetting : TerraformResource
{
    public GoogleGeminiGeminiGcpEnablementSetting(string name) : base("google_gemini_gemini_gcp_enablement_setting", name)
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
        SetOutput("disable_web_grounding");
        SetOutput("enable_customer_data_sharing");
        SetOutput("gemini_gcp_enablement_setting_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
        SetOutput("web_grounding_type");
    }

    /// <summary>
    /// Whether web grounding should be disabled.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> DisableWebGrounding
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_web_grounding");
        set => SetProperty("disable_web_grounding", value);
    }

    /// <summary>
    /// Whether customer data sharing should be enabled.
    /// </summary>
    public TerraformProperty<bool> EnableCustomerDataSharing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_customer_data_sharing");
        set => SetProperty("enable_customer_data_sharing", value);
    }

    /// <summary>
    /// Id of the Gemini Gcp Enablement setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeminiGcpEnablementSettingId is required")]
    public required TerraformProperty<string> GeminiGcpEnablementSettingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gemini_gcp_enablement_setting_id");
        set => SetProperty("gemini_gcp_enablement_setting_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    /// Web grounding type.
    /// Possible values:
    /// GROUNDING_WITH_GOOGLE_SEARCH
    /// WEB_GROUNDING_FOR_ENTERPRISE
    /// </summary>
    public TerraformProperty<string> WebGroundingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_grounding_type");
        set => SetProperty("web_grounding_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock? Timeouts
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
    /// Format:projects/{project}/locations/{location}/geminiGcpEnablementSettings/{geminiGcpEnablementSetting}
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
