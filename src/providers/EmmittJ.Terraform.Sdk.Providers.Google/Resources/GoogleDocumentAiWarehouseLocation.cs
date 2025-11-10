using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDocumentAiWarehouseLocationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_document_ai_warehouse_location resource.
/// </summary>
public class GoogleDocumentAiWarehouseLocation : TerraformResource
{
    public GoogleDocumentAiWarehouseLocation(string name) : base("google_document_ai_warehouse_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_control_mode");
        SetOutput("database_type");
        SetOutput("document_creator_default_role");
        SetOutput("id");
        SetOutput("kms_key");
        SetOutput("location");
        SetOutput("project_number");
    }

    /// <summary>
    /// The access control mode for accessing the customer data. Possible values: [&amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_GCI&amp;quot;, &amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_BYOID&amp;quot;, &amp;quot;ACL_MODE_UNIVERSAL_ACCESS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlMode is required")]
    public required TerraformProperty<string> AccessControlMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_control_mode");
        set => SetProperty("access_control_mode", value);
    }

    /// <summary>
    /// The type of database used to store customer data. Possible values: [&amp;quot;DB_INFRA_SPANNER&amp;quot;, &amp;quot;DB_CLOUD_SQL_POSTGRES&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseType is required")]
    public required TerraformProperty<string> DatabaseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_type");
        set => SetProperty("database_type", value);
    }

    /// <summary>
    /// The default role for the person who create a document. Possible values: [&amp;quot;DOCUMENT_ADMIN&amp;quot;, &amp;quot;DOCUMENT_EDITOR&amp;quot;, &amp;quot;DOCUMENT_VIEWER&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DocumentCreatorDefaultRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_creator_default_role");
        set => SetProperty("document_creator_default_role", value);
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
    /// The KMS key used for CMEK encryption. It is required that
    /// the kms key is in the same region as the endpoint. The
    /// same key will be used for all provisioned resources, if
    /// encryption is available. If the kmsKey is left empty, no
    /// encryption will be enforced.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The location in which the instance is to be provisioned. It takes the form projects/{projectNumber}/locations/{location}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectNumber is required")]
    public required TerraformProperty<string> ProjectNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_number");
        set => SetProperty("project_number", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDocumentAiWarehouseLocationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
