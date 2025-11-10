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
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The elastic_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticPoolName
    {
        set => SetProperty("elastic_pool_name", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobCredentialId
    {
        set => SetProperty("job_credential_id", value);
    }

    /// <summary>
    /// The membership_type attribute.
    /// </summary>
    public TerraformProperty<string>? MembershipType
    {
        set => SetProperty("membership_type", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        set => SetProperty("server_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("id");
        SetOutput("job_agent_id");
        SetOutput("name");
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
    /// The job_agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobAgentId is required")]
    public required TerraformProperty<string> JobAgentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_agent_id");
        set => SetProperty("job_agent_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for job_target.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMssqlJobTargetGroupJobTargetBlock>? JobTarget
    {
        set => SetProperty("job_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlJobTargetGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
