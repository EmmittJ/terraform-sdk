using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocSessionTemplateEnvironmentConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for jupyter_session in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocSessionTemplateJupyterSessionBlock : TerraformBlockBase
{
    /// <summary>
    /// Display name, shown in the Jupyter kernelspec card.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Kernel to be used with Jupyter interactive session. Possible values: [&amp;quot;PYTHON&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    [TerraformProperty("kernel")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Kernel { get; set; }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocSessionTemplateRuntimeConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    [TerraformProperty("container_image")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerImage { get; set; }


    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// Version of the session runtime.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for spark_connect_session in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocSessionTemplateSparkConnectSessionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocSessionTemplateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_session_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocSessionTemplate : TerraformResource
{
    public GoogleDataprocSessionTemplate(string name) : base("google_dataproc_session_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels to associate with this session template.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location in which the session template will be created in.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The resource name of the session template in the following format:
    /// projects/{project}/locations/{location}/sessionTemplates/{template_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    [TerraformProperty("environment_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateEnvironmentConfigBlock>>? EnvironmentConfig { get; set; }

    /// <summary>
    /// Block for jupyter_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterSession block(s) allowed")]
    [TerraformProperty("jupyter_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateJupyterSessionBlock>>? JupyterSession { get; set; }

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    [TerraformProperty("runtime_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateRuntimeConfigBlock>>? RuntimeConfig { get; set; }

    /// <summary>
    /// Block for spark_connect_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConnectSession block(s) allowed")]
    [TerraformProperty("spark_connect_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateSparkConnectSessionBlock>>? SparkConnectSession { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataprocSessionTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the session template was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The email address of the user who created the session template.
    /// </summary>
    [TerraformProperty("creator")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Creator { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time when the session template was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uuid { get; }

}
