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
        SetOutput("arn");
        SetOutput("tracking_server_url");
        SetOutput("artifact_store_uri");
        SetOutput("automatic_model_registration");
        SetOutput("id");
        SetOutput("mlflow_version");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tracking_server_name");
        SetOutput("tracking_server_size");
        SetOutput("weekly_maintenance_window_start");
    }

    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStoreUri is required")]
    public required TerraformProperty<string> ArtifactStoreUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("artifact_store_uri");
        set => SetProperty("artifact_store_uri", value);
    }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticModelRegistration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_model_registration");
        set => SetProperty("automatic_model_registration", value);
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
    /// The mlflow_version attribute.
    /// </summary>
    public TerraformProperty<string> MlflowVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mlflow_version");
        set => SetProperty("mlflow_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    public required TerraformProperty<string> TrackingServerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tracking_server_name");
        set => SetProperty("tracking_server_name", value);
    }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    public TerraformProperty<string> TrackingServerSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tracking_server_size");
        set => SetProperty("tracking_server_size", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformProperty<string> WeeklyMaintenanceWindowStart
    {
        get => GetRequiredOutput<TerraformProperty<string>>("weekly_maintenance_window_start");
        set => SetProperty("weekly_maintenance_window_start", value);
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
