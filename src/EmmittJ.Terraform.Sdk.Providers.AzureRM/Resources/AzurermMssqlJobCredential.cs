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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_agent_id attribute.
    /// </summary>
    public string? JobAgentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_agent_id")?.Value;
        set => this.WithProperty("job_agent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password_wo attribute.
    /// </summary>
    public string? PasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password_wo")?.Value;
        set => this.WithProperty("password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password_wo_version attribute.
    /// </summary>
    public double? PasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_wo_version")?.Value;
        set => this.WithProperty("password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
