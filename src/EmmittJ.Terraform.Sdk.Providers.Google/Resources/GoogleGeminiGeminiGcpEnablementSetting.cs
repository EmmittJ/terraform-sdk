using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformLiteralProperty<bool>? DisableWebGrounding
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_web_grounding");
        set => this.WithProperty("disable_web_grounding", value);
    }

    /// <summary>
    /// Whether customer data sharing should be enabled.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableCustomerDataSharing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_customer_data_sharing");
        set => this.WithProperty("enable_customer_data_sharing", value);
    }

    /// <summary>
    /// Id of the Gemini Gcp Enablement setting.
    /// </summary>
    public TerraformLiteralProperty<string>? GeminiGcpEnablementSettingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gemini_gcp_enablement_setting_id");
        set => this.WithProperty("gemini_gcp_enablement_setting_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Web grounding type.
    /// Possible values:
    /// GROUNDING_WITH_GOOGLE_SEARCH
    /// WEB_GROUNDING_FOR_ENTERPRISE
    /// </summary>
    public TerraformLiteralProperty<string>? WebGroundingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_grounding_type");
        set => this.WithProperty("web_grounding_type", value);
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
