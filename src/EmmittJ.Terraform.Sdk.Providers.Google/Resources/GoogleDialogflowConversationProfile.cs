using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_conversation_profile resource.
/// </summary>
public class GoogleDialogflowConversationProfile : TerraformResource
{
    public GoogleDialogflowConversationProfile(string name) : base("google_dialogflow_conversation_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Required. Human readable name for this profile. Max length 1024 bytes.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Language code for the conversation profile. This should be a BCP-47 language tag.
    /// </summary>
    public string? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code")?.Value;
        set => this.WithProperty("language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// desc
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the CX SecuritySettings reference for the agent.
    /// </summary>
    public string? SecuritySettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_settings")?.Value;
        set => this.WithProperty("security_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time zone of this conversational profile.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// name
    /// </summary>
    public TerraformExpression Name => this["name"];

}
