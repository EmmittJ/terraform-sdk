using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("id");
        SetOutput("processor");
        SetOutput("version");
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
    /// The processor to set the version on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Processor is required")]
    public required TerraformProperty<string> Processor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("processor");
        set => SetProperty("processor", value);
    }

    /// <summary>
    /// The version to set. Using &#39;stable&#39; or &#39;rc&#39; will cause the API to return the latest version in that release channel.
    /// Apply &#39;lifecycle.ignore_changes&#39; to the &#39;version&#39; field to suppress this diff.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
