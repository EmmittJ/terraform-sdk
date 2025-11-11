using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDocumentAiWarehouseLocationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_document_ai_warehouse_location resource.
/// </summary>
public partial class GoogleDocumentAiWarehouseLocation : TerraformResource
{
    public GoogleDocumentAiWarehouseLocation(string name) : base("google_document_ai_warehouse_location", name)
    {
    }

    /// <summary>
    /// The access control mode for accessing the customer data. Possible values: [&amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_GCI&amp;quot;, &amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_BYOID&amp;quot;, &amp;quot;ACL_MODE_UNIVERSAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlMode is required")]
    [TerraformProperty("access_control_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessControlMode { get; set; }

    /// <summary>
    /// The type of database used to store customer data. Possible values: [&amp;quot;DB_INFRA_SPANNER&amp;quot;, &amp;quot;DB_CLOUD_SQL_POSTGRES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseType is required")]
    [TerraformProperty("database_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseType { get; set; }

    /// <summary>
    /// The default role for the person who create a document. Possible values: [&amp;quot;DOCUMENT_ADMIN&amp;quot;, &amp;quot;DOCUMENT_EDITOR&amp;quot;, &amp;quot;DOCUMENT_VIEWER&amp;quot;]
    /// </summary>
    [TerraformProperty("document_creator_default_role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DocumentCreatorDefaultRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The KMS key used for CMEK encryption. It is required that
    /// the kms key is in the same region as the endpoint. The
    /// same key will be used for all provisioned resources, if
    /// encryption is available. If the kmsKey is left empty, no
    /// encryption will be enforced.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The location in which the instance is to be provisioned. It takes the form projects/{projectNumber}/locations/{location}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    [TerraformProperty("project_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectNumber { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDocumentAiWarehouseLocationTimeoutsBlock>? Timeouts { get; set; }

}
