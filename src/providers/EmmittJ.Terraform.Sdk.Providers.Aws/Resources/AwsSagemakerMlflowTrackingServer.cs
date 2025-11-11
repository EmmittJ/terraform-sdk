using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_mlflow_tracking_server resource.
/// </summary>
public partial class AwsSagemakerMlflowTrackingServer : TerraformResource
{
    public AwsSagemakerMlflowTrackingServer(string name) : base("aws_sagemaker_mlflow_tracking_server", name)
    {
    }

    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStoreUri is required")]
    [TerraformProperty("artifact_store_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ArtifactStoreUri { get; set; }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    [TerraformProperty("automatic_model_registration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutomaticModelRegistration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mlflow_version attribute.
    /// </summary>
    [TerraformProperty("mlflow_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MlflowVersion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    [TerraformProperty("tracking_server_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrackingServerName { get; set; }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    [TerraformProperty("tracking_server_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TrackingServerSize { get; set; }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_window_start")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WeeklyMaintenanceWindowStart { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    [TerraformProperty("tracking_server_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TrackingServerUrl { get; }

}
