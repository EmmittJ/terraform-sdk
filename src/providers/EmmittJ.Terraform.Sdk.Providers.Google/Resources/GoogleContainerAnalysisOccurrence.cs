using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisOccurrenceAttestationBlock : TerraformBlock
{
    /// <summary>
    /// The serialized payload that is verified by one or
    /// more signatures. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SerializedPayload is required")]
    public required TerraformProperty<string> SerializedPayload
    {
        set => SetProperty("serialized_payload", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAnalysisOccurrenceTimeoutsBlock : TerraformBlock
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
/// Manages a google_container_analysis_occurrence resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAnalysisOccurrence : TerraformResource
{
    public GoogleContainerAnalysisOccurrence(string name) : base("google_container_analysis_occurrence", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("kind");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("note_name");
        SetOutput("project");
        SetOutput("remediation");
        SetOutput("resource_uri");
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
    /// The analysis note associated with this occurrence, in the form of
    /// projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a
    /// filter in list requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoteName is required")]
    public required TerraformProperty<string> NoteName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("note_name");
        set => SetProperty("note_name", value);
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
    /// A description of actions that can be taken to remedy the note.
    /// </summary>
    public TerraformProperty<string> Remediation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remediation");
        set => SetProperty("remediation", value);
    }

    /// <summary>
    /// Required. Immutable. A URI that represents the resource for which
    /// the occurrence applies. For example,
    /// https://gcr.io/project/image@sha256:123abc for a Docker image.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceUri is required")]
    public required TerraformProperty<string> ResourceUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_uri");
        set => SetProperty("resource_uri", value);
    }

    /// <summary>
    /// Block for attestation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attestation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Attestation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attestation block(s) allowed")]
    public List<GoogleContainerAnalysisOccurrenceAttestationBlock>? Attestation
    {
        set => SetProperty("attestation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAnalysisOccurrenceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The note kind which explicitly denotes which of the occurrence
    /// details are specified. This field can be used as a filter in list
    /// requests.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The name of the occurrence.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
