using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GoogleVertexAiReasoningEngine.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource.
    /// Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for spec in GoogleVertexAiReasoningEngine.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// Optional. The OSS agent framework used to develop the agent.
    /// </summary>
    public TerraformValue<string>? AgentFramework
    {
        get => GetArgument<TerraformValue<string>>("agent_framework");
        set => SetArgument("agent_framework", value);
    }

    /// <summary>
    /// Optional. Declarations for object class methods in OpenAPI specification format.
    /// </summary>
    public TerraformValue<string>? ClassMethods
    {
        get => GetArgument<TerraformValue<string>>("class_methods");
        set => SetArgument("class_methods", value);
    }

    /// <summary>
    /// Optional. The service account that the Reasoning Engine artifact runs as.
    /// It should have &amp;quot;roles/storage.objectViewer&amp;quot; for reading the user project&#39;s
    /// Cloud Storage and &amp;quot;roles/aiplatform.user&amp;quot; for using Vertex extensions.
    /// If not specified, the Vertex AI Reasoning Engine service Agent in the project will be used.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// DeploymentSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlock>? DeploymentSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlock>>("deployment_spec");
        set => SetArgument("deployment_spec", value);
    }

    /// <summary>
    /// PackageSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PackageSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiReasoningEngineSpecBlockPackageSpecBlock>? PackageSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiReasoningEngineSpecBlockPackageSpecBlock>>("package_spec");
        set => SetArgument("package_spec", value);
    }

}

/// <summary>
/// Block type for deployment_spec in GoogleVertexAiReasoningEngineSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_spec";

    /// <summary>
    /// Env block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformSet<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

    /// <summary>
    /// SecretEnv block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlock>? SecretEnv
    {
        get => GetArgument<TerraformSet<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlock>>("secret_env");
        set => SetArgument("secret_env", value);
    }

}

/// <summary>
/// Block type for env in GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlock.
/// Nesting mode: set
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// The name of the environment variable. Must be a valid C identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for secret_env in GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlock.
/// Nesting mode: set
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_env";

    /// <summary>
    /// The name of the environment variable. Must be a valid C identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SecretRef block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretRef is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecretRef block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretRef block(s) allowed")]
    public required TerraformList<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlockSecretRefBlock> SecretRef
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlockSecretRefBlock>>("secret_ref");
        set => SetArgument("secret_ref", value);
    }

}

/// <summary>
/// Block type for secret_ref in GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlockDeploymentSpecBlockSecretEnvBlockSecretRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_ref";

    /// <summary>
    /// The name of the secret in Cloud Secret Manager. Format: {secret_name}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformValue<string> Secret
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret");
        set => SetArgument("secret", value);
    }

    /// <summary>
    /// The Cloud Secret Manager secret version. Can be &#39;latest&#39; for the latest version, an integer for a specific version, or a version alias.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for package_spec in GoogleVertexAiReasoningEngineSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiReasoningEngineSpecBlockPackageSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "package_spec";

    /// <summary>
    /// Optional. The Cloud Storage URI of the dependency files in tar.gz format.
    /// </summary>
    public TerraformValue<string>? DependencyFilesGcsUri
    {
        get => GetArgument<TerraformValue<string>>("dependency_files_gcs_uri");
        set => SetArgument("dependency_files_gcs_uri", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of the pickled python object.
    /// </summary>
    public TerraformValue<string>? PickleObjectGcsUri
    {
        get => GetArgument<TerraformValue<string>>("pickle_object_gcs_uri");
        set => SetArgument("pickle_object_gcs_uri", value);
    }

    /// <summary>
    /// Optional. The Python version.
    /// </summary>
    public TerraformValue<string>? PythonVersion
    {
        get => GetArgument<TerraformValue<string>>("python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of the requirements.txt file
    /// </summary>
    public TerraformValue<string>? RequirementsGcsUri
    {
        get => GetArgument<TerraformValue<string>>("requirements_gcs_uri");
        set => SetArgument("requirements_gcs_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiReasoningEngine.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiReasoningEngineTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vertex_ai_reasoning_engine Terraform resource.
/// Manages a google_vertex_ai_reasoning_engine resource.
/// </summary>
public partial class GoogleVertexAiReasoningEngine(string name) : TerraformResource("google_vertex_ai_reasoning_engine", name)
{
    /// <summary>
    /// The description of the ReasoningEngine.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the ReasoningEngine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the reasoning engine. eg us-central1
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The generated name of the ReasoningEngine, in the format
    /// &#39;projects/{project}/locations/{location}/reasoningEngines/{reasoningEngine}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleVertexAiReasoningEngineEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleVertexAiReasoningEngineEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleVertexAiReasoningEngineSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleVertexAiReasoningEngineSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiReasoningEngineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiReasoningEngineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
