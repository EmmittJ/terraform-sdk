using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for spark_application_environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// A map of default Spark properties to apply to workloads in this application environment. These defaults may be overridden by per-application properties.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? DefaultProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("default_properties");
        set => WithProperty("default_properties", value);
    }

    /// <summary>
    /// The default Dataproc version to use for applications submitted to this application environment
    /// </summary>
    public TerraformProperty<string>? DefaultVersion
    {
        get => GetProperty<TerraformProperty<string>>("default_version");
        set => WithProperty("default_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataproc_gdc_application_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocGdcApplicationEnvironment : TerraformResource
{
    public GoogleDataprocGdcApplicationEnvironment(string name) : base("google_dataproc_gdc_application_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_annotations");
        this.WithOutput("effective_labels");
        this.WithOutput("name");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The annotations to associate with this application environment. Annotations may be used to store client information, but are not used by the server.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The id of the application environment
    /// </summary>
    public TerraformProperty<string>? ApplicationEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("application_environment_id");
        set => this.WithProperty("application_environment_id", value);
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The labels to associate with this application environment. Labels may be used for filtering and billing tracking. 
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
    /// The location of the application environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the namespace in which to create this ApplicationEnvironment. This namespace must already exist in the cluster
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The id of the service instance to which this application environment belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    public required TerraformProperty<string> Serviceinstance
    {
        get => GetRequiredProperty<TerraformProperty<string>>("serviceinstance");
        set => this.WithProperty("serviceinstance", value);
    }

    /// <summary>
    /// Block for spark_application_environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationEnvironmentConfig block(s) allowed")]
    public List<GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock>? SparkApplicationEnvironmentConfig
    {
        get => GetProperty<List<GoogleDataprocGdcApplicationEnvironmentSparkApplicationEnvironmentConfigBlock>>("spark_application_environment_config");
        set => this.WithProperty("spark_application_environment_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocGdcApplicationEnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. The name of the application environment. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/applicationEnvironments/{application_environment_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated unique identifier for this application environment, formatted as UUID4.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
