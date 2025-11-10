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
        get => GetRequiredProperty<TerraformProperty<string>>("serialized_payload");
        set => WithProperty("serialized_payload", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("kind");
        this.DeclareOutput("name");
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
    /// The analysis note associated with this occurrence, in the form of
    /// projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a
    /// filter in list requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoteName is required")]
    public required TerraformProperty<string> NoteName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("note_name");
        set => this.WithProperty("note_name", value);
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
    /// A description of actions that can be taken to remedy the note.
    /// </summary>
    public TerraformProperty<string>? Remediation
    {
        get => GetProperty<TerraformProperty<string>>("remediation");
        set => this.WithProperty("remediation", value);
    }

    /// <summary>
    /// Required. Immutable. A URI that represents the resource for which
    /// the occurrence applies. For example,
    /// https://gcr.io/project/image@sha256:123abc for a Docker image.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceUri is required")]
    public required TerraformProperty<string> ResourceUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_uri");
        set => this.WithProperty("resource_uri", value);
    }

    /// <summary>
    /// Block for attestation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Attestation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attestation block(s) allowed")]
    public List<GoogleContainerAnalysisOccurrenceAttestationBlock>? Attestation
    {
        get => GetProperty<List<GoogleContainerAnalysisOccurrenceAttestationBlock>>("attestation");
        set => this.WithProperty("attestation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAnalysisOccurrenceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAnalysisOccurrenceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
