using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rag_managed_db_config in GoogleVertexAiRagEngineConfig.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rag_managed_db_config";

    /// <summary>
    /// Basic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    public TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockBasicBlock>? Basic
    {
        get => GetArgument<TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockBasicBlock>>("basic");
        set => SetArgument("basic", value);
    }

    /// <summary>
    /// Scaled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scaled block(s) allowed")]
    public TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockScaledBlock>? Scaled
    {
        get => GetArgument<TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockScaledBlock>>("scaled");
        set => SetArgument("scaled", value);
    }

    /// <summary>
    /// Unprovisioned block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unprovisioned block(s) allowed")]
    public TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockUnprovisionedBlock>? Unprovisioned
    {
        get => GetArgument<TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockUnprovisionedBlock>>("unprovisioned");
        set => SetArgument("unprovisioned", value);
    }

}

/// <summary>
/// Block type for basic in GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockBasicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic";

}

/// <summary>
/// Block type for scaled in GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockScaledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaled";

}

/// <summary>
/// Block type for unprovisioned in GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiRagEngineConfigRagManagedDbConfigBlockUnprovisionedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unprovisioned";

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiRagEngineConfig.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiRagEngineConfigTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vertex_ai_rag_engine_config Terraform resource.
/// Manages a google_vertex_ai_rag_engine_config resource.
/// </summary>
public partial class GoogleVertexAiRagEngineConfig(string name) : TerraformResource("google_vertex_ai_rag_engine_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the RagEngineConfig. eg us-central1
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource name of the Dataset. This value is set by Google.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// RagManagedDbConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RagManagedDbConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RagManagedDbConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RagManagedDbConfig block(s) allowed")]
    public required TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock> RagManagedDbConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiRagEngineConfigRagManagedDbConfigBlock>>("rag_managed_db_config");
        set => SetArgument("rag_managed_db_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiRagEngineConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiRagEngineConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
