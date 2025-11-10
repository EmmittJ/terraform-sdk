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
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Whether web grounding should be disabled.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? DisableWebGrounding
    {
        get => GetProperty<TerraformProperty<bool>>("disable_web_grounding");
        set => this.WithProperty("disable_web_grounding", value);
    }

    /// <summary>
    /// Whether customer data sharing should be enabled.
    /// </summary>
    public TerraformProperty<bool>? EnableCustomerDataSharing
    {
        get => GetProperty<TerraformProperty<bool>>("enable_customer_data_sharing");
        set => this.WithProperty("enable_customer_data_sharing", value);
    }

    /// <summary>
    /// Id of the Gemini Gcp Enablement setting.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeminiGcpEnablementSettingId is required")]
    public required TerraformProperty<string> GeminiGcpEnablementSettingId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("gemini_gcp_enablement_setting_id");
        set => this.WithProperty("gemini_gcp_enablement_setting_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    /// Web grounding type.
    /// Possible values:
    /// GROUNDING_WITH_GOOGLE_SEARCH
    /// WEB_GROUNDING_FOR_ENTERPRISE
    /// </summary>
    public TerraformProperty<string>? WebGroundingType
    {
        get => GetProperty<TerraformProperty<string>>("web_grounding_type");
        set => this.WithProperty("web_grounding_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGeminiGeminiGcpEnablementSettingTimeoutsBlock>("timeouts");
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
