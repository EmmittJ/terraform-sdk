using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_cloud_exadata_infrastructures.
/// </summary>
public partial class GoogleOracleDatabaseCloudExadataInfrastructuresDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseCloudExadataInfrastructuresDataSource(string name) : base("google_oracle_database_cloud_exadata_infrastructures", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The cloud_exadata_infrastructures attribute.
    /// </summary>
    [TerraformProperty("cloud_exadata_infrastructures")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CloudExadataInfrastructures { get; }

}
