using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for job_target in .
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
    [TerraformArgument("database_name")]
    public TerraformValue<string>? DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    [TerraformArgument("elastic_pool_name")]
    public TerraformValue<string>? ElasticPoolName
    {
        get => new TerraformReference<string>(this, "elastic_pool_name");
        set => SetArgument("elastic_pool_name", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformArgument("job_credential_id")]
    public TerraformValue<string>? JobCredentialId
    {
        get => new TerraformReference<string>(this, "job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    [TerraformArgument("membership_type")]
    public TerraformValue<string>? MembershipType
    {
        get => new TerraformReference<string>(this, "membership_type");
        set => SetArgument("membership_type", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformArgument("server_name")]
    public required TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }


}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_job_target_group resource.
/// </summary>
public class AzurermMssqlJobTargetGroup : TerraformResource
{
    public AzurermMssqlJobTargetGroup(string name) : base("azurerm_mssql_job_target_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    [TerraformArgument("job_agent_id")]
    public required TerraformValue<string> JobAgentId
    {
        get => new TerraformReference<string>(this, "job_agent_id");
        set => SetArgument("job_agent_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("job_target")]
    public TerraformSet<AzurermMssqlJobTargetGroupJobTargetBlock> JobTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlJobTargetGroupTimeoutsBlock Timeouts { get; set; } = new();

}
