using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiWarehouseLocationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_document_ai_warehouse_location resource.
/// </summary>
public class GoogleDocumentAiWarehouseLocation : TerraformResource
{
    public GoogleDocumentAiWarehouseLocation(string name) : base("google_document_ai_warehouse_location", name)
    {
    }

    /// <summary>
    /// The access control mode for accessing the customer data. Possible values: [&amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_GCI&amp;quot;, &amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_BYOID&amp;quot;, &amp;quot;ACL_MODE_UNIVERSAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlMode is required")]
    [TerraformPropertyName("access_control_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessControlMode { get; set; }

    /// <summary>
    /// The type of database used to store customer data. Possible values: [&amp;quot;DB_INFRA_SPANNER&amp;quot;, &amp;quot;DB_CLOUD_SQL_POSTGRES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseType is required")]
    [TerraformPropertyName("database_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseType { get; set; }

    /// <summary>
    /// The default role for the person who create a document. Possible values: [&amp;quot;DOCUMENT_ADMIN&amp;quot;, &amp;quot;DOCUMENT_EDITOR&amp;quot;, &amp;quot;DOCUMENT_VIEWER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("document_creator_default_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DocumentCreatorDefaultRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The KMS key used for CMEK encryption. It is required that
    /// the kms key is in the same region as the endpoint. The
    /// same key will be used for all provisioned resources, if
    /// encryption is available. If the kmsKey is left empty, no
    /// encryption will be enforced.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// The location in which the instance is to be provisioned. It takes the form projects/{projectNumber}/locations/{location}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    [TerraformPropertyName("project_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProjectNumber { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDocumentAiWarehouseLocationTimeoutsBlock>? Timeouts { get; set; } = new();

}
