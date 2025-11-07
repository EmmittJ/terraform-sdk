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
    public TerraformLiteralProperty<string>? ArtifactStoreUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("artifact_store_uri");
        set => this.WithProperty("artifact_store_uri", value);
    }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutomaticModelRegistration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_model_registration");
        set => this.WithProperty("automatic_model_registration", value);
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
    /// The mlflow_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MlflowVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mlflow_version");
        set => this.WithProperty("mlflow_version", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The tracking_server_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrackingServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracking_server_name");
        set => this.WithProperty("tracking_server_name", value);
    }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrackingServerSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracking_server_size");
        set => this.WithProperty("tracking_server_size", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WeeklyMaintenanceWindowStart
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_window_start");
        set => this.WithProperty("weekly_maintenance_window_start", value);
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
