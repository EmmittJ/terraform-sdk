using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    }

    /// <summary>
    /// The access control mode for accessing the customer data. Possible values: [&amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_GCI&amp;quot;, &amp;quot;ACL_MODE_DOCUMENT_LEVEL_ACCESS_CONTROL_BYOID&amp;quot;, &amp;quot;ACL_MODE_UNIVERSAL_ACCESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AccessControlMode
    {
        get => GetProperty<TerraformProperty<string>>("access_control_mode");
        set => this.WithProperty("access_control_mode", value);
    }

    /// <summary>
    /// The type of database used to store customer data. Possible values: [&amp;quot;DB_INFRA_SPANNER&amp;quot;, &amp;quot;DB_CLOUD_SQL_POSTGRES&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DatabaseType
    {
        get => GetProperty<TerraformProperty<string>>("database_type");
        set => this.WithProperty("database_type", value);
    }

    /// <summary>
    /// The default role for the person who create a document. Possible values: [&amp;quot;DOCUMENT_ADMIN&amp;quot;, &amp;quot;DOCUMENT_EDITOR&amp;quot;, &amp;quot;DOCUMENT_VIEWER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DocumentCreatorDefaultRole
    {
        get => GetProperty<TerraformProperty<string>>("document_creator_default_role");
        set => this.WithProperty("document_creator_default_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The KMS key used for CMEK encryption. It is required that
    /// the kms key is in the same region as the endpoint. The
    /// same key will be used for all provisioned resources, if
    /// encryption is available. If the kmsKey is left empty, no
    /// encryption will be enforced.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => this.WithProperty("kms_key", value);
    }

    /// <summary>
    /// The location in which the instance is to be provisioned. It takes the form projects/{projectNumber}/locations/{location}.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The unique identifier of the project.
    /// </summary>
    public TerraformProperty<string>? ProjectNumber
    {
        get => GetProperty<TerraformProperty<string>>("project_number");
        set => this.WithProperty("project_number", value);
    }

}
