using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for jupyter_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateJupyterSessionBlock : TerraformBlock
{
    /// <summary>
    /// Display name, shown in the Jupyter kernelspec card.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// Kernel to be used with Jupyter interactive session. Possible values: [&amp;quot;PYTHON&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Kernel
    {
        get => GetProperty<TerraformProperty<string>>("kernel");
        set => WithProperty("kernel", value);
    }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateRuntimeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    public TerraformProperty<string>? ContainerImage
    {
        get => GetProperty<TerraformProperty<string>>("container_image");
        set => WithProperty("container_image", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EffectiveProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("effective_properties");
        set => WithProperty("effective_properties", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// Version of the session runtime.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for spark_connect_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateSparkConnectSessionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocSessionTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataproc_session_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocSessionTemplate : TerraformResource
{
    public GoogleDataprocSessionTemplate(string name) : base("google_dataproc_session_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("creator");
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
        this.WithOutput("uuid");
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
    /// The labels to associate with this session template.
    /// 
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
    /// The location in which the session template will be created in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the session template in the following format:
    /// projects/{project}/locations/{location}/sessionTemplates/{template_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    public List<GoogleDataprocSessionTemplateEnvironmentConfigBlock>? EnvironmentConfig
    {
        get => GetProperty<List<GoogleDataprocSessionTemplateEnvironmentConfigBlock>>("environment_config");
        set => this.WithProperty("environment_config", value);
    }

    /// <summary>
    /// Block for jupyter_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterSession block(s) allowed")]
    public List<GoogleDataprocSessionTemplateJupyterSessionBlock>? JupyterSession
    {
        get => GetProperty<List<GoogleDataprocSessionTemplateJupyterSessionBlock>>("jupyter_session");
        set => this.WithProperty("jupyter_session", value);
    }

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    public List<GoogleDataprocSessionTemplateRuntimeConfigBlock>? RuntimeConfig
    {
        get => GetProperty<List<GoogleDataprocSessionTemplateRuntimeConfigBlock>>("runtime_config");
        set => this.WithProperty("runtime_config", value);
    }

    /// <summary>
    /// Block for spark_connect_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConnectSession block(s) allowed")]
    public List<GoogleDataprocSessionTemplateSparkConnectSessionBlock>? SparkConnectSession
    {
        get => GetProperty<List<GoogleDataprocSessionTemplateSparkConnectSessionBlock>>("spark_connect_session");
        set => this.WithProperty("spark_connect_session", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocSessionTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocSessionTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the session template was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The email address of the user who created the session template.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the session template was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}
