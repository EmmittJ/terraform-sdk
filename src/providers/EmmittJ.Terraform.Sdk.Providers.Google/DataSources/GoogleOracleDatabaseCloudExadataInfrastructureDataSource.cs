using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_cloud_exadata_infrastructure.
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructureDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseCloudExadataInfrastructureDataSource(string name) : base("google_oracle_database_cloud_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("effective_labels");
        SetOutput("entitlement_id");
        SetOutput("gcp_oracle_zone");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("properties");
        SetOutput("terraform_labels");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the Exadata Infrastructure to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbServer&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The date and time that the Exadata Infrastructure was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Entitlement ID of the private offer against which this infrastructure
    /// resource is provisioned.
    /// </summary>
    public TerraformExpression EntitlementId => this["entitlement_id"];

    /// <summary>
    /// GCP location where Oracle Exadata is hosted.
    /// </summary>
    public TerraformExpression GcpOracleZone => this["gcp_oracle_zone"];

    /// <summary>
    /// Labels or tags associated with the resource. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Identifier. The name of the Exadata Infrastructure resource with the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Various properties of Exadata Infrastructure.
    /// </summary>
    public TerraformExpression Properties => this["properties"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
