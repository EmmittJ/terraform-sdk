using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gemini_logging_setting resource.
/// </summary>
public class GoogleGeminiLoggingSetting : TerraformResource
{
    public GoogleGeminiLoggingSetting(string name) : base("google_gemini_logging_setting", name)
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
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
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
    /// Whether to log metadata.
    /// </summary>
    public TerraformProperty<bool>? LogMetadata
    {
        get => GetProperty<TerraformProperty<bool>>("log_metadata");
        set => this.WithProperty("log_metadata", value);
    }

    /// <summary>
    /// Whether to log prompts and responses.
    /// </summary>
    public TerraformProperty<bool>? LogPromptsAndResponses
    {
        get => GetProperty<TerraformProperty<bool>>("log_prompts_and_responses");
        set => this.WithProperty("log_prompts_and_responses", value);
    }

    /// <summary>
    /// Id of the Logging Setting.
    /// </summary>
    public TerraformProperty<string>? LoggingSettingId
    {
        get => GetProperty<TerraformProperty<string>>("logging_setting_id");
        set => this.WithProperty("logging_setting_id", value);
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
    /// Create time stamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. Name of the resource.
    /// Format:projects/{project}/locations/{location}/loggingsettings/{loggingsetting}
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
