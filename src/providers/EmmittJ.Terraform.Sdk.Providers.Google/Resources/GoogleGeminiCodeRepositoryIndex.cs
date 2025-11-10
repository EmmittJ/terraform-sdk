using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGeminiCodeRepositoryIndexTimeoutsBlock : TerraformBlock
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
/// Manages a google_gemini_code_repository_index resource.
/// </summary>
public class GoogleGeminiCodeRepositoryIndex : TerraformResource
{
    public GoogleGeminiCodeRepositoryIndex(string name) : base("google_gemini_code_repository_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("code_repository_index_id");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("kms_key");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Required. Id of the Code Repository Index.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndexId is required")]
    public required TerraformProperty<string> CodeRepositoryIndexId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code_repository_index_id");
        set => SetProperty("code_repository_index_id", value);
    }

    /// <summary>
    /// If set to true, will allow deletion of the CodeRepositoryIndex even if there are existing RepositoryGroups for the resource. These RepositoryGroups will also be deleted.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// Optional. Immutable. Customer-managed encryption key name, in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// Optional. Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location of the Code Repository Index, for example &#39;us-central1&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGeminiCodeRepositoryIndexTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Create time stamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Immutable. Identifier. Name of Code Repository Index.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Code Repository Index instance State.
    /// Possible values are: &#39;STATE_UNSPECIFIED&#39;, &#39;CREATING&#39;, &#39;ACTIVE&#39;, &#39;DELETING&#39;, &#39;SUSPENDED&#39;.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Update time stamp.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
