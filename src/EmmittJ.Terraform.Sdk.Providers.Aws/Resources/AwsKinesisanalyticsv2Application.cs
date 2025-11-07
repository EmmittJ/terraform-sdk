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
    public TerraformLiteralProperty<string>? ApplicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_mode");
        set => this.WithProperty("application_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_stop");
        set => this.WithProperty("force_stop", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The runtime_environment attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RuntimeEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_environment");
        set => this.WithProperty("runtime_environment", value);
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceExecutionRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_execution_role");
        set => this.WithProperty("service_execution_role", value);
    }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StartApplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_application");
        set => this.WithProperty("start_application", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
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
