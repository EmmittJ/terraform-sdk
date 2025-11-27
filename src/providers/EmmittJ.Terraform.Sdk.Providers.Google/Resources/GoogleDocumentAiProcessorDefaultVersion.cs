using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDocumentAiProcessorDefaultVersion.
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_document_ai_processor_default_version Terraform resource.
/// Manages a google_document_ai_processor_default_version resource.
/// </summary>
public partial class GoogleDocumentAiProcessorDefaultVersion(string name) : TerraformResource("google_document_ai_processor_default_version", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The processor to set the version on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Processor is required")]
    public required TerraformValue<string> Processor
    {
        get => new TerraformReference<string>(this, "processor");
        set => SetArgument("processor", value);
    }

    /// <summary>
    /// The version to set. Using &#39;stable&#39; or &#39;rc&#39; will cause the API to return the latest version in that release channel.
    /// Apply &#39;lifecycle.ignore_changes&#39; to the &#39;version&#39; field to suppress this diff.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
