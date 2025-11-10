using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for job_target in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlJobTargetGroupJobTargetBlock : TerraformBlock
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticPoolName
    {
        get => GetProperty<TerraformProperty<string>>("elastic_pool_name");
        set => WithProperty("elastic_pool_name", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobCredentialId
    {
        get => GetProperty<TerraformProperty<string>>("job_credential_id");
        set => WithProperty("job_credential_id", value);
    }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    public TerraformProperty<string>? MembershipType
    {
        get => GetProperty<TerraformProperty<string>>("membership_type");
        set => WithProperty("membership_type", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_name");
        set => WithProperty("server_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobTargetGroupTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azurerm_mssql_job_target_group resource.
/// </summary>
public class AzurermMssqlJobTargetGroup : TerraformResource
{
    public AzurermMssqlJobTargetGroup(string name) : base("azurerm_mssql_job_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    public required TerraformProperty<string> JobAgentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("job_agent_id");
        set => this.WithProperty("job_agent_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMssqlJobTargetGroupJobTargetBlock>? JobTarget
    {
        get => GetProperty<HashSet<AzurermMssqlJobTargetGroupJobTargetBlock>>("job_target");
        set => this.WithProperty("job_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlJobTargetGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlJobTargetGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
