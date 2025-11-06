using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_mlflow_tracking_server resource.
/// </summary>
public class AwsSagemakerMlflowTrackingServer : TerraformResource
{
    public AwsSagemakerMlflowTrackingServer(string name) : base("aws_sagemaker_mlflow_tracking_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tracking_server_url");
    }

    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    public string? ArtifactStoreUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_store_uri")?.Value;
        set => this.WithProperty("artifact_store_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    public bool? AutomaticModelRegistration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_model_registration")?.Value;
        set => this.WithProperty("automatic_model_registration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The mlflow_version attribute.
    /// </summary>
    public string? MlflowVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mlflow_version")?.Value;
        set => this.WithProperty("mlflow_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tracking_server_name attribute.
    /// </summary>
    public string? TrackingServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracking_server_name")?.Value;
        set => this.WithProperty("tracking_server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    public string? TrackingServerSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracking_server_size")?.Value;
        set => this.WithProperty("tracking_server_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public string? WeeklyMaintenanceWindowStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_window_start")?.Value;
        set => this.WithProperty("weekly_maintenance_window_start", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    public TerraformExpression TrackingServerUrl => this["tracking_server_url"];

}
