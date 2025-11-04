using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codecatalyst_dev_environment.
/// </summary>
public class AwsCodecatalystDevEnvironmentDataSource : TerraformDataSource
{
    public AwsCodecatalystDevEnvironmentDataSource(string name) : base("aws_codecatalyst_dev_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ides");
        this.DeclareOutput("inactivity_timeout_minutes");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("persistent_storage");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    public string? CreatorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creator_id")?.Value;
        set => this.WithProperty("creator_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    public string? EnvId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("env_id")?.Value;
        set => this.WithProperty("env_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project_name attribute.
    /// </summary>
    public string? ProjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_name")?.Value;
        set => this.WithProperty("project_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    public string? SpaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("space_name")?.Value;
        set => this.WithProperty("space_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ides attribute.
    /// </summary>
    public TerraformExpression Ides => this["ides"];

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformExpression InactivityTimeoutMinutes => this["inactivity_timeout_minutes"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    public TerraformExpression PersistentStorage => this["persistent_storage"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
