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
    public string? ApplicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_mode")?.Value;
        set => this.WithProperty("application_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    public bool? ForceStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_stop")?.Value;
        set => this.WithProperty("force_stop", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime_environment attribute.
    /// </summary>
    public string? RuntimeEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_environment")?.Value;
        set => this.WithProperty("runtime_environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    public string? ServiceExecutionRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_execution_role")?.Value;
        set => this.WithProperty("service_execution_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    public bool? StartApplication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("start_application")?.Value;
        set => this.WithProperty("start_application", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
