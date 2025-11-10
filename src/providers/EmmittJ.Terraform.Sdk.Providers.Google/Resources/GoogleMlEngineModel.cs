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
        set => SetProperty("name", value);
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
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("online_prediction_console_logging");
        SetOutput("online_prediction_logging");
        SetOutput("project");
        SetOutput("regions");
    }

    /// <summary>
    /// The description specified for the model when it was created.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// One or more labels that you can add, to organize your models.
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
    /// The name specified for the model.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// If true, online prediction nodes send stderr and stdout streams to Stackdriver Logging
    /// </summary>
    public TerraformProperty<bool> OnlinePredictionConsoleLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("online_prediction_console_logging");
        set => SetProperty("online_prediction_console_logging", value);
    }

    /// <summary>
    /// If true, online prediction access logs are sent to StackDriver Logging.
    /// </summary>
    public TerraformProperty<bool> OnlinePredictionLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("online_prediction_logging");
        set => SetProperty("online_prediction_logging", value);
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
    /// The list of regions where the model is going to be deployed.
    /// Currently only one region per model is supported
    /// </summary>
    public List<TerraformProperty<string>> Regions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("regions");
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// Block for default_version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultVersion block(s) allowed")]
    public List<GoogleMlEngineModelDefaultVersionBlock>? DefaultVersion
    {
        set => SetProperty("default_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMlEngineModelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
