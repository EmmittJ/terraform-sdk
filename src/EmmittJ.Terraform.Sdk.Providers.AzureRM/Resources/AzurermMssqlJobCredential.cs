using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? JobAgentId
    {
        get => GetProperty<TerraformProperty<string>>("job_agent_id");
        set => this.WithProperty("job_agent_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? PasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("password_wo");
        set => this.WithProperty("password_wo", value);
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("password_wo_version");
        set => this.WithProperty("password_wo_version", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
