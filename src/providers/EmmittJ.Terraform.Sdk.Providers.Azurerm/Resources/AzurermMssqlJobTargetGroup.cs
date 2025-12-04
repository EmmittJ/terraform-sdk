using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for job_target in AzurermMssqlJobTargetGroup.
/// Nesting mode: set
/// </summary>
public class AzurermMssqlJobTargetGroupJobTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_target";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformValue<string>? ElasticPoolName
    {
        get => GetArgument<TerraformValue<string>>("elastic_pool_name");
        set => SetArgument("elastic_pool_name", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformValue<string>? JobCredentialId
    {
        get => GetArgument<TerraformValue<string>>("job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    public TerraformValue<string>? MembershipType
    {
        get => GetArgument<TerraformValue<string>>("membership_type");
        set => SetArgument("membership_type", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformValue<string> ServerName
    {
        get => GetArgument<TerraformValue<string>>("server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}


/// <summary>
/// Block type for timeouts in AzurermMssqlJobTargetGroup.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobTargetGroupTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_mssql_job_target_group Terraform resource.
/// Manages a azurerm_mssql_job_target_group resource.
/// </summary>
public partial class AzurermMssqlJobTargetGroup(string name) : TerraformResource("azurerm_mssql_job_target_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    public required TerraformValue<string> JobAgentId
    {
        get => GetArgument<TerraformValue<string>>("job_agent_id");
        set => SetArgument("job_agent_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// JobTarget block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMssqlJobTargetGroupJobTargetBlock>? JobTarget
    {
        get => GetArgument<TerraformSet<AzurermMssqlJobTargetGroupJobTargetBlock>>("job_target");
        set => SetArgument("job_target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlJobTargetGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlJobTargetGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
