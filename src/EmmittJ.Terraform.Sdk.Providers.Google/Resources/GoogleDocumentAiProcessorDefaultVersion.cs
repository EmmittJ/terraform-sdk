using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_document_ai_processor_default_version resource.
/// </summary>
public class GoogleDocumentAiProcessorDefaultVersion : TerraformResource
{
    public GoogleDocumentAiProcessorDefaultVersion(string name) : base("google_document_ai_processor_default_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The processor to set the version on.
    /// </summary>
    public TerraformProperty<string>? Processor
    {
        get => GetProperty<TerraformProperty<string>>("processor");
        set => this.WithProperty("processor", value);
    }

    /// <summary>
    /// The version to set. Using &#39;stable&#39; or &#39;rc&#39; will cause the API to return the latest version in that release channel.
    /// Apply &#39;lifecycle.ignore_changes&#39; to the &#39;version&#39; field to suppress this diff.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

}
