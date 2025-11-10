using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_mlflow_tracking_server resource.
/// </summary>
public class AwsSagemakerMlflowTrackingServer : TerraformResource
{
    public AwsSagemakerMlflowTrackingServer(string name) : base("aws_sagemaker_mlflow_tracking_server", name)
    {
    }

    /// <summary>
    /// The artifact_store_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactStoreUri is required")]
    [TerraformPropertyName("artifact_store_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ArtifactStoreUri { get; set; }

    /// <summary>
    /// The automatic_model_registration attribute.
    /// </summary>
    [TerraformPropertyName("automatic_model_registration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticModelRegistration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mlflow_version attribute.
    /// </summary>
    [TerraformPropertyName("mlflow_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MlflowVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mlflow_version");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tracking_server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackingServerName is required")]
    [TerraformPropertyName("tracking_server_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TrackingServerName { get; set; }

    /// <summary>
    /// The tracking_server_size attribute.
    /// </summary>
    [TerraformPropertyName("tracking_server_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrackingServerSize { get; set; }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_window_start")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceWindowStart { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_window_start");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The tracking_server_url attribute.
    /// </summary>
    [TerraformPropertyName("tracking_server_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrackingServerUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tracking_server_url");

}
