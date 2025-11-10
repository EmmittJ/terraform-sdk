using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_version in .
/// Nesting mode: list
/// </summary>
public class GoogleMlEngineModelDefaultVersionBlock : TerraformBlock
{
    /// <summary>
    /// The name specified for the version when it was created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMlEngineModelTimeoutsBlock : TerraformBlock
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
/// Manages a google_ml_engine_model resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMlEngineModel : TerraformResource
{
    public GoogleMlEngineModel(string name) : base("google_ml_engine_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The description specified for the model when it was created.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// One or more labels that you can add, to organize your models.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name specified for the model.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// If true, online prediction nodes send stderr and stdout streams to Stackdriver Logging
    /// </summary>
    public TerraformProperty<bool>? OnlinePredictionConsoleLogging
    {
        get => GetProperty<TerraformProperty<bool>>("online_prediction_console_logging");
        set => this.WithProperty("online_prediction_console_logging", value);
    }

    /// <summary>
    /// If true, online prediction access logs are sent to StackDriver Logging.
    /// </summary>
    public TerraformProperty<bool>? OnlinePredictionLogging
    {
        get => GetProperty<TerraformProperty<bool>>("online_prediction_logging");
        set => this.WithProperty("online_prediction_logging", value);
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
    /// The list of regions where the model is going to be deployed.
    /// Currently only one region per model is supported
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// Block for default_version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultVersion block(s) allowed")]
    public List<GoogleMlEngineModelDefaultVersionBlock>? DefaultVersion
    {
        get => GetProperty<List<GoogleMlEngineModelDefaultVersionBlock>>("default_version");
        set => this.WithProperty("default_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMlEngineModelTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMlEngineModelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
