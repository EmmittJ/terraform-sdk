using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dialogflow_cx_generator resource.
/// </summary>
public class GoogleDialogflowCxGenerator : TerraformResource
{
    public GoogleDialogflowCxGenerator(string name) : base("google_dialogflow_cx_generator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The human-readable name of the generator, unique within the agent.
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
    /// The language to create generators for the following fields:
    /// * Generator.prompt_text.text
    /// If not specified, the agent&#39;s default language is used.
    /// </summary>
    public string? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code")?.Value;
        set => this.WithProperty("language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent to create a Generator for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique identifier of the Generator.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/generators/&amp;lt;Generator ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
