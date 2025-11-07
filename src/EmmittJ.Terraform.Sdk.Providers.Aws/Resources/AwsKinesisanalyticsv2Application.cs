using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kinesisanalyticsv2_application resource.
/// </summary>
public class AwsKinesisanalyticsv2Application : TerraformResource
{
    public AwsKinesisanalyticsv2Application(string name) : base("aws_kinesisanalyticsv2_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_timestamp");
        this.DeclareOutput("last_update_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("version_id");
    }

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationMode
    {
        get => GetProperty<TerraformProperty<string>>("application_mode");
        set => this.WithProperty("application_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceStop
    {
        get => GetProperty<TerraformProperty<bool>>("force_stop");
        set => this.WithProperty("force_stop", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The runtime_environment attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("runtime_environment");
        set => this.WithProperty("runtime_environment", value);
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("service_execution_role");
        set => this.WithProperty("service_execution_role", value);
    }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    public TerraformProperty<bool>? StartApplication
    {
        get => GetProperty<TerraformProperty<bool>>("start_application");
        set => this.WithProperty("start_application", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_timestamp attribute.
    /// </summary>
    public TerraformExpression CreateTimestamp => this["create_timestamp"];

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    public TerraformExpression LastUpdateTimestamp => this["last_update_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
