using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobCredentialTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_job_credential resource.
/// </summary>
public class AzurermMssqlJobCredential : TerraformResource
{
    public AzurermMssqlJobCredential(string name) : base("azurerm_mssql_job_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("job_agent_id");
        SetOutput("name");
        SetOutput("password");
        SetOutput("password_wo");
        SetOutput("password_wo_version");
        SetOutput("username");
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
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformProperty<string> PasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password_wo");
        set => SetProperty("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> PasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_wo_version");
        set => SetProperty("password_wo_version", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlJobCredentialTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
