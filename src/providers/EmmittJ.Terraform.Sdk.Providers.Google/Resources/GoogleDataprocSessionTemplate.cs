using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateEnvironmentConfigBlock
{
}

/// <summary>
/// Block type for jupyter_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateJupyterSessionBlock
{
    /// <summary>
    /// Display name, shown in the Jupyter kernelspec card.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Kernel to be used with Jupyter interactive session. Possible values: [&amp;quot;PYTHON&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("kernel")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Kernel { get; set; }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateRuntimeConfigBlock
{
    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    [TerraformPropertyName("container_image")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerImage { get; set; }


    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// Version of the session runtime.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for spark_connect_session in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocSessionTemplateSparkConnectSessionBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocSessionTemplateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_session_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocSessionTemplate : TerraformResource
{
    public GoogleDataprocSessionTemplate(string name) : base("google_dataproc_session_template", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The labels to associate with this session template.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location in which the session template will be created in.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The resource name of the session template in the following format:
    /// projects/{project}/locations/{location}/sessionTemplates/{template_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    [TerraformPropertyName("environment_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateEnvironmentConfigBlock>>? EnvironmentConfig { get; set; }

    /// <summary>
    /// Block for jupyter_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterSession block(s) allowed")]
    [TerraformPropertyName("jupyter_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateJupyterSessionBlock>>? JupyterSession { get; set; }

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    [TerraformPropertyName("runtime_config")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateRuntimeConfigBlock>>? RuntimeConfig { get; set; }

    /// <summary>
    /// Block for spark_connect_session.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConnectSession block(s) allowed")]
    [TerraformPropertyName("spark_connect_session")]
    public TerraformList<TerraformBlock<GoogleDataprocSessionTemplateSparkConnectSessionBlock>>? SparkConnectSession { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocSessionTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the session template was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The email address of the user who created the session template.
    /// </summary>
    [TerraformPropertyName("creator")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Creator => new TerraformReference(this, "creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The time when the session template was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// A session template UUID (Unique Universal Identifier). The service generates this value when it creates the session template.
    /// </summary>
    [TerraformPropertyName("uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uuid => new TerraformReference(this, "uuid");

}
