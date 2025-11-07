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
    public TerraformLiteralProperty<string>? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreatorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("creator_id");
        set => this.WithProperty("creator_id", value);
    }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnvId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("env_id");
        set => this.WithProperty("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("space_name");
        set => this.WithProperty("space_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
